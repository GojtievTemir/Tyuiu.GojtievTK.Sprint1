using Tyuiu.GojtievTK.Sprint1.Task4.V26.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task4.V26
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
            Console.WriteLine("* Задание #4                                                                                           *");
            Console.WriteLine("* Вариант #26                                                                                          *");
            Console.WriteLine("* Выполнил: Гойтиев Темирсолтан Крымсолтанович | ПКТБ-26-1                                             *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные                               *");
            Console.WriteLine("*             вычисляет результат по формуле и печатает его на экране.                                 *");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            double x, y;
            Console.WriteLine(" Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadLine();
        }
    }
}
