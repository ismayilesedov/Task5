using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Kvadrat:Romb
        
    {
        public Kvadrat(double a)
            :base(a,90)
        {

        }
        public override double area()
        {
            return a * a; 
        }
    }
}
