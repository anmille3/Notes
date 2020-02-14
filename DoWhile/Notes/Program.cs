using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int index2 = 0:
            //int index = 1;
            //int index2 = 1;

            Console.WriteLine("Do while loop.");
            do
            {
                Console.WriteLine($"Index count is: {index} in the loop before increment.");
                Console.WriteLine($"Index count is: {index} in the loop after the increment.");

            }
            while (index < 1);
            Console.WriteLine($"Index count is: {index} outside the loop after the increment.");

            Console.WriteLine("While loop:");
            Console.WriteLine($"Index count is: {index2} in the loop after the increment.");
            while (index2 < 1)
            {
                Console.WriteLine($"Index count is: {index2} in the loop before increment.");
                index2++;
                Console.WriteLine($"Index count is: {index2} in the loop after increment.");
            }
            Console.WriteLine();

          
        }
    }
}
