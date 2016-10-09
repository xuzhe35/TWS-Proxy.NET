using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWSHelper
{
    public class P
    {
        double Ask { get; set; }
        double Bid { get; set; }
        int AskSize { get; set; }
        int BidSize { get; set; }
    }

    public class G
    {
        double Delta { get; set; }
        double Gamma { get; set; }
        double Vega { get; set; }
        double Theta { get; set; }
    }
}
