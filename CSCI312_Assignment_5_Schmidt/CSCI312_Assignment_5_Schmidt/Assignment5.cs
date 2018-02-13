using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Assignment_5_Schmidt
{
    class Assignment5
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            string userInput = "13";

            Console.WriteLine("Welcome to my calculator. Please enter input as number.decimal operator number.decimal: ");

            while(userInput != "EXIT")
                {
                userInput = Console.ReadLine();
                Console.WriteLine(myCalculator.newOperation(userInput));

                }

        }
    }
}
