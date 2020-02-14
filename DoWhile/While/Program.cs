using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password = "Sooner1957";
            Console.WriteLine("Enter the password.");
            string userInput = Console.ReadLine();
            int index = 0;
            while (password != userInput && index < 3)
            {
                Console.WriteLine("Incorrect password. Please try again, silly.");
                password = Console.ReadLine();
                index++;
            }
            Console.ReadKey();

        }
    }
}
