using assignment4.classes;
using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // circle
            Circle circle = new Circle() { X = 2, Y = 4, Radius = 3 };
            Console.WriteLine($"the area of the circle is {circle.Area():.##}");

            // rectangle
            Rectangle rectangle = new Rectangle() { X = 5, Y = 7, Height = 4, Width = 5 };
            Console.WriteLine($"the area of the rectangle is {rectangle.Area()}");

            // square
            Rectangle square = new Rectangle() { X = 5, Y = 7, Height = 6, Width = 6 };
            Console.WriteLine($"the area of the rectangle is {square.Area()}");


            Console.ReadLine();
        }
    }
}
