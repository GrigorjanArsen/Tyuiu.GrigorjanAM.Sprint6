using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GrigorjanAM.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double f;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((double)x + 1.2 != 0)
                {
                    f = Math.Round(Math.Sin((double)x) / ((double)x + 1.2) + Math.Cos((double)x) * 7 * (double)x - 2,2);
                    valueArray[count] = f;
                    count++;
                }
                else
                {
                    f = 0;
                    valueArray[count] = f;
                    count++;
                }
            }
            return valueArray;

        }
    }
}
