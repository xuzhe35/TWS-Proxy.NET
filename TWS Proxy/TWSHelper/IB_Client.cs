using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using IBApi;

namespace TWSHelper
{
    public class IB_Client
    {
        public EWrapperImpl wrapper = new EWrapperImpl();

        /// <summary>
        /// 是否已经连接了TWS
        /// </summary>
        public bool IsConnected { get; set; }

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
    }
}
