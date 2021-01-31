using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter = char.Parse(Console.ReadLine());

            if (letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
