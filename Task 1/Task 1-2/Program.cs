using System;

namespace Task_1_2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double r1 = GetNumber("Введите сопротивление R1 (Ом) = ");
            double r2 = GetNumber("Введите сопротивление R2 (Ом) = ");
            double r3 = GetNumber("Введите сопротивление R3 (Ом) = ");

            double r = GetResistance(r1, r2, r3);

            Console.WriteLine($"R1 = {r1}; R2 = {r2}; R3 = {r3}");
            Console.WriteLine($"Общее сопротивление R = {r} Ом");
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
        /// Вычисляет общее сопротивление трёх резисторов, соединённых параллельно.
        /// </summary>
        /// <param name="r1">Сопротивление первого резистора.</param>
        /// <param name="r2">Сопротивление второго резистора.</param>
        /// <param name="r3">Сопротивление третьего резистора.</param>
        /// <returns>Общее сопротивление цепи.</returns>
        static double GetResistance(double r1, double r2, double r3)
        {
            return 1.0 / (1.0 / r1 + 1.0 / r2 + 1.0 / r3);
        }
    }
}
