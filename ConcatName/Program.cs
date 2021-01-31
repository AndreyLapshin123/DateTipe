using System;

namespace ConcatName
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var delimiter = Console.ReadLine();

            Console.WriteLine("{0}{1}{2}", firstName, delimiter , secondName);
        }
    }
}
