using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square : Geometri
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double  Omkreds()
        {
            double math = 4 * Side;
            return math;
        }

        public override double Areal()
        {
            double math = Side * Side;
            return math;
        }
    }
}
