using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class A
    {

    }
    class B
    {
        Object first, second;
        public B(Object first, Object second)
        {
            this.first = first;
            this.second = second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            B b1 = new B(new A(), new A());
            B b2 = new B(b1, new A());
        }
    }
}
