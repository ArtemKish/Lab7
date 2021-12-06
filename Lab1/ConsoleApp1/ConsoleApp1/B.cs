using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class B:A
    {
        protected double getDis(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }

        protected double[] Solvex2(int a, int b, int c)
        {
            if (a == 0)
            {
                return Solvex1(b, c);
            }

            double D = getDis(a, b, c);

            if (D == 0)
            {
                return x = new double[] { -b / (2 * a) };
            }

            if (D > 0)
            {
                D = Math.Sqrt(D);
                return x = new double[] {
                    (-b + D) / (2 * a),
                    (-b - D) / (2 * a)
                };
            }

            throw new Exception("Корней нет");

        }
    }
}
