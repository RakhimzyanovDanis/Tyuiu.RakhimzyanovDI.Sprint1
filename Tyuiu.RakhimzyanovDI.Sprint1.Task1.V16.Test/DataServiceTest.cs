using Tyuiu.RakhimzyanovDI.Sprint1.Task1.V16.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            double a = 1.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(22, res);
        }
    }
}
