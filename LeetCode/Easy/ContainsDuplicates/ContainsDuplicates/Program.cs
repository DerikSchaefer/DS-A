using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 43, 87, 5, 7, 865, 3, 2, 43, 14 };



            ContainsDuplicate containsDuplicates = new ContainsDuplicate();

            containsDuplicates.checkIt(nums);


        }
    }
}
