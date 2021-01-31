using System;
using System.Numerics;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal result = 0;

            for (int i = 0; i < n; i++)
            {
                result += decimal.Parse(Console.ReadLine());
            }


            Console.WriteLine(result);
        }
    }
}
