using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaAA.Sprint2.TaskReview.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x <= 0 && x >= -1 && y >= 0 && y <= 1) || (((Math.Pow(x, 2) + Math.Pow(y, 2) >= 0.3) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)) && (x >= 0 && x <= 1 && y >= 0 && y <= 1) || x > 0.3 || y > 0.3))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
