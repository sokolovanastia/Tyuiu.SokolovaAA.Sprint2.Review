using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint2.TaskReview.V4.Lib;
namespace Tyuiu.SokolovaAA.Sprint2.TaskReview.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            if (res == true)
                Console.WriteLine("Точка лежит заштрихованной области");
            else
                Console.WriteLine("Точка не лежит заштрихованной области");
            Console.ReadKey();

        }
    }
}
