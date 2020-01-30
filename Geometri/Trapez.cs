using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Trapez : Square
    {
        double b, c, d;

        public Trapez(double side, double b, double c, double d) : base(side)
        {
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double Areal()
        {
            double s = (Side + b - c + d) / 2;
            double h = 2 / (Side - c) * Math.Sqrt(s * (s - Side + c) * (s - b) * (s - b));
            double areal = 0.5 * (Side + c) * h;
            return areal;
        }
    }
}
