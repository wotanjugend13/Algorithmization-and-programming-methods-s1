using System;

namespace Task_2_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения |x - a| = b");

            Console.Write("Введите a = ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.Write("Введите b = ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            SolveEquation(a, b);
        }

        /// <summary>
        /// Решает уравнение |x - a| = b и выводит количество корней и их значения.
        /// </summary>
        /// <param name="a">Параметр a.</param>
        /// <param name="b">Параметр b.</param>
        static void SolveEquation(double a, double b)
        {
            if (b < 0)
            {
                Console.WriteLine("Количество корней: 0. Модуль не может быть отрицательным.");
            }
            else if (b == 0)
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
