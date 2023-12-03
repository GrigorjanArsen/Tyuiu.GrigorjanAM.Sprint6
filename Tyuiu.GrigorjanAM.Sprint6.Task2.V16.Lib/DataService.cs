using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrigorjanAM.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
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

                f = Math.Round(Math.Cos((double)x) / ((double)x - 0.4) + (Math.Sin((double)x) * (8 * (double)x)) + 2,2);
                valueArray[count] = f;
                count++;

            }
            return valueArray;
        }
    }
}
