using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov
{
    class LinearEquation
    {
        protected List<double> roots = new List<double>();
        public List<double> Roots
        {
            get { return roots; }
            set { roots = value; }
        }
        public List<double> linearEquation(double a, double b)
        {
            if (a == 0)
            {
                throw new GachiExсeption("Вашего уравнения не существует");
            }
            Roots.Add((double)-b / a);
            MyLog.log("Введено линейное уравнение");
            return roots;
        }
    }
}
