using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov
{
    class QuadraticEquation : LinearEquation
    {
        protected double discriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        public List<double> resolution(double a, double b, double c)
        {
            if (a == 0)
                return linearEquation(b, c);
            double d = this.discriminant(a, b, c);
            if (d == 0)
            {
                Roots.Add((-b + Math.Sqrt(d)) / 2 * a);
            }
            else if (d > 0)
            {
                Roots.Add((-b + Math.Sqrt(d)) / 2 * a);
                Roots.Add((-b - Math.Sqrt(d)) / 2 * a);
            }
            else
                throw new GachiExсeption("Нет корней");
            MyLog.log("Введено квадратное уравнение");
            return roots;
        }
    }
}
