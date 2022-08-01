using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDupsSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 0, 0, 1, 1, 1, 2, 2, 3, 4, 5, 96 };

            RemoveDups removeDups = new RemoveDups();
            int Length = removeDups.RemoveDuplicates(numbers);

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }

            removeDups.RemoveDuplicates(numbers);


            Console.ReadLine();
        }
        
        
    }
}
