using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            number = Math.Abs(number);

            double fractionalPart = number - Math.Truncate(number);

            int firstThreeDigits =
                (int)(fractionalPart * 1000 + 0.000001);

            int firstDigit = firstThreeDigits / 100;
            int secondDigit = firstThreeDigits / 10 % 10;
            int thirdDigit = firstThreeDigits % 10;

            return firstDigit == 0 ||
                   secondDigit == 0 ||
                   thirdDigit == 0;
        }
    }
}
