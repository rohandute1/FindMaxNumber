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
    
            int result1 = GetMax(30, 10, 25);
            Console.WriteLine("Test case 1:- Gievn max number at 1st position: " + result1);

            int result2 = GetMax(20, 33, 50);
            Console.WriteLine("Test case 2:- Gievn max number at 2nd position: " + result2);

            int result3 = GetMax(30, 25, 60);
            Console.WriteLine("Test case 3:- Gievn max number at 3rd position: " + result3);

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
