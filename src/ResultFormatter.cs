using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceAPIReader
{
    public static class ResultFormatter
    {
        /// <summary>
        /// Order thettiyal myru umbum, so careful
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static List<CandleStick> ToCandleSticks(this object[][] items)
        {
            List<CandleStick> candleSticks = new List<CandleStick>();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null && items[i].Length > 0)
                {
                    candleSticks.Add(new CandleStick()
                    {
                        OpenTime = items[i][0].ToString(),
                        Open = items[i][1].ToString(),
                        High = items[i][2].ToString(),
                        Low = items[i][3].ToString(),
                        Close = items[i][4].ToString(),
                        Volume = items[i][5].ToString(),
                        CloseTime = items[i][6].ToString(),
                        QuoteAssetVolume = items[i][7].ToString(),
                        NumberOfTrades = items[i][8].ToString(),
                        TakerBuyBaseAssetVolume = items[i][9].ToString(),
                        TakerBuyQuoteAssetVolume = items[i][10].ToString(),
                        Ignore = items[i][11].ToString(),
                    });
                }
            }
            return candleSticks;
        }
    }
}
/*
 * SAMPLE RESPONSE
 * 
 * [
      [
        1499040000000,      // Open time
        "0.01634790",       // Open
        "0.80000000",       // High
        "0.01575800",       // Low
        "0.01577100",       // Close
        "148976.11427815",  // Volume
        1499644799999,      // Close time
        "2434.19055334",    // Quote asset volume
        308,                // Number of trades
        "1756.87402397",    // Taker buy base asset volume
        "28.46694368",      // Taker buy quote asset volume
        "17928899.62484339" // Ignore.
      ]
    ]
 * 
 * 
 * 
 * 
 * */