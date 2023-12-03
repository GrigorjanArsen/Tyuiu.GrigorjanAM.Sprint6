using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GrigorjanAM.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;

            for (int i = 0; i < col; i++)
            {
                if (matrix[1, i] % 2 == 0)
                {
                    matrix[1, i] = 0;
                }
            }
            return matrix;

        }
    }
}
