namespace Task2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Коефіцієнти a, b, c
        double a = 1, b = 2, c = 1;

        // Лямбда-вираз для обчислення квадратичної функції y = ax^2 + bx + c
        Func<double, double> quadraticFunction = (x) => a * x * x + b * x + c;

        // Виводимо значення функції для x від 0 до 10 з кроком 1
        for (double x = 0; x <= 10; x++)
        {
            double y = quadraticFunction(x); // обчислюємо значення функції
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}