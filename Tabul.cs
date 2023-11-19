using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecursionIter
{
    internal class Tabul
    {
        public List<Point> Res = new List<Point> ();
        public void AddPoint(Point point)
        {
            Res.Add(point);
        }

        public void GetList(double a, double b, double c)
        {
            try
            {
                var x = a;
                while (x < b)
                {
                    var cos = new Cosinus(x);
                    AddPoint(new Point(Math.Round(x, 3), Math.Round(Math.Cos(x), 3), Math.Round(cos.Iterative(), 3), Math.Round(cos.Recursion(), 3)));
                    x += c;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentOutOfRangeException("Invalid enter data",ex);
            }
        }

    }

}
