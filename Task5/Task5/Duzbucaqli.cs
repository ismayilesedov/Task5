using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Duzbucaqli : Dordbucaqlilar
    {
        /// <summary>
        /// duzbucaqlinin sahesi
        /// </summary>
        /// <param name="a">teref a</param>
        /// <param name="b">teref b</param>
        public Duzbucaqli(double a,double b)
            :base(a,b,a,b)
        {
            
        }
        /// <summary>
        /// duzbucaqlinin sahesi
        /// </summary>
        /// <returns>duzbucaqlinin sahesini qaytarir</returns>
        public override double area()
        {
            double area = a * b;
            return area;
        }
    }
}
