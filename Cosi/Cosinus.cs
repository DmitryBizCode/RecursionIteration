using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosi
{
    public class Cosinus : Component
    {
        private readonly double min = 0.001;
        private readonly double x;
        private readonly double sqr;

        public Cosinus(double x)
        {
            this.x = x;
            sqr = x * x;
        }

        public double Iterative()
        {
            double sum = 1, curr = 1;
            int n = 1, mul = -1;
            while (Math.Abs(curr) > min)
            {
                curr *= sqr / (n * (n + 1));
                sum += mul * curr;
                mul = -mul;
                n += 2;
            }
            return sum;
        }

        public double Recursion()
        {
            return CosH(1, 1, 1);
        }

        private double CosH(double currTerm, int n, int mul)
        {
            if (Math.Abs(currTerm) < min)
                return 0;
            else
                return mul * currTerm + CosH(currTerm * x * x / (n * (n + 1)), n + 2, -mul);
        }
    }
}
