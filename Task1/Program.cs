namespace Task1;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо значення x
        Console.WriteLine("Введіть значення x:");
        string input = Console.ReadLine();

        // Перевірка на порожнє введення
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }

        // Перетворюємо введене значення на double
        if (double.TryParse(input, out double x))
        {
            // Лямбда для F(x) = cos(x + 1), коли x > 0
            Func<double, double> func1 = (y) => Math.Cos(y + 1);

            // Лямбда для F(x) = 1 - 2 * sin(x), коли x <= 0
            Func<double, double> func2 = (y) => 1 - 2 * Math.Sin(y);

            // Використовуємо відповідну лямбду залежно від значення x
            double result = (x > 0) ? func1(x) : func2(x);

            // Виводимо результат
            Console.WriteLine($"Результат обчислення F({x}) = {result}");
        }
        else
        {
            Console.WriteLine("Потрібно було ввести число");
        }
    }
}