using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

            money *= 1.31M;

            Console.WriteLine($"{money:f3}");
        }
    }
}
