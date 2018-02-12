using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_4_14_Schmidt
{
    class DateTest
    {

        public class Date
        {
            private int m_Month;
            private int m_Day;
            private int m_Year;

            public Date()
            {
                m_Month = DateTime.Now.Month;
                m_Day = DateTime.Now.Day;
                m_Year = DateTime.Now.Year;
            }
            
            public string getDate()
            {
                return m_Month + "/" + m_Day + "/" + m_Year;
            }

            public void DisplayDate()
            {
                Console.WriteLine(this.getDate());
            }


        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please press any key to see today's date: ");
            Console.ReadKey();
            Console.Clear();

            Date dateNow = new Date();
            Console.WriteLine("The current date is: ");
            dateNow.DisplayDate();
            Console.ReadKey();


        }
    }
}
