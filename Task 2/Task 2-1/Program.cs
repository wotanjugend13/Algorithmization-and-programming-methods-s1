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
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            Console.Write("Введите третье число: ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            int choice = GetChoice();
            SortOrder order = (SortOrder)choice;

            switch (order)
            {
                case SortOrder.Ascending:
                    PrintAscending(a, b, c);
                    break;
                case SortOrder.Descending:
                    PrintDescending(a, b, c);
                    break;
                default:
                    Console.WriteLine("Ошибка: нужно ввести 1 или 2.");
                    break;
            }
        }

        /// <summary>
        /// Запрашивает у пользователя порядок вывода чисел.
        /// </summary>
        /// <returns>Номер выбранного варианта или 0, если ввод некорректен.</returns>
        static int GetChoice()
        {
            Console.WriteLine("Выберите порядок вывода чисел:");
            Console.WriteLine("1 - по возрастанию");
            Console.WriteLine("2 - по убыванию");
            Console.Write("Ваш выбор: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }

            return 0;
        }

        /// <summary>
        /// Выводит три числа в порядке возрастания.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        static void PrintAscending(double a, double b, double c)
        {
            Console.Write("Числа в порядке возрастания: ");

            if (a <= b && b <= c)
            {
                Console.WriteLine($"{a}; {b}; {c}");
            }
            else if (a <= c && c <= b)
            {
                Console.WriteLine($"{a}; {c}; {b}");
            }
            else if (b <= a && a <= c)
            {
                Console.WriteLine($"{b}; {a}; {c}");
            }
            else if (b <= c && c <= a)
            {
                Console.WriteLine($"{b}; {c}; {a}");
            }
            else if (c <= a && a <= b)
            {
                Console.WriteLine($"{c}; {a}; {b}");
            }
            else
            {
                Console.WriteLine($"{c}; {b}; {a}");
            }
        }

        /// <summary>
        /// Выводит три числа в порядке убывания.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        static void PrintDescending(double a, double b, double c)
        {
            Console.Write("Числа в порядке убывания: ");

            if (a >= b && b >= c)
            {
                Console.WriteLine($"{a}; {b}; {c}");
            }
            else if (a >= c && c >= b)
            {
                Console.WriteLine($"{a}; {c}; {b}");
            }
            else if (b >= a && a >= c)
            {
                Console.WriteLine($"{b}; {a}; {c}");
            }
            else if (b >= c && c >= a)
            {
                Console.WriteLine($"{b}; {c}; {a}");
            }
            else if (c >= a && a >= b)
            {
                Console.WriteLine($"{c}; {a}; {b}");
            }
            else
            {
                Console.WriteLine($"{c}; {b}; {a}");
            }
        }
    }
}
