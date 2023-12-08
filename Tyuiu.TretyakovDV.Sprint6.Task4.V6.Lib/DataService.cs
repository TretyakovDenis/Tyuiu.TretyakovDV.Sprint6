﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.TretyakovDV.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {


                y = Math.Round((3*Math.Cos(x))/(4*x-0.5)+Math.Sin(x)-5*x-2, 2);
                if (4*x-0.5 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;
        }
    }
}