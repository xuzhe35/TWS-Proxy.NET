using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using IBApi;

namespace TWSHelper
{
    public struct AssetUpdate
    {
        public string strAssetID;
        public Asset theAsset;
        public DateTime TimeTip;
    }
    public class IB_Client
    {
        public EWrapperImpl wrapper = new EWrapperImpl();

        public const int TICK_ID_BASE = 10000000;

        private const int DESCRIPTION_INDEX = 0;

        private const int BID_PRICE_INDEX = 2;
        private const int ASK_PRICE_INDEX = 3;
        private const int CLOSE_PRICE_INDEX = 7;

        private const int BID_SIZE_INDEX = 1;
        private const int ASK_SIZE_INDEX = 4;
        private const int LAST_SIZE_INDEX = 5;
        private const int VOLUME_SIZE_INDEX = 6;

        protected int currentTicker = 1;

        /// <summary>
        /// 是否已经连接了TWS
        /// </summary>
        public bool IsConnected { get; set; }

        /// <summary>
        /// 已订阅的资产列表
        /// </summary>
        List<Asset> SubscribedAssets = new List<Asset>();

        /// <summary>
        /// 用于记录TickerID与资产的映射关系
        /// </summary>
        Dictionary<int, Asset> dicAssetTickerID = new Dictionary<int, Asset>();

        BroadcastBlock<AssetUpdate> UpdateBoradCast = new BroadcastBlock<AssetUpdate>((msg) => { return msg; });

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public IB_Client()
        {
            wrapper.parent_client = this;
        }

