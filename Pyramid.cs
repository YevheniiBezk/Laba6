using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Pyramid : Solid
    {
        public double A { get; set; }  
        public double H { get; set; }  

        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }

        public override double GetVolume()
        {
            return (1.0 / 3.0) * Math.Pow(A, 2) * H;
        }
    }
}

