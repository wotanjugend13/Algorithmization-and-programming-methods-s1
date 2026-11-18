using System;

namespace Task_2_2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите номер года: ");
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
            {
                Console.WriteLine("Ошибка: нужно ввести целое положительное число.");
                return;
            }

            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} год — високосный.");
            }
            else
            {
                Console.WriteLine($"{year} год — не високосный.");
            }
        }

        /// <summary>
        /// Определяет, является ли год високосным: год високосный, если он делится на 4
        /// и не делится на 100, за исключением годов, кратных 400.
        /// </summary>
        /// <param name="year">Номер года.</param>
        /// <returns>true, если год високосный, иначе false.</returns>
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}
