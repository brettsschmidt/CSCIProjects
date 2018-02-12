using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_20_10_Schmidt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is a string equal to an int?");
            Console.WriteLine(IsEqualTo("a string", 3));
            Console.WriteLine("Is a double of equal size equal to an int of same size?");
            Console.WriteLine(IsEqualTo(2D, 2));
            Console.WriteLine("Is a double equal to a decimal if they are the same?");
            Console.WriteLine(IsEqualTo(4D, 4M));
            Console.WriteLine("Are two ints equal to eachother if they are the same size?");
            Console.WriteLine(IsEqualTo(2, 2));
            Console.WriteLine("What if they are different sizes?");
            Console.WriteLine(IsEqualTo(2, 3));
            Console.ReadKey();


        }

        static bool IsEqualTo(object object1, object object2)
        {
            if(object1.Equals(object2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
