using Tyuiu.GojtievTK.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task3.V15
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
            Console.WriteLine("* Задание #3                                                                                           *");
            Console.WriteLine("* Вариант #15                                                                                        *");
            Console.WriteLine("* Выполнил: Гойтиев Темирсолтан Крымсолтанович | ПКТБ-26-1                                             *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют скорости V1 км/ч и V2 которые    *");
            Console.WriteLine("*соответственно, находятся на расстоянии S км друг от друга и движутся в противоположные стороны.      *");
            Console.WriteLine("Определить расстояние между ними через T часов.                                                        *");

            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            double v1, v2, s, t;
            Console.WriteLine(" Введите скорость первого автомобиля :");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите скорость второго автомобиля :");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите расстояние :");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите время :");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.DistanceOverTime(v1,v2,s,t));
            Console.ReadLine();
        }
    }
}