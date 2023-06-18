using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Find maximum number using generics");

            Console.WriteLine("Test case 1:");

            float result1 = GetMax(30.13f, 10.47f, 25.11f);
            Console.WriteLine("Gievn max number at 1st position: " + result1);

            Console.WriteLine("Test case 2:");

            float result2 = GetMax(20.25f, 33.41f, 50.28f);
            Console.WriteLine("Gievn max number at 2nd position: " + result2);

            Console.WriteLine("Test case 3:");

            float result3 = GetMax(30.13f, 25.88f, 60.34f);
            Console.WriteLine("Gievn max number at 3rd position: " + result3);

            Console.ReadLine();
        }

        static float GetMax(float num1, float num2, float num3)
        {
            float max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
        }
    }
}
