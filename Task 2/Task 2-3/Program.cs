using System;

namespace Task_2_3
{
    internal static class Program
    {
        /// <summary>
        /// Точность сравнения вещественных чисел.
        /// </summary>
        private const double Epsilon = 1e-9;

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения |x - a| = b");

            if (!TryReadDouble("Введите a = ", out double a))
            {
                return;
            }

            if (!TryReadDouble("Введите b = ", out double b))
            {
                return;
            }

            SolveEquation(a, b);
        }

        /// <summary>
        /// Запрашивает у пользователя вещественное число и считывает его с консоли.
        /// </summary>
        /// <param name="message">Приглашение к вводу.</param>
        /// <param name="value">Введённое число.</param>
        /// <returns>true, если число введено корректно; иначе false.</returns>
        static bool TryReadDouble(string message, out double value)
        {
            Console.Write(message);

            if (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Решает уравнение |x - a| = b и выводит количество корней и их значения.
        /// </summary>
        /// <param name="a">Параметр a.</param>
        /// <param name="b">Параметр b.</param>
        static void SolveEquation(double a, double b)
        {
            if (b < -Epsilon)
            {
                Console.WriteLine("Количество корней: 0. Модуль не может быть отрицательным.");
            }
            else if (Math.Abs(b) < Epsilon)
            {
                Console.WriteLine($"Количество корней: 1. x = {a}");
            }
            else
            {
                double x1 = a - b;
                double x2 = a + b;

                Console.WriteLine($"Количество корней: 2. x1 = {x1}; x2 = {x2}");
            }
        }
    }
}