using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GrigorjanAM.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
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

                f = Math.Round(Math.Sin((double)x) + (2.0 * (double)x / 3.0) - Math.Cos((double)x) * (4.0 * (double)x), 2);
                valueArray[count] = f;
                count++;

            }
            return valueArray;
        }
    }
}
