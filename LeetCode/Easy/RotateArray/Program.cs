using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 20, 30, 40, 50, 60, 70, 80, 90};
            int k = 3;

            RotateArray rotateArray = new RotateArray();

            rotateArray.rotateIt(nums, k);




        }
    }
}
