using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI231_Project_Schmidt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year);
            string s = "<<<Product Inquery>>>";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write(s);
            Console.WriteLine(' ');

            ProductDB DB = new ProductDB();
            DB.dataBase();

            DB.Products[2].toString();

            //Product test = new Product();
            //test.setString("00086Freight - Full Load             0.00                                      0.00                                      0.00                  A198.00                0.00                  0.00                  ");
            //test.toString();

            

            int number;
            int.TryParse(Console.ReadLine(), out number);

            string query = String.Format("{0:D5}", number);

            string text = System.IO.File.ReadAllText(@"C:\Users\brett\Downloads\Project\Project\Products.txt");
            Product yo = new Product();
            yo.setString(text.Substring(0, 210));
            yo.toString();
            Console.Write(text.Length);

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\brett\Downloads\Project\Project\Products.txt");
            //Product[] products = new Product[lines.Length];
            //int p = 0;
            //foreach (string line in lines)
            // {
            //   products[p].setTest(line);
            // p++;
            //}
            //Console.Write(products[1].getTest());


            //for(int i = 1; i < lines.Length; i++)
            //{
            //if(lines[i] != null && lines[i].Contains(query))
            // {
            //       products[i].setString(lines[i]);
            // }
            // }
            //for(int i = 0; i < lines.Length; i++)
            //{
            // if(products[i] != null)
            // {
            //    products[i].toString();
            // }
            //  }
            //Console.Write(query);
            Console.ReadLine();

        }
    }
}
