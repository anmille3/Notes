using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string newfirstName = firstName.ToUpper();
            string newmiddleName = middleName.ToUpper();
            string newlastName = lastName.ToUpper();

            Console.WriteLine($"{newfirstName[0]}.{newmiddleName[0]}.{newlastName[0]}.");

            Console.ReadKey();
        }
    }
}
