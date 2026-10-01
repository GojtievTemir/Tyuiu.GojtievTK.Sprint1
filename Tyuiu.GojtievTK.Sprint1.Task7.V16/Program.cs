using Tyuiu.GojtievTK.Sprint1.Task7.V19.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task7.V19
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
            Console.WriteLine("* Задание #5                                                                                           *");
            Console.WriteLine("* Вариант #3                                                                                           *");
            Console.WriteLine("* Выполнил: Гойтиев Темирсолтан Крымсолтанович | ПКТБ-26-1                                             *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных          *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                    ");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            double x;
            Console.WriteLine(" Введите значение X:");
            x = double.Parse((Console.ReadLine()));
         


            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
