using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;

namespace TWSHelper
{
    public enum ContractType
    {
        STK,
        FUT,
        OPT,
        FOP,
        CFD,
        FX,
        IND
    }
    public class Asset
    {
        public Contract IB_Contract { get; set; }

        public ContractType Type { get; set; }

        public string AssetID { get; set; }

        public decimal Ask { get; set; }
        public decimal Bid { get; set; }

        public double delta { get; set; }
        public double gamma { get; set; }
        public double vega { get; set; }
        public double theta { get; set; }
        public double iv { get; set; }

        public int Ask_Size { get; set; }
        public int Bid_Size { get; set; }

        public Asset(Contract theContract)
        {
            IB_Contract = theContract;

            if (theContract.SecType == "STK")
            {
                Type = ContractType.STK;
                AssetID = theContract.Symbol;
            }
            else if (theContract.SecType == "FUT")
            {
                Type = ContractType.FUT;
                AssetID = string.Format("{0}.{1}", theContract.Symbol, theContract.Expiry);
            }
            else if (theContract.SecType == "OPT")
            {
                Type = ContractType.OPT;
                AssetID = string.Format("OPT.{0}.{1}.{2}.{3}", theContract.Symbol, theContract.Expiry, theContract.Right, theContract.Strike.ToString());
            }
            else if (theContract.SecType == "FOP")
            {
                Type = ContractType.FOP;
                AssetID = string.Format("FOP.{0}.{1}.{2}.{3}", theContract.Symbol, theContract.Expiry, theContract.Right, theContract.Strike.ToString());
            }
            else if (theContract.SecType == "CFD")
            {
                Type = ContractType.CFD;
            }
            else if (theContract.SecType == "IND")
            {
                Type = ContractType.IND;
            }
        }

        public Asset(string strAssetID)
        {
            AssetID = strAssetID;

            if (strAssetID.Contains("."))
            {
                int first_dot = strAssetID.IndexOf(".");

                if (strAssetID.StartsWith("OPT"))
                {
                    Type = ContractType.OPT;

                    string[] splited_opt = strAssetID.Split('.');

                    IB_Contract = ContractFactory.getOption(splited_opt[1], Convert.ToDouble(splited_opt[4]), splited_opt[3], "USD", splited_opt[2], "SMART");

                }
                else if (strAssetID.StartsWith("FOP"))
                {
                    Type = ContractType.FOP;

                    string[] splited_fop = strAssetID.Split('.');

                    IB_Contract = ContractFactory.getFOP(splited_fop[1], Convert.ToDouble(splited_fop[4]), splited_fop[3], "USD", splited_fop[2], "SMART");
                }
                else
                {
                    Type = ContractType.FUT;

                    string future_symbol = strAssetID.Substring(0, first_dot);
                    string future_expire = strAssetID.Substring(first_dot + 1, strAssetID.Length - first_dot - 1);

                    IB_Contract = ContractFactory.getFuture(future_symbol, "SMART", future_expire, "USD");
                }
            }
            else
            {
                if (strAssetID.Length == 6 && strAssetID.EndsWith("USD"))
                {
                    IB_Contract = ContractFactory.getCurrency(strAssetID.Substring(0, 3));
                    Type = ContractType.FX;
                }
                else if (strAssetID.Length == 6 && strAssetID.StartsWith("USD"))
                {
                    IB_Contract = ContractFactory.getCurrency2(strAssetID.Substring(3, 3));
                    Type = ContractType.FX;
                }
                else
                {
                    IB_Contract = ContractFactory.getStock(strAssetID, "SMART", "USD");
                    Type = ContractType.STK;
                }
            }
        }

        public void UpdateMarketData(MKT_MESSAGE Message)
        {
            if (Message.Type == MKT_MESSAGE.MessageType.BOTH)
            {
                this.Ask = Message.Ask;
                this.Bid = Message.Bid;
            }
            else if (Message.Type == MKT_MESSAGE.MessageType.ASK_ONLY)
            {
                this.Ask = Message.Ask;
            }
            else if (Message.Type == MKT_MESSAGE.MessageType.BID_ONLY)
            {
                this.Bid = Message.Bid;
            }
            else if (Message.Type == MKT_MESSAGE.MessageType.ASK_WITH_SIZE)
            {
                this.Ask = Message.Ask;
                this.Ask_Size = Message.Ask_Size;
            }
            else if (Message.Type == MKT_MESSAGE.MessageType.BID_WITH_SIZE)
            {
                this.Bid = Message.Bid;
                this.Bid_Size = Message.Bid_Size;
            }
            else if (Message.Type == MKT_MESSAGE.MessageType.BOTH_WITH_SIZE)
            {
                this.Ask = Message.Ask;
                this.Ask_Size = Message.Ask_Size;

                this.Bid = Message.Bid;
                this.Bid_Size = Message.Bid_Size;
            }
        }

        public void UpdateGreeks(double delta, double gamma, double vega, double theta)
        {
            this.delta = delta;
            this.gamma = gamma;
            this.vega = vega;
            this.theta = theta;

            string strMessage = string.Format("GREEKS:{0}/{1}/{2}/{3}/{4}", this.AssetID,
                this.delta.ToString(), this.gamma.ToString(), this.vega.ToString(), this.theta.ToString());
        }

        public void UpdateIV(double iv)
        {
            this.iv = iv;
            string strMessaeg = string.Format("IV:{0}/{1}", this.AssetID, this.iv.ToString());
        }
    }
}
