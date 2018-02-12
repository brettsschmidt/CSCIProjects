using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_10_3_Schmidt
{
    class RectangleTest
    {
        public class Rectangle
        {
            private decimal m_Length;
            private decimal m_Width;

            public Rectangle()
            {
                m_Length = 1m;
                m_Width = 1m;
            }

            public void setLength(decimal length)
            {
                if (0m < length && length < 20m)
                {
                    m_Length = length;
                }
            }

            public void setWidth(decimal width)
            {
                if (0m < width && width < 20)
                {
                    m_Width = width;
                }
            }

            public void setDimensions(decimal length, decimal width)
            {
                if (0 < length && length < 20 && 0 < width && width < 20)
                {
                    m_Width = width;
                    m_Length = length;
                }
            }

            public decimal getLength()
            {
                return m_Length;
            }
            public decimal getWidth()
            {
                return m_Width;
            }
            public decimal getArea()
            {
                return m_Width * m_Length;
            }
            public decimal getPerimeter()
            {
                return (m_Width * 2) + (m_Length * 2);
            }

            public void writeDimensions()
            {
                Console.WriteLine("Current length: " + this.getLength());
                Console.WriteLine("Current width: " + this.getWidth());
                Console.WriteLine("Current area: " + this.getArea());
                Console.WriteLine("Current perimeter: " + this.getPerimeter());
            }

        }


        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();

            Console.WriteLine("Welcome to the rectangle class tester!");
            myRectangle.writeDimensions();
            Console.WriteLine("myRectangle initialized. Press any key to begin testing: ");
            Console.ReadKey();

            char m_readKey = 'x';

            

            while(m_readKey == 'x')
            {
                Console.Clear();
                Console.WriteLine("Enter new length: ");
                try
                {
                    myRectangle.setLength(Convert.ToDecimal(Console.ReadLine()));
                }
                catch(Exception e)
                {
                    
                }
                Console.WriteLine("Enter new width: ");
                try
                {
                    myRectangle.setWidth(Convert.ToDecimal(Console.ReadLine()));
                }
                catch(Exception e)
                {

                }
                myRectangle.writeDimensions();
                Console.WriteLine("Press x to continue testing or any other key to exit: ");
                try
                {
                    m_readKey = Console.ReadKey().KeyChar;
                }
                catch(Exception e)
                {
                    m_readKey = 'b';
                }
            }



        }
    }
}
