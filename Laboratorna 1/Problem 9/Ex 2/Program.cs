using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, h;
            double area;
            Console.Write("Введите сторону a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту h : ");
            h = int.Parse(Console.ReadLine());
            area = ((a+b)/2)*h;
            Console.Write($"Площадь трапеции = {area}");
        }
    }
}
