using Tyuiu.PavlovaVV.Sprint3.Task4.V16.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = -5;
            int y = 5;

            Assert.AreEqual(ds.Calculate(x, y), 6.719);
        }
    }
}
