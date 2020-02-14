using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundingInterest
{
    class Program
    {
        const double InterestRate = .0325;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your starting balance?");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many months until it will mature?");
            int months = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            while (index < 0)
            {
                balance = balance + (balance * InterestRate);
                Console.WriteLine(index.ToString(), index++);
            }
            Console.WriteLine(balance.ToString("C2"));
            Console.ReadKey();

        }

           
    }
}
