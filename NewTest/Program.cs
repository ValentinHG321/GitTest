using System;
using System.Numerics;

namespace NewTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger count = input;
            

            for (int i = 1; i < input; i++)
            {
                count *= i;
            }

            Console.WriteLine(count);
        }
    }
}
