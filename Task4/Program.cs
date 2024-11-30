namespace Task4;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо кількість чисел Фібоначчі
        Console.WriteLine("Введіть кількість чисел Фібоначчі:");
        string input = Console.ReadLine();

        // Перевірка на коректність введення
        if (int.TryParse(input, out int n) && n > 0)
        {
            // Блоковий лямбда-вираз для генерації чисел Фібоначчі
            Func<int, int[]> fibonacci = (count) =>
            {
                int[] fib = new int[count];

                if (count > 0)
                    fib[0] = 0;
                if (count > 1)
                    fib[1] = 1;

                for (int i = 2; i < count; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }

                return fib;
            };

            // Викликаємо лямбда-вираз для отримання масиву чисел Фібоначчі
            int[] fibonacciNumbers = fibonacci(n);

            // Виводимо результат
            Console.WriteLine("Числа Фібоначчі:");
            foreach (var num in fibonacciNumbers)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("Введено некоректне число.");
        }
    }
}