using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum number using generics");
            int num1, num2, num3;

            Console.WriteLine("Enter the first number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = int.Parse(Console.ReadLine());

            int max = GetMax(num1, num2, num3);

            Console.WriteLine("Maximum number: " + max);

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            return max;
        }
    }
}
