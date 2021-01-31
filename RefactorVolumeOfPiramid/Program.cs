using System;

namespace RefactorVolumeOfPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var volume = lenght * width * height / 3.0;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
