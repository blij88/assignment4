using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.classes
{
    class Circle: Shape
    {
        public int Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
