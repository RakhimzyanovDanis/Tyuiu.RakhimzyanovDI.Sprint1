using Tyuiu.RakhimzyanovDI.Sprint1.Task5.V5.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Рахимзянов Д. И. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Рахимзянов Данис Илдусович | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части              *");
            Console.WriteLine("* положительного вещественного числа x (так, если x=32.597, то d=5).      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите положительное вещественное число x: ");

            double x = double.Parse(Console.ReadLine()!);

            DataService service = new DataService();

            int d = service.Calculate(x);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            

            Console.WriteLine($"Первая цифра дробной части: {d}");
        }
    }
}
