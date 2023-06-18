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

            Console.WriteLine("Integers");
            int result1 = GetMax<int>(30, 10, 25);
            Console.WriteLine("Given max number at 1st position: " + result1);

            Console.WriteLine("Float");
            float result2 = GetMax<float>(20.1f, 33.7f, 50.9f);
            Console.WriteLine("Given max number at 2nd position: " + result2);

            Console.WriteLine("String");
            string result3 = GetMax<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Given max string at 3rd position: " + result3);

            Console.ReadLine();
        }

        static T GetMax<T>(T val1, T val2, T val3) where T : IComparable
        {
            T max = val1;

            if (val2.CompareTo(max) > 0)
                max = val2;

            if (val3.CompareTo(max) > 0)
                max = val3;

            return max;
        }
    }
}
