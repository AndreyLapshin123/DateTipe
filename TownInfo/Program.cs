using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var townName = Console.ReadLine();
            var population = int.Parse(Console.ReadLine());
            ushort area = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
