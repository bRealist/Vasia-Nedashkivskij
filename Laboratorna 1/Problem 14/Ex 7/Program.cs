using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max = 0;
            Console.Write("Введите число a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c : ");
            c = int.Parse(Console.ReadLine());
            if (max < a)
                max = a;
               if (max < b)
                   max = b;
                  if (max < c)
                      max = c;
            Console.Write($"Максимальное число - {max}");
        }
    }
}
