using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public Triangle()
        { }

        public override string ToString()
        {
            string bs = String.Format("\nДлины сторон треугольника:\n1 сторона - {0}" +
                "\n2 сторона - {1}\n3 сторона - {2}", A, B, C);
            return bs;
        }

        public void Print()
        {
            Console.WriteLine(this);
            if (this.Prov() == false)
                Console.WriteLine("\nТреугольника со сторонами {0}, " +
                    "{1}, {2} не существует", A, B, C);
        }

        public double Perimetr()
        {
            if (this.Prov() == false)
                return 0;
            else 
            {
                double P = A + B + C;
                return P;
            }
        }

        public double Square()
        {
            if (this.Prov() == false)
                return 0;
            else
            {
                double p = this.Perimetr();
                p /= 2;
                double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return s;
            }  
        }
        
        public bool Prov()
        {
            bool prov;
            if (A + B > C && A + C > B && B + C > A)
                prov = true;
            else
                prov = false;
            return prov;
        }
    }
}
