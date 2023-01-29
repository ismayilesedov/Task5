using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Trapesiya:Dordbucaqlilar
    {
        private double h;
        /// <summary>
        /// trapesiyanin sahesi
        /// </summary>
        /// <param name="ust">ust oturacaq</param>
        /// <param name="alt">alt oturacaq</param>
        /// <param name="yan">yan teref</param>
        /// <param name="h">hundurluk</param>
        public Trapesiya(double ust,double alt,double yan ,double h)
            :base(ust,yan,alt,yan)
        {
            this.h = h;
        }
        /// <summary>
        /// saheni tapir
        /// </summary>
        /// <returns>saheni qaytarir</returns>
        public override double area()
        {
            return h * (a + c) / 2;
        }
    }
}
