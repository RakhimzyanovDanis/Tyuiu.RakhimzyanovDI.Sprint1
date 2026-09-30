using Tyuiu.RakhimzyanovDI.Sprint1.Task6.V18.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string value = "122";

            bool result = ds.CheckNumber(value);

            Assert.AreEqual(true, result);
        }
    }
}
