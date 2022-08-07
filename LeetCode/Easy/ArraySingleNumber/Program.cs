using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {



            int[] nums = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6 };

            Single single = new Single();
            single.SingleNumb(nums);
        }

    }
}
