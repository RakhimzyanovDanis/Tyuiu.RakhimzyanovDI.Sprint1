using System.Windows.Markup;
using Tyuiu.RakhimzyanovDI.Sprint1.Task7.V30.Lib;


namespace Tyuiu.RakhimzyanovDI.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(12.283, z);
        }
    }
}
