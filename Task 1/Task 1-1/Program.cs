using System;

namespace Task_1_1
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            const double a = 1;
            const double b = 2;
            const double c = 3;

            double x = GetNumber("Введите x = ");

            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }

        /// <summary>
        /// Получает число.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Число, введенное с клавиатуры.</returns>
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        /// <summary>
        /// Получает расчёт функции.
        /// </summary>
        /// <param name="a">Константа a.</param>
        /// <param name="b">Константа b.</param>
        /// <param name="c">Константа c.</param>
        /// <param name="x">Переменная x.</param>
        /// <returns>Значение функции.</returns>
        static double GetResult(double a, double b, double c, double x)
        {
            return (a * x * x * x + 7.0 / 5.0 * b * Math.Abs(x)) /
                   (c + Math.Sqrt(x * x * x * x + x * x + 1));
        }
    }
}
