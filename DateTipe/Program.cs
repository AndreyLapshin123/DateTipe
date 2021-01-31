using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());

            float distanceInMeters =distance * 0.001f;
            
            Console.WriteLine($"{distanceInMeters:f2}");
        }
    }
}
