using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Trekant : Geometri
    {
        double a, b, c;

        public Trekant(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Areal()
        {
            double areal = 0.5 * a * b;
            return areal;
        }
        public override double Omkreds()
        {
            double omkreds = a + b + c;
            return omkreds;
        }

    }
}
