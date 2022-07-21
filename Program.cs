using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string prompt = "The number is even: ";
            Console.WriteLine(prompt + EvenOrOddUsingModulus(GettingNewRandomNumber()));
            Console.WriteLine(prompt + EvenOrOddUsingLoop(GettingNewRandomNumber()));
            Console.WriteLine(prompt + EvenOrOddUsingRoundingUpOfIntegers(GettingNewRandomNumber()));
            Console.WriteLine(prompt + EvenOrOddUsingBitwiseOperator(GettingNewRandomNumber()));
        }

        public static int GettingNewRandomNumber()
        {
            Random rnd = new Random();
            int x = rnd.Next();
            Console.WriteLine("\n" + x);
            return x;
        }
        public static bool EvenOrOddUsingModulus(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public static bool EvenOrOddUsingLoop(int x)
        {
            bool isEven = true;
            for (int i = 1; i <= x; i++)
            {
                isEven = !isEven;
            }
            return isEven;
        }

        public static bool EvenOrOddUsingRoundingUpOfIntegers(int x)
        {
            if (x == (x / 2) * 2)
            {
                return true;
            }
            else return false;
        }

        public static bool EvenOrOddUsingBitwiseOperator(int x)
        {
            var bit = x & 1;
            if (bit == 0)
                return true;
            else return false;
        }
    }
}