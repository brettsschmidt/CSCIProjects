using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test
{
    class Product2
    {
        private string m_ITEM_NO;
        private string m_DESCRIPTION;
        private string m_UNIT_TYPE;
        private string m_WEIGHT_OR_QTY;
        private string m_BUYING_UNIT;
        private string m_BUYING_WEIGHT;
        private string m_SELLING_UNIT;
        private string m_SELLING_WEIGHT;
        private string m_ACTIVE_FLAG;
        private string m_COST;
        private string m_LIST_PRICE;
        private string m_SUG_RET;

        private string test;

        public Product2()
        {

        }

        public void Test()
        {

        } 

        private string getRidofWhite(string line)
        {
            string word = "";
            int counter = 0;
            foreach (char chars in line)
            {
                if (Char.IsWhiteSpace(chars) == false)
                {
                    word += chars;
                    counter = 0;
                }
                else if (counter > 0 && char.IsWhiteSpace(chars))
                {

                }
                else
                {
                    word += chars;
                    counter++;
                }
            }
            return word;
        }

        public void setString(string line)
        {
            m_ITEM_NO = line.Substring(0, 5);

            m_DESCRIPTION = this.getRidofWhite(line.Substring(5, 30));

            m_UNIT_TYPE = line.Substring(35, 2);

            m_WEIGHT_OR_QTY = this.getRidofWhite(line.Substring(37, 23));

            m_BUYING_UNIT = this.getRidofWhite(line.Substring(60, 19));

            m_BUYING_WEIGHT = this.getRidofWhite(line.Substring(79, 22));

            m_SELLING_UNIT = this.getRidofWhite(line.Substring(101, 20));

            m_SELLING_WEIGHT = this.getRidofWhite(line.Substring(121, 22));

            m_ACTIVE_FLAG = line.Substring(143, 1);

            m_COST = this.getRidofWhite(line.Substring(144, 22));

            m_LIST_PRICE = this.getRidofWhite(line.Substring(166, 22));

            m_SUG_RET = this.getRidofWhite(line.Substring(188, 22));

            test = line;
        }


        public void toString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Product # ");
            WriteWhite(m_ITEM_NO);
            Console.Write("\n");
            Console.Write(" Description ");
            WriteWhite(m_DESCRIPTION);
            Console.Write(" Unit Type ");
            WriteWhite(m_UNIT_TYPE);
            Console.Write(" Weight Or Qty ");
            WriteWhite(m_WEIGHT_OR_QTY);
            Console.Write(" Buying Unit ");
            WriteWhite(m_BUYING_UNIT);
            Console.Write(" Buying Weight ");
            WriteWhite(m_BUYING_WEIGHT);
            Console.Write(" Selling Unit ");
            WriteWhite(m_SELLING_UNIT);
            Console.Write(" Selling Weight ");
            WriteWhite(m_SELLING_WEIGHT);
            Console.Write(" Active Flag ");
            WriteWhite(m_ACTIVE_FLAG);
            Console.Write(" Cost ");
            WriteWhite(m_COST);
            Console.Write(" List Price ");
            WriteWhite(m_LIST_PRICE);
            Console.Write(" Sug Ret ");
            WriteWhite(m_SUG_RET);
            Console.ResetColor();
        }

        public void QuerytoString()
        {
            string part;
            part = ("      " + m_ITEM_NO + " " + m_DESCRIPTION);
            Console.WriteLine(part);
        }

        public void WhiteQuerytoString()
        {
            string part;
            part = ("      " + m_ITEM_NO + " " + m_DESCRIPTION);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(part);
            Console.ResetColor();
        }

        static void WriteWhite(string value)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(value);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void setTest(string value)
        {
            if (value != null)
                test = value;
        }

        public string getItemNo()
        {
            string Item_No;
            Item_No = m_ITEM_NO;
            return Item_No;
        }

        public string getTest()
        {
            return test;
        }
    }
}
