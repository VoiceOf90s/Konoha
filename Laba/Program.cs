using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = 0, b = 0, c = 0;
                Console.WriteLine("Введите параметры a, b, с");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                MyLog.log(a + "X^2+" + b + "X+" + c + "=0");
                QuadraticEquation qe = new QuadraticEquation();
                List<double> list = qe.resolution(a, b, c);
                String s = "Корни: ";
                foreach (double i in list)
                {
                    s += i + " ";
                }
                MyLog.log(s);
            }
            catch (GachiExсeption e)
            {
                MyLog.log(e.Message);
            }
            MyLog.write();
            Console.ReadKey();
        }
    }
}
