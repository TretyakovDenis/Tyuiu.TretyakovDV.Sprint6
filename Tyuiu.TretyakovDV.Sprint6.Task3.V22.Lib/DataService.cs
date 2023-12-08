using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.TretyakovDV.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            return matrix;
        }

    }
}