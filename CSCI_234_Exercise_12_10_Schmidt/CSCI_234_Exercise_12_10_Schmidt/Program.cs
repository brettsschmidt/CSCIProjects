using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_234_Exercise_12_10_Schmidt
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Square(6), new Cube(3), new Sphere(8), new Circle(2), new Sphere(7) };

            foreach(Shape cur in shapes)
            {
                Console.WriteLine(cur.ToString());
                try
                {
                    ThreeDimensionalShape curShape = (ThreeDimensionalShape)cur;
                    Console.WriteLine("Area = " + curShape.Area());
                    Console.WriteLine("Volume = " + curShape.Volume());
                }
                catch(Exception e)
                {

                }
                try
                {
                    TwoDimensionalShape curShape = (TwoDimensionalShape)cur;
                    Console.WriteLine("Area = " + curShape.Area()); 
                }
                catch(Exception e)
                {

                }
            }

            Console.ReadKey();

        }
    }
}
