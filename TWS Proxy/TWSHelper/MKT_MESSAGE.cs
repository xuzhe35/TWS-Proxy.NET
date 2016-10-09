using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWSHelper
{
    public class MKT_MESSAGE
    {
        public enum MessageType
        {
            ASK_ONLY,
            BID_ONLY,
            BOTH,
            ASK_WITH_SIZE,
            BID_WITH_SIZE,
            BOTH_WITH_SIZE,
        }

        public MessageType Type { get; set; }

        public decimal Ask { get; set; }
        public decimal Bid { get; set; }

        public int Ask_Size { get; set; }
        public int Bid_Size { get; set; }
    }
}
