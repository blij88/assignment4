using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.classes
{
    class Rectangle: Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area()
        {
            return this.Width * this.Height;
        }
    }
}
