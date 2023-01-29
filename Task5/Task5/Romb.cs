using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Romb:Dordbucaqlilar
    {

       
        protected double angle;
        /// <summary>
        /// rombun sahesi
        /// </summary>
        /// <param name="side">teref</param>
        /// <param name="angle">bucagin derecesi</param>
        public Romb(double side,double angle)
            :base(side,side,side,side)
        {
            
            this.angle= angle;
        }
        /// <summary>
        /// rombun sahesi
        /// </summary>
        /// <returns>saheni qaytarir</returns>
        public override double area()
        {
            double pi = Math.PI;
            double piRounded = Math.Round(pi, 2);
            double rad = angle * piRounded / 180;
            double sin = Math.Round(Math.Sin(rad),2);
            return sin * a * a;
        }
    }
}
