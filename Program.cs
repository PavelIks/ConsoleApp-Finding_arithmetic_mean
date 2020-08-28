using System;

namespace FindingArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i * 2;
            }
            Console.WriteLine($"Cреднее арифметическое - {sum / 20}");

            Console.ReadLine();
        }
    }
}