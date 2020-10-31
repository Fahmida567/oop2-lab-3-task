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

        public Triangle(int x , int y, int z)
        {
            this.x= x;
            this.y= y;
            this.z = z;
           
        }
       
        
          public  void checkTriangle(int x, int y, int z)
            {

                // Check for equilateral triangle 
                if (x == y && y == z)
                    Console.WriteLine( "Equilateral Triangle");

                // Check for isoceles triangle 
                else if (x == y || y == z || z == x)
                   Console.WriteLine( "Isoceles Triangle");

                // Otherwise scalene triangle 
                else
                  Console.WriteLine("Scalene Triangle");
            }
           internal void ShowInfo()
        { 

            Console.WriteLine(+ x);
            Console.WriteLine(+ y);
            Console.WriteLine( + z);
           
        }
    }
}