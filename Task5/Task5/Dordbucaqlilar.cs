using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Dordbucaqlilar
    {
        protected  double a;
        protected  double b;
        protected  double c;
        protected  double d;
        public Dordbucaqlilar(double aSide,double bSide,double cSide,double dSide)
        {
            this.a = aSide;
            this.b = bSide;
            this.c = cSide;
            this.d = dSide;
          
        }
        public double perimetr()
        {
            return a + b + c + d;

        }
        public abstract double area();
        public override string ToString()
        {
            return @$"##{this.GetType().Name}##
          Perimeter:{this.perimetr()}
          Sahe :{this.area()}";
            



        }
    }
   
    
}
