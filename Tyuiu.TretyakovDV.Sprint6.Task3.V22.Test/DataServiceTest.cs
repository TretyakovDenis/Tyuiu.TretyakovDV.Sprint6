using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint6.Task3.V22.Lib;
namespace Tyuiu.TretyakovDV.Sprint6.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 17, 0, 19, -8, -1 },
                                           { 9, 4, -5, 7, 15 },
                                           { 11, 13, 4, -4, -14 },
                                           { 11, 14, 5, -15, 16 },
                                           { 2, -14, -2, 11, 11 } };

            int[,] resMatrix = ds.Calculate(matrix);
            int res = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (resMatrix[i, j] == 0)
                    {
                        res++;
                    }
                }
            }
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}