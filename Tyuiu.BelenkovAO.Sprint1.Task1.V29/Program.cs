using System;
using Tyuiu.BelenkovAO.Sprint1.Task1.V29.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelenkovAO.Sprint1.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            ISprint1Task1V29 ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Беленков А. О. | Группа СМАРТб 26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Беленков Антон Олегович | Группа СМАРТб 26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле a*b*c/(a+b+c) и печатает его на экране.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write(" Введите значение A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Введите значение B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Введите значение C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(a, b, c);

            Console.WriteLine(" Результат вычисления по формуле = " + res);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}