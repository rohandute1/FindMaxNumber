using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum string using generics");

            Console.WriteLine("Test case 1:");

            string result1 = GetMax("Peach", "Apple", "Banana");
            Console.WriteLine("Given max string at 1st position: " + result1);

            Console.WriteLine("Test case 2:");

            string result2 = GetMax("Grapes", "Watermelon", "Orange");
            Console.WriteLine("Given max string at 2nd position: " + result2);

            Console.WriteLine("Test case 3:");

            string result3 = GetMax("Mango", "Kiwi", "Pineapple");
            Console.WriteLine("Given max string at 3rd position: " + result3);

            Console.ReadLine();
        }

        static string GetMax(string str1, string str2, string str3)
        {
            string max = str1;

            if (string.Compare(str2, max) > 0)
                max = str2;

            if (string.Compare(str3, max) > 0)
                max = str3;

            return max;
        }
    }
}
