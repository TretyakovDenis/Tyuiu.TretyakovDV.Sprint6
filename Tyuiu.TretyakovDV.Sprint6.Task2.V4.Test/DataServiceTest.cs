using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task2.V4.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 3.20;
            valueWaitArray[1] = 3.34;
            valueWaitArray[2] = 3.02;
            valueWaitArray[3] = 2.58;
            valueWaitArray[4] = 2.97;
            valueWaitArray[5] = 1.25;
            valueWaitArray[6] = 1.55;
            valueWaitArray[7] = 1.81;
            valueWaitArray[8] = 2.15;
            valueWaitArray[9] = 2.43;
            valueWaitArray[10] = 2.49;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}