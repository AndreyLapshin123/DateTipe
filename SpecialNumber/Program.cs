using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = true;
                var sum = 0;

                var digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    isSpecial = false;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }
        }
    }
}
