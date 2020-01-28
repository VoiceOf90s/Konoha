using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class GachiExсeption : Exception { public GachiExсeption(string a) : base(a) { } }
    class A
    {
        public double linearEquation(double a, double b)
        {
            if (a != 0)
                return -b / a;

            throw new GachiExсeption("Нет корней");
        }
    }
    class B : A
    {
        public B() { }
        protected double discriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        public List<double> quadraticEquation(double a, double b, double c)
        {
            List<double> roots = new List<double>();
            if (a == 0)
            {
                roots.Add(linearEquation(b, c));
                return roots;
            }
            else
            {
                double D = discriminant(a, b, c);
                if (D < 0)
                    throw new GachiExсeption("Дискриминант меньше нуля");
                else
                {
                    roots.Add((-b + Math.Sqrt(D)) / (2 * a));
                    roots.Add((-b - Math.Sqrt(D)) / (2 * a));
                    return roots;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<double> roots;
            double a = 0, b = 0, c = 0;
            B classB = new B();
            try
            {
                roots = classB.quadraticEquation(a, b, c);
                foreach (double temp in roots)
                    Console.WriteLine(temp);
            }
            catch (GachiExсeption e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
