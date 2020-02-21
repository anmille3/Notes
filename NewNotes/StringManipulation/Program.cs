using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //char[] charArray = { 'a', 'b', 'c' }; //have all information
            //char[] charArray2 = new char[3]; //taking information from user

            //int[] intArray = { 1, 2, 3 };
            //int[] intArray2 = new int[4];
            //intArray2[0] = 1;
            //intArray2[1] = 2;
            //intArray2[2] = 3;
            //intArray2[3] = 4;

            string sentence = "000The quick brown fox- jumps over the lazy dog.";

            char sentenceChar = sentence[2];

            //foreach(char letter in sentence)
            //{
            //    Console.WriteLine($"{letter}");
            //}

            //string sentenceLength = sentence.PadLeft(10); //create indentation in the console. padleft is a method, not an attribute such as length

            int sentenceLength = sentence.Length;
            string truncateSentence = sentence.Substring(0,19); // giving the first 19 characters of the chararray, spaces are characters
            Console.WriteLine(truncateSentence);

            string upperCaseSentence = sentence.ToUpper();
            Console.WriteLine(upperCaseSentence);

            string trimmedSentence = sentence.Trim();
            Console.WriteLine(trimmedSentence);

            char[] trimChars = {'0'};
            string trimmedCharSentence = sentence.Trim(trimChars);
            bool removeBadChars = sentence.Contains("fox");
            string[] splitSentence = trimmedSentence.Split('-');

            Console.WriteLine(splitSentence[0] );

            Console.ReadKey();
        }
    }
}
