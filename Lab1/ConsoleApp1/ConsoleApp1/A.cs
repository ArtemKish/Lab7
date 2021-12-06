using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class A
    {
        protected double[] x;

        public double[] Solvex1(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Корней нет");
            }
            return x = new double[] { (-b/a) };
        }
    }
}
