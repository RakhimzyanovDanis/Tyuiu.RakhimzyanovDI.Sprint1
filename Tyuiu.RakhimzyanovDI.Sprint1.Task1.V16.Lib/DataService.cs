using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task1.V16.Lib
{
    public class DataService : ISprint1Task1V16
    {
        public double Calculate(double x, double y, double a)
        {
            return x * 5 * y + 2 * a;
        }
    }
}
