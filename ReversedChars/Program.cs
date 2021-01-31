using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", thirdChar, secondChar, firstChar);
        }
    }
}
