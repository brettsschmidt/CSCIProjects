using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV_of_an_Annuity
{
    class AnnuityCreator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your sinking fund calculator!");
            Console.WriteLine("Please enter the future value you need to save for: ");
            double FV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the rates per period: ");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of payments: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your payments are: " + periodicPaymentCalculator(FV, i, n));
            Console.ReadLine();


        }

        static double periodicPaymentCalculator(double FV, double i, double n)
        {
            double m_PMT = Math.Pow(i + 1, n) - 1;

            m_PMT =  i / m_PMT;

            m_PMT = m_PMT * FV;

            return m_PMT;
            

        }

    }
}
