using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            t1.triangle(8, 9, 10);
            t1.display();
            t1.CheckTriangle();
        }
    }
}