        /// <summary>
        /// 根据AssetID寻找到对应的Contract
        /// </summary>
        /// <param name="strAssetID">目前资产的AssetID</param>
        /// <returns>返回Contract，如果返回null，则说明该资产不存在或者未订阅</returns>
        private Contract GetContractByAssetID(string strAssetID)
        {
            if(SubscribedAssets.Exists((a)=>a.AssetID==strAssetID))
            {
                return SubscribedAssets.First((a) => a.AssetID == strAssetID).IB_Contract;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取Asset
        /// </summary>
        /// <param name="strAssetID">AssetID</param>
        /// <returns>返回对应的Asset，如果没有订阅过则返回null</returns>
        public Asset GetAssetByID(string strAssetID)
        {
            if(SubscribedAssets.Exists((a)=>a.AssetID==strAssetID))
            {
                return SubscribedAssets.First((a) => a.AssetID == strAssetID);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取Asset
        /// </summary>
        /// <param name="strAssetID">AssetID</param>
        /// <returns>返回对应的Asset，如果没有订阅过则返回null</returns>
        public Asset g(string strAssetID)
        {
            return GetAssetByID(strAssetID);
        }

        /// <summary>
        /// 连接到TWS
        /// </summary>
        /// <param name="IP_Address">TWS 客户端所在的IP地址</param>
        /// <param name="Port">端口号，默认为7496，模拟账号默认为7497</param>
        /// <returns>如果成功连接返回true，否则返回false</returns>
        public bool ConnectToTWS(string IP_Address, int Port)
        {
            try
            {
                wrapper.ClientSocket.eConnect(IP_Address, Port, 0, false);
                while (wrapper.NextOrderId <= 0) { }

                wrapper.NextOrderId = 2000;
                IsConnected = true;

                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message.ToString());
                return false;
            }
            finally { }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            wrapper.ClientSocket.eDisconnect();
        }

        /// <summary>
        /// 订阅一个资产
        /// </summary>
        /// <param name="asset">资产</param>
        /// <returns>1表示成功，0表示已经订阅过了，-1表示没有连接，-2表示未知错误</returns>
        public int SubscribeMarketData(Asset asset)
        {
            try
            {
                if (IsConnected)
                {
                    //检测是否已经订阅了
                    if (!SubscribedAssets.Exists((a) => a.AssetID == asset.AssetID))
                    {
                        int ticker_id = TICK_ID_BASE + (currentTicker++);
                        wrapper.ClientSocket.reqMktData(ticker_id, asset.IB_Contract, "", false, new List<TagValue>());

                        dicAssetTickerID.Add(ticker_id, asset);
                        SubscribedAssets.Add(asset);

                        return 1;
                    }
                    else
                    {
                        //如果已经订阅了，则返回false
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return -2;
            }
            finally { }
        }

        /// <summary>
        /// 订阅一个资产
        /// </summary>
        /// <param name="strAssetID">资产的描述</param>
        /// <returns>1表示成功，0表示已经订阅过了，-1表示没有连接，-2表示未知错误</returns>
        public int SubscribeMarketData(string strAssetID)
        {
            Asset newAsset = new Asset(strAssetID);
            return SubscribeMarketData(newAsset);
        }

        public int SubscribeMarketData(string strAssetID,string Exchange)
        {
            Asset newAsset = new Asset(strAssetID);
            newAsset.IB_Contract.Exchange = Exchange;
            return SubscribeMarketData(newAsset);
        }

        public int SubscribeMarketData(string strAssetID, string Exchange,string Currency)
        {
            Asset newAsset = new Asset(strAssetID);
            newAsset.IB_Contract.Exchange = Exchange;
            newAsset.IB_Contract.Currency = Currency;
            return SubscribeMarketData(newAsset);
        }

        public int a(string strAssetID)
        {
            return SubscribeMarketData(strAssetID);
        }

        public int a(string strAssetID,string Exchange)
        {
            return SubscribeMarketData(strAssetID, Exchange);
        }

        public int a(string strAssetID, string Exchange, string Currency)
        {
            return SubscribeMarketData(strAssetID, Exchange, Currency);
        }

        #region response of IB API call
        public void UpdateMKTAsk(int tickerId, int position, double price, int size)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            MKT_MESSAGE newMessage = new MKT_MESSAGE();

            newMessage.Type = MKT_MESSAGE.MessageType.ASK_ONLY;
            newMessage.Ask = Convert.ToDecimal(price);
            //newMessage.Ask_Size = size;

            theAsset.UpdateMarketData(newMessage);
        }

        public void UpdateMKTBid(int tickerId, int position, double price, int size)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            MKT_MESSAGE newMessage = new MKT_MESSAGE();

            newMessage.Type = MKT_MESSAGE.MessageType.BID_ONLY;
            newMessage.Bid = Convert.ToDecimal(price);
            //newMessage.Bid_Size = size;

            theAsset.UpdateMarketData(newMessage);
        }

        public void UpdateGreeks(int tickerId, double delta, double gamma, double vega, double theta)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            //出现-2是希腊字母计算错误导致
            if (delta == -2 || gamma == -2 || vega == -2 || theta == -2)
                return;

            theAsset.UpdateGreeks(delta, gamma, vega, theta);
        }

        public void UpdateIV(int tickerId, double iv)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            theAsset.UpdateIV(iv);
        }

        public void UpdateAskSize(int tickerId, int size)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            MKT_MESSAGE newMessage = new MKT_MESSAGE();

            newMessage.Type = MKT_MESSAGE.MessageType.ASK_WITH_SIZE;
            newMessage.Ask = theAsset.Ask;
            newMessage.Ask_Size = size;

            theAsset.UpdateMarketData(newMessage);
        }

        public void UpdateBidSize(int tickerId, int size)
        {
            Asset theAsset = SubscribedAssets[tickerId];

            MKT_MESSAGE newMessage = new MKT_MESSAGE();

            newMessage.Type = MKT_MESSAGE.MessageType.BID_WITH_SIZE;
            newMessage.Bid = theAsset.Bid;
            newMessage.Bid_Size = size;

            theAsset.UpdateMarketData(newMessage);
        }
        #endregion

        /// <summary>
        /// 以市价买入一个合约
        /// </summary>
        /// <param name="strAssetID">资产ID</param>
        /// <param name="quantity">数量</param>
        /// <returns>返回一个OrderID</returns>
        public string Buy(string strAssetID,int quantity)
        {
            return "-1";
        }

        /// <summary>
        /// 以市价卖出一个合约
        /// </summary>
        /// <param name="strAssetID">资产ID</param>
        /// <param name="quanity">数量</param>
        /// <returns>返回一个OrderID</returns>
        public string Sell(string strAssetID,int quanity)
        {
            return "-1";
        }

        public string BuyLMT(string strAssetID,int quantity,double price)
        {
            return "-1";
        }

        public string SellLMT(string strAssetID,int quanity,double price)
        {
            return "-1";
        }
    }
}
