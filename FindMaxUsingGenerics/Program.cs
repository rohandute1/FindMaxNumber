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
            Console.WriteLine("Welcome to Find maximum using generics");

            Console.WriteLine("Test case 1:");
            int result1 = GetMax(30, 10, 25);
            PrintMax(result1);
            Console.WriteLine("Given max number at 1st position: " + result1);

            Console.WriteLine("Test case 2:");
            int result2 = GetMax(20, 33, 50, 15);
            PrintMax(result2);
            Console.WriteLine("Given max number at 2nd position: " + result2);

            Console.WriteLine("Test case 3:");
            float result3 = GetMax(30.5f, 10.2f, 25.8f);
            PrintMax(result3);
            Console.WriteLine("Given max number at 3rd position: " + result3);

            Console.WriteLine("Test case 4:");
            float result4 = GetMax(20.1f, 33.7f, 50.9f, 15.3f);
            PrintMax(result4);
            Console.WriteLine("Given max number at 4th position: " + result4);

            Console.WriteLine("Test case 5:");
            string result5 = GetMax("Apple", "Peach", "Banana");
            PrintMax(result5);
            Console.WriteLine("Given max string at 5th position: " + result5);

            Console.WriteLine("Test case 6:");
            string result6 = GetMax("Orange", "Grapes", "Watermelon", "Kiwi");
            PrintMax(result6);
            Console.WriteLine("Given max string at 6th position: " + result6);

            Console.ReadLine();
        }

        static T GetMax<T>(params T[] values) where T : IComparable<T>
        {
            T max = values.Max();
            PrintMax(max);
            return max;
        }

        static void PrintMax<T>(T max)
        {
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
