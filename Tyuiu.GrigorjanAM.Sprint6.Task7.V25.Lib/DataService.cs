using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;
            int xcol = 7;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, xcol] % 5 == 0 /*&& matrix[i,xcol] != 0*/)
                {
                    matrix[i, xcol] = 2;
                }
                
            }
            return matrix;

        }
    }
}
