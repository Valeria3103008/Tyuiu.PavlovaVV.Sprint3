using Tyuiu.PavlovaVV.Sprint3.Task0.V24.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
