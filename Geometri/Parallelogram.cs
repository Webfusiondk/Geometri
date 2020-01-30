using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Parallelogram : Square
    {
        public double B { get; set; }
        public double Vinkel { get; set; }
        public Parallelogram(double side, double b, double vinkel) : base(side)
        {
            B = b;
            Vinkel = vinkel;
        }
        public override double Areal()
        {
            double realVinkel = (Vinkel * (Math.PI)) / 180;
            double areal = B * Convert.ToDouble(Side) * (Math.Sin(realVinkel));
            return areal;
        }
    }
}
