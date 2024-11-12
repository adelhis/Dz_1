using System;
namespace Dz_tumakov
{
    class Program
    {
        static void Main()
        {
            /*Лабораторная 2.1. Написать программу, которая спрашивает имя пользователя,
            и затем приветствует пользователя по имени. (Создать консольное приложение.).*/
            Console.WriteLine("Лабораторная 1");
            Console.Write("Введите ваше имя: ");
            Console.WriteLine($"Привет, {Console.ReadLine()}");

            /*Лабораторная 2.2. Написать программу, которой на вход подается два целых числа,
            на выходе – результат деления одного числа на другое. Предусмотреть обработку
            исключительной ситуации, возникающей приделении числа на ноль.*/
            Console.WriteLine("Лабораторная 2");
            Console.Write("Введите первое число: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            if (b1 != 0)
            {
                Console.WriteLine(a1 / b1);
            }
            else
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
            //Домашнее задание 2.1. Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
            Console.WriteLine("Домашнее задание 1");
            Console.Write("Введите букву: ");
            Console.WriteLine(Convert.ToChar(Convert.ToInt32(Convert.ToChar(Console.ReadLine())) + 1));
            /*Домашнее задание 2.2. Написать программу, которая решает квадратное
            уравнение.Входные данные – коэффициенты уравнения, выходные – найденные корни.*/
            Console.WriteLine("Домашнее задание 2");
            Console.Write("Введите первый коэффициент уравнения: ");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй коэффициент уравнения: ");
            double b4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третий коэффициент уравнения: ");
            double c4 = Convert.ToSingle(Console.ReadLine());
            double disc = (b4 * b4 - 4 * a4 * c4);
            if (disc < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
            }
            else
            {
                if (disc == 0)
                {
                    Console.WriteLine(-b4 / (2 * a4));
                }
                else
                {
                    Console.WriteLine((-b4 + Math.Pow(disc, 0.5)) / (2 * a4));
                    Console.WriteLine((-b4 - Math.Pow(disc, 0.5)) / (2 * a4));
                }

            }
            Console.ReadLine();
        }
    }
}