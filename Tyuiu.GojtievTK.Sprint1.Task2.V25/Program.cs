using Tyuiu.GojtievTK.Sprint1.Task2.V23.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task2.V23
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
            Console.WriteLine("*            выполняет указанные расчёты и печатает результат на экране.                               *");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            int x;
            Console.WriteLine(" Введите время в минутах (целое число):");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.ConvertMinutesToSeconds(x));
            Console.ReadLine();
        }
    }
}