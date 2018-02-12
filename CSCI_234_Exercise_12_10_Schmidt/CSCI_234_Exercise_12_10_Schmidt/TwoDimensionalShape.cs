using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_234_Exercise_12_10_Schmidt
{
    public abstract class TwoDimensionalShape : Shape
    {
        public abstract double Area();
    }

    public class Circle : TwoDimensionalShape
    {
        private double m_Radius;

        public Circle (double radius)
        {
            m_Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(m_Radius, 2);
        }

        public override string ToString()
        {
            return string.Format("I am a circle with a radius of {0}.", m_Radius);
        }
    }

    public class Square : TwoDimensionalShape
    {
        private double m_Edge;

        public Square (double edge)
        {
            m_Edge = edge;
        }


        public override double Area()
        {
            return Math.Pow(m_Edge, 2);
        }

        public override string ToString()
        {
            return string.Format("I am a square with an edge of {0}.", m_Edge);
        }
    }

}
