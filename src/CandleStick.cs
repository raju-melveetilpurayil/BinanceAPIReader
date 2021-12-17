using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceAPIReader
{
    public class CandleStick
    {
        public string OpenTime { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }
        public string CloseTime { get; set; }
        public string QuoteAssetVolume { get; set; }
        public string NumberOfTrades { get; set; }
        public string TakerBuyBaseAssetVolume { get; set; }
        public string TakerBuyQuoteAssetVolume { get; set; }
        public string Ignore { get; set; }
    }
}
