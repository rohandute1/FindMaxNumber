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
            int result1 = GetMax<int>(30, 10, 25);
            Console.WriteLine("Given max number at 1st position: " + result1);

            Console.WriteLine("Test case 2:");
            float result2 = GetMax<float>(20.1f, 33.7f, 50.9f);
            Console.WriteLine("Given max number at 2nd position: " + result2);

            Console.WriteLine("Test case 3:");
            string result3 = GetMax<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Given max string at 3rd position: " + result3);

            Console.WriteLine("Test case 4:");
            GenericClass<int> genericInt = new GenericClass<int>(30, 10, 25);
            int result4 = genericInt.TestMaximum();
            Console.WriteLine("Given max number using Generic Class: " + result4);

            Console.ReadLine();
        }

        static T GetMax<T>(T val1, T val2, T val3) where T : IComparable<T>
        {
            T max = val1;

            if (val2.CompareTo(max) > 0)
                max = val2;

            if (val3.CompareTo(max) > 0)
                max = val3;

            return max;
        }
    }

    class GenericClass<T> where T : IComparable<T>
    {
        private T val1;
        private T val2;
        private T val3;

        public GenericClass(T val1, T val2, T val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
        }

        public T TestMaximum()
        {
            return GetMax(val1, val2, val3);
        }

        private T GetMax(T val1, T val2, T val3)
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
