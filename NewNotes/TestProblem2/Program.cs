using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblem2
{
    class Program
    {
        static void Main(string[] args)
        {//Drew Miller, this is exactly what it should be
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string newfirstName = firstName.Trim().ToUpper();
            string newmiddleName = middleName.Trim().ToUpper();
            string newlastName = lastName.Trim().ToUpper();
            


            Console.WriteLine($"{newfirstName[0]}.{newmiddleName[0]}.{newlastName[0]}.");

            Console.ReadKey();
        }
    }
    }

