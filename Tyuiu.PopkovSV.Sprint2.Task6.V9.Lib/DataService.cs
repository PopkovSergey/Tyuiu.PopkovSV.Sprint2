using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PopkovSV.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int n, int m)
        {
            string res;
            bool flag = true;
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                    n += 1;
                    break;
                case 28:

                    switch (m)
                    {
                        case 2:
                            n = 1;
                            m = 3;
                            break;
                        default:
                            n += 1;
                            break;
                    }
                    break;
                case 29:
                case 30:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            n = 31;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 1;
                            m += 1;
                            break;
                        case 2:
                            flag = false;
                            Console.WriteLine("Введено неверное число: кол-во дней в данном месяце не > 28");
                            break;
                    }
                    break;
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            n = 1;
                            m += 1;
                            break;
                        case 12:
                            n = 1;
                            m = 1;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            flag = false;
                            Console.WriteLine("Введено неверное число: кол-во дней в данном месяце не > 30");
                            break;
                        case 2:
                            flag = false;
                            Console.WriteLine("Введено неверное число: кол-во дней в данном месяце не > 28");
                            break;

                    }
                    break;
                default:
                    flag = false;
                    Console.WriteLine("Введено неверное кол-во дней");
                    break;
            }

            if (flag == true)
            {
                res = ($"Дата следующего дня: {n}.{m}");
            }
            else
            {
                res = ("Введены неверные данные");
            }
            return res;
        }
    }
}