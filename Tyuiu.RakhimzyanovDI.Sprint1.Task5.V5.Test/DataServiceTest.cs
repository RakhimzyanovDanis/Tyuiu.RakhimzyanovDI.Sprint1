using Tyuiu.RakhimzyanovDI.Sprint1.Task5.V5.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService service = new DataService();

            int result = service.Calculate(32.597);

            Assert.AreEqual(5, result);
        }
    }
}
