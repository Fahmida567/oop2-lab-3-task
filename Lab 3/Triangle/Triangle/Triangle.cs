using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public void triangle(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public void display()
        {
           
            Console.Write("The Lengths Of Triangle are: ");
            Console.Write(" X = " + x);
            Console.Write(", Y = " + y);
            Console.WriteLine(", Z = " + z);
        }
        public void CheckTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The Triangle is equilateral(3 equal sides)");
                Console.WriteLine();
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine("The Triangle is isosceles(2 equal sides)");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The Triangle is scalene(no equal sides)");
                Console.WriteLine();
            }
        }
    }
}
