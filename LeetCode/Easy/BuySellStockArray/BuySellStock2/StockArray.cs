using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuySellStock2
{
    internal class StockArray
    {

        public int MaxProfit(int[] prices)
        {
            {

                if (prices == null || prices.Length == 0)
                {
                    return 0;
                }

                int profit = 0;

                for (int i = 0; i < prices.Length - 1; i++)
                {
                    if (prices[i + 1] > prices[i])
                    {
                        profit += (prices[i + 1] - prices[i]);
                    }
                }
                Console.WriteLine($"Your profit is {profit}");
                Console.ReadLine();
                return profit;
            }
        }
    }
}