using System;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static bool ReadBoundaries(out uint left, out uint right)
        {
            if (!uint.TryParse(Console.ReadLine(), out left))
            {
                right = 0;
                return false;
            }
            if (!uint.TryParse(Console.ReadLine(), out right) || right < left)
            {
                return false;
            }
            return true;
        }

        static void PrintPythagorasNumbers(uint left, uint right)
        {
            double c;

            for (uint a = left; a < right - 1; a++)
            {
                for (uint b = a + 1; b < right; b++)
                {
                    c = Math.Sqrt(a * a + b * b);
                    if ((c * c <= right * right) && (c - (uint)c < double.Epsilon))
                    {
                        Console.WriteLine($"{a} {b} {c}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // TODO: дополнить метод так, чтобы программа выполняла поставленную задачу
            if (!ReadBoundaries(out uint q, out uint p))
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ошибка");
            }
            else
            {
                PrintPythagorasNumbers(q, p);
            }
        }
    }
}