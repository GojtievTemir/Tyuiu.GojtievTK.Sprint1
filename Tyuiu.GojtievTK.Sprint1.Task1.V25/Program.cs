using Tyuiu.GojtievTK.Sprint1.Task1.V25.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гойтиев Т. К. | ПКТб-26-1";
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
            Console.WriteLine("* Задание #1                                                                                           *");
            Console.WriteLine("* Вариант #25                                                                                          *");
            Console.WriteLine("* Выполнил: Гойтиев Темирсолтан Крымсолтанович | ПКТБ-26-1                                             *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя  исходные данные                              *");
            Console.WriteLine("* и вычисляет результат по формуле (x*y)/(1+x) и печатает его на экране.                               *");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            double x, y;
            Console.WriteLine("Введите значения X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(Math.Round(ds.Calculate(x, y),2));
            Console.ReadLine();
        }
    }
}