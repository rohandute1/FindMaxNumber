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
            Console.WriteLine("Max Number: " + result1);

            Console.WriteLine("Test case 2:");
            int result2 = GetMax(20, 33, 50, 15);
            Console.WriteLine("Max Number: " + result2);

            Console.WriteLine("Test case 3:");
            float result3 = GetMax(30.5f, 10.2f, 25.8f);
            Console.WriteLine("Max Float: " + result3);

            Console.WriteLine("Test case 4:");
            float result4 = GetMax(20.1f, 33.7f, 50.9f, 15.3f);
            Console.WriteLine("Max Float: " + result4);

            Console.WriteLine("Test case 5:");
            string result5 = GetMax("Apple", "Peach", "Banana");
            Console.WriteLine("Max string: " + result5);

            Console.WriteLine("Test case 6:");
            string result6 = GetMax("Orange", "Grapes", "Watermelon", "Kiwi");
            Console.WriteLine("Max string: " + result6);

            Console.ReadLine();
        }

        static T GetMax<T>(params T[] values) where T : IComparable<T>
        {
            return values.Max();
        }
    }
}
