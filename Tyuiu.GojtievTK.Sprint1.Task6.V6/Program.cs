using Tyuiu.GojtievTK.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task6.V6
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
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                                                 *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k             ");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            string x;
            Console.WriteLine(" Введите строку:");
            x = Console.ReadLine();


            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.DeleteFirstLetter(x));
            Console.ReadLine();
        }
    }
}