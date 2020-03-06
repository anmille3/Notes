using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Drew Miller

            string[] subjects = new string[3];
            int[] courseNumber = new int[3];

            for (int i = 0; i < courseNumber.Length; i++)
            {
                Console.WriteLine($"Please enter the subject for the course {i + 1}>>");
                string subject = Console.ReadLine();
                subjects[i] = subject;

                Console.WriteLine($"Please enter the course number {i + 1}>>");
                courseNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            int counter = 0;

            while (counter < courseNumber.Length)
            {
                Console.WriteLine($"{subjects[counter]}{courseNumber[counter]}");

                counter++;
            }

            List<double> grades = new List<double>();
            string answer = string.Empty;

            do
            {
                Console.WriteLine("Please enter your grade >>");
                string gradeAsAString = Console.ReadLine();
                double grade;
                while (double.TryParse(gradeAsAString, out grade) == false)
                {
                    Console.WriteLine("Invalid entry, please try again");
                    Console.WriteLine("Please enter your grade >>");
                    gradeAsAString = Console.ReadLine();
                }

                grades.Add(grade);
                Console.WriteLine("Do you want to enter another grade? yes or no");
                answer = Console.ReadLine().ToLower().Trim();
            } while (answer != "no");

            double sum = 0;

            foreach (double grade in grades)
            {
                sum += grade;
            }

            double average = sum / grades.Count;
        }
    }
}
