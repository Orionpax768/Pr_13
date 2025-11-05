//*******************************************************************************************
//* Практическая работа №13                                                                 *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                                 *
//* Задание: рекурсивная функция представления числа в обратном порядке                     *
//*******************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_13
{
    internal class Program
    {
        static int ReverseNumber(int num, int result = 0)
        {
            if (num == 0)
                return result;
            int lastnumber = num % 10;
            return ReverseNumber(num / 10, result * 10 + lastnumber);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Title = "Практическая работа №13";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Здравствуйте!");
                    Console.Write("Введите число(a): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new Exception("Число(a) не может(могут) быть пустым!");
                    }
                    if (!int.TryParse(input, out int number))
                    {
                        throw new Exception("Введите целое число!");
                    }
                    int reverse = ReverseNumber(number);
                    Console.WriteLine($"Перевернутое: {reverse}");
                }
                catch (FormatException fEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка:{fEx.Message}");
                    Console.ResetColor();
                }
                catch (OverflowException oEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {oEx.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Новый поиск");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                Console.ResetColor();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Новый поиск...");
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Программа завершена.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный выбор! Программа будет продолжена.");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
