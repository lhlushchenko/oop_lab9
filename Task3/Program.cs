namespace Task3;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вираз, який перевіряє, чи є число додатнім
        Predicate<int> isPositive = (x) => x > 0;

        // Зчитуємо значення з консолі
        Console.WriteLine("Введіть число:");
        string input = Console.ReadLine();

        // Перевірка на коректність введення
        if (int.TryParse(input, out int number))
        {
            // Використовуємо лямбда-вираз для перевірки
            bool result = isPositive(number);

            // Виводимо результат
            if (result)
                Console.WriteLine("Число додатнє.");
            else
                Console.WriteLine("Число не є додатнім.");
        }
        else
        {
            Console.WriteLine("Введено некоректне число.");
        }
    }
}