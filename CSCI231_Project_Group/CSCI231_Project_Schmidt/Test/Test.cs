using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI231_Project_Schmidt.Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\brett\\Downloads\\Project\\Project\\Products.txt");
            while((line = file.ReadLine()) != null)
                {
                Console.WriteLine(line);
                counter++;
            }
            file.Close();
            Console.ReadLine();
        }

    }
}
