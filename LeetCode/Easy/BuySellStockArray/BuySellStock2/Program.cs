using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySellStock2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] prices = { 7, 1, 5, 3, 6, 4 };


            StockArray stockArray = new StockArray();

            stockArray.MaxProfit(prices);



        }
    }
}
