using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PopkovSV.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                return Math.Round(x + Math.Pow((x + 1) / (x - 1), x), 3);
            }
            else if (x == 0)
            {
                return Math.Round(1 + (Math.Cos(Math.Sqrt(x + 1))), 3);
            }
            else if ((x > -16) && (x < 2))
            {
                return Math.Round(Math.Pow(7 + (5 / (Math.Pow(x, 2))), x), 3);
            }
            else if (x < -16)
            {
                return Math.Round(x + 10 * x - (1 / x), 3);
            }
                return x;
        }
    }
}
