using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_234_Exercise_12_10_Schmidt
{
    public abstract class ThreeDimensionalShape : Shape
    {
        public abstract double Area();
        public abstract double Volume();
    }

    public class Sphere : ThreeDimensionalShape
    {
        private double m_Radius;

        public Sphere(double radius)
        {
            m_Radius = radius;
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(m_Radius, 2);
        }

        public override string ToString()
        {
            return string.Format("I am a sphere with a radius of {0}.", m_Radius);
        }

        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(m_Radius, 3);
        }
    }

    public class Cube : ThreeDimensionalShape
    {
        private double m_Edge;

        public Cube (double edge)
        {
            m_Edge = edge;
        }

        public override double Area()
        {
            return 6 * Math.Pow(m_Edge, 2);
        }

        public override double Volume()
        {
            return Math.Pow(m_Edge, 3);
        }

        public override string ToString()
        {
            return string.Format("I am a cube with an edge of {0}.", m_Edge);
        }
    }
}
