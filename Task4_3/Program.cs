using System;

namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, B1, kol = 0;

            Console.WriteLine($"Введите число A");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите число B");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите число C");
            C = Convert.ToInt32(Console.ReadLine());

            while (A - C >= 0)
            {
                A -= C;
                B1 = B;
                while (B1 - C >= 0)
                {
                    B1 -= C;
                    kol++;
                }
            }
            Console.WriteLine("Всего квадратов: {0} ", kol);
        }
    }
}