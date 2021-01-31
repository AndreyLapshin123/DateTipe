using System;

namespace RefactorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= value; i++)
            {
                int sum = 0;
                bool isSpecial = false;
                int currNum = i;
                while (currNum > 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }
            }
        }
    }
}
