using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PopkovSV.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 500 > b) | (c < b);
            res[1] = (a > b) & (c < b);
            res[2] = (a + 500 > b) || (c < b);
            res[3] = (a > b) && (c < b);
            res[4] = (!res[1]);
            res[5] = (a + 500 > b) ^ (c < b + 100);

            return res;
        }
    }
}
