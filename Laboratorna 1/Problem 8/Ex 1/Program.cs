using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            double average;
            Console.Write("Введите число a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c : ");
            c = int.Parse(Console.ReadLine());
            average = (a + b + c) / 3;
            Console.Write($"Среднее значение = {average}");
        }
    }
}
