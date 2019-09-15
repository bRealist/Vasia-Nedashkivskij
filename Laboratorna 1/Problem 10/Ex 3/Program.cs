using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double lastDigit;
            Console.Write("Введите число n : ");
            n = int.Parse(Console.ReadLine());
            lastDigit = n % 10;
            Console.Write($"Последняя цифра = {lastDigit}");
        }
    }
}
