using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class ArithmeticProgression: Progression
    {
        public double A1 { get; private set; }
        public double D { get; private set; }
        public ArithmeticProgression(double a1, double d)
        {
            this.A1 = a1;
            this.D = d;
        }
        public override double GetElement(int k)
        {
            double e = A1 + D * (k - 1);
            return e;
        }
    }
}
