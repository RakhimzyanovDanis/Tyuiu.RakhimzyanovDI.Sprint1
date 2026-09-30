using Tyuiu.RakhimzyanovDI.Sprint1.Task3.V17.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Рахимзянов Д. И. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Рахимзянов Данис Илдусович | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите вещественное число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            bool result = ds.ZeroCheck(number);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            if (result)
            {
                Console.WriteLine(
                    "Среди первых трех цифр дробной части есть цифра 0.");
            }
            else
            {
                Console.WriteLine(
                    "Среди первых трех цифр дробной части нет цифры 0.");
            }

            Console.ReadKey();
        }
    }
}
