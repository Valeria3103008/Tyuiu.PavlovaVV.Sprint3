﻿using Tyuiu.PavlovaVV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            var res = ds.GetSumSeries(value, startValue, stopValue);
            var wait = 0.69;

            Assert.AreEqual(wait, res);
        }
    }
}
