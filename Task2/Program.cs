using System;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        // TODO: используйте передачу параметров по ссылке
        private static bool ReadData(out double average)
        {
            int number;
            int counterOfNegative = 0;
            int sumOfNegative = 0;

            string input = Console.ReadLine();
            while (!input.Equals("q") || sumOfNegative < -1000)
            {
                if (!int.TryParse(input, out number))
                {
                    average = 0;
                    return false;
                }
                if (number < 0)
                {
                    counterOfNegative++;
                    sumOfNegative += number;
                }
                input = Console.ReadLine();
            }
            average = counterOfNegative != 0 ? (double)sumOfNegative / counterOfNegative : 0;
            return true;
        }


        static void Main(string[] args)
        {
            if (ReadData(out double average))
            {
                Console.WriteLine(average);
            }
            else
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Ошибка");
            }
        }
    }
}