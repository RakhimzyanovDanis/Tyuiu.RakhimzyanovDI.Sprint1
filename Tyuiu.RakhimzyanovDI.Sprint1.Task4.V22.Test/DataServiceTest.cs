using Tyuiu.RakhimzyanovDI.Sprint1.Task4.V22.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.054, res);
        }
    }
}
