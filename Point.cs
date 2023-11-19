using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIter
{
    public class Point
    {
        private double x, math, iter, rec;
        public Point(double x, double mathematics, double iteration, double recursive)
        {
            this.x = x;
            math = mathematics;
            iter = iteration;
            rec = recursive;
        }
        public double X
        {
            get => x;
            set => x = value;
        }
        public double Math
        {
            get => math;
            set => math = value;
        }
        public double Iter
        {
            get => iter;
            set => iter = value;
        }
        public double Rec
        {
            get => rec;
            set => rec = value;
        }
    }
}
