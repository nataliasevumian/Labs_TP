using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class GeometricProgression: Progression
    {
        public double B1 { get; private set; }
        public double Q { get; private set; }
        public GeometricProgression(double b1, double q)
        {
            this.B1 = b1;
            this.Q = q;
        }
        public override double GetElement(int k)
        {
            double e = B1 * Math.Pow(Q, k-1);
            return e;
        }
    }
}
