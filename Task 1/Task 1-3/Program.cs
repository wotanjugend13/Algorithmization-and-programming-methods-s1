using System;

namespace Task_1_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double m = GetNumber("Введите массу m (кг) = ");
            double v = GetNumber("Введите скорость v (м/с) = ");
            double r = GetNumber("Введите радиус окружности R (м) = ");

            double f = GetForce(m, v, r);

            Console.WriteLine($"m = {m}; v = {v}; R = {r}");
            Console.WriteLine($"Центростремительная сила F = {f} Н");
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
        /// Вычисляет центростремительную силу.
        /// </summary>
        /// <param name="m">Масса тела.</param>
        /// <param name="v">Скорость тела.</param>
        /// <param name="r">Радиус окружности.</param>
        /// <returns>Центростремительная сила F = m * v^2 / R.</returns>
        static double GetForce(double m, double v, double r)
        {
            return m * v * v / r;
        }
    }
}
