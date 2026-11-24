using System;

namespace Task_2_1
{
    /// <summary>
    /// Порядок вывода чисел.
    /// </summary>
    internal enum SortOrder
    {
        /// <summary>
        /// По возрастанию.
        /// </summary>
        Ascending = 1,

        /// <summary>
        /// По убыванию.
        /// </summary>
        Descending = 2
    }

    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            if (!ReadNumber("Введите первое число: ", out double a) ||
                !ReadNumber("Введите второе число: ", out double b) ||
                !ReadNumber("Введите третье число: ", out double c))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.WriteLine("Выберите порядок вывода чисел:");
            Console.WriteLine($"{SortOrder.Ascending} - по возрастанию");
            Console.WriteLine($"{SortOrder.Descending} - по убыванию");
            Console.Write("Ваш выбор: ");

            if (!Enum.TryParse(Console.ReadLine(), true, out SortOrder order) ||
                !Enum.IsDefined(typeof(SortOrder), order))
            {
                Console.WriteLine("Ошибка: выберите правильный вариант.");
                return;
            }

            SortAndPrint(a, b, c, order);
        }

        /// <summary>
        /// Запрашивает у пользователя вещественное число и считывает его с консоли.
        /// </summary>
        /// <param name="message">Приглашение к вводу.</param>
        /// <param name="number">Введённое число.</param>
        /// <returns>true, если число введено корректно; иначе false.</returns>
        static bool ReadNumber(string message, out double number)
        {
            Console.Write(message);
            return double.TryParse(Console.ReadLine(), out number);
        }

        /// <summary>
        /// Сортирует три числа и выводит их в выбранном порядке.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <param name="order">Порядок вывода.</param>
        static void SortAndPrint(double a, double b, double c, SortOrder order)
        {
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            if (a > c)
            {
                double temp = a;
                a = c;
                c = temp;
            }

            if (b > c)
            {
                double temp = b;
                b = c;
                c = temp;
            }

            if (order == SortOrder.Ascending)
            {
                Console.WriteLine($"Числа по возрастанию: {a}; {b}; {c}");
            }
            else
            {
                Console.WriteLine($"Числа по убыванию: {c}; {b}; {a}");
            }
        }
    }
}