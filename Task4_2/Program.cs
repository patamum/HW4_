using System;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolPlus = 0, kolMinus = 0, i = 1, num;
            do
            {
                Console.WriteLine($"Введите число {i}");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    kolPlus++;
                }
                if (num < 0)
                {
                    kolMinus++;
                }
                i++;
            }
            while (num != 0);
            {
                if (kolPlus > 0)
                {
                    Console.WriteLine("Количество положительных чисел: {0}", kolPlus);
                }

                if (kolMinus > 0)
                {
                    Console.WriteLine("Количество отрицательных чисел: {0}", kolMinus);
                }
            }

        }
    }
}