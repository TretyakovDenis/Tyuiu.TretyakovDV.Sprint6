using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TretyakovDV.Sprint6.Task7.V29.Lib
{
    public class DataService : ISprint6Task7V29
    {


        public int[,] GetMatrix(int[,] matrix)
        {

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int c = 0; c < columns; c++)
            {
                if (matrix[5, c] >= -5 && matrix[5, c] <= 10)
                {
                    matrix[5, c] = 99;
                }
            }
            return matrix;
        }

        public int[,] GetMatrix(string path)
        {
            throw new NotImplementedException();
        }
    }
}