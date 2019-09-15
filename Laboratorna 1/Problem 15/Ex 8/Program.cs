using System;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, k = 0;
            Console.Write("Введите число a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c : ");
            c = int.Parse(Console.ReadLine());
            if (a < 0)
                k++;
            if (b < 0)
                k++;
            if (c < 0)
                k++;
            if (k % 2 == 0)
                Console.Write("Positive");
            else
                Console.Write("Negative");
        }
    }
}
