using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinanceAPIReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.binance.com/api/v3/klines?symbol=BTTUSDT&interval=1m";
            
            WebClient webClient = new WebClient();
            
            string apiResponse = webClient.DownloadString(url);
            var resultJson = JsonConvert.DeserializeObject<object[][]>(apiResponse);
            
            var candleSticks = resultJson.ToCandleSticks();

            printCandleStick(candleSticks);
        }

        private static void printCandleStick(List<CandleStick> candles)
        {
            Thread.Sleep(200);
            Console.WriteLine("****************************************************************");
            foreach (var candle in candles)
            {
                Console.WriteLine($"Open: {candle.Open} Close:{candle.Close} High:{candle.High} Low:{candle.Low}");
                Thread.Sleep(200);
            }

            Console.ReadLine();
        }
    }
}
