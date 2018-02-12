using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI231_Project_Schmidt
{
    class Product
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

        public Product()
        {
            
        }

        public void setString(string line)
        {
            m_ITEM_NO = line.Substring(0, 5);
            m_DESCRIPTION = line.Substring(5, 30);
            m_UNIT_TYPE = line.Substring(35, 2);
            m_WEIGHT_OR_QTY = line.Substring(37, 23);
            m_BUYING_UNIT = line.Substring(60, 19);
            m_BUYING_WEIGHT = line.Substring(79, 22);
            m_SELLING_UNIT = line.Substring(101, 20);
            m_SELLING_WEIGHT = line.Substring(121, 22);
            m_ACTIVE_FLAG = line.Substring(143, 1);
            m_COST = line.Substring(144, 22);
            m_LIST_PRICE = line.Substring(166, 22);
            m_SUG_RET = line.Substring(188, 22);
            test = line;
        }
        

        public void toString()
        {
            Console.Write("Product # " );
            WriteWhite(m_ITEM_NO);
            Console.Write("\n");
            Console.Write(" Description " );
            WriteWhite(m_DESCRIPTION);
            Console.Write(" Unit Type " );
            WriteWhite(m_UNIT_TYPE);
            Console.Write(" Weight Or Qty " );
            WriteWhite(m_WEIGHT_OR_QTY);
            Console.Write(" Buying Unit " );
            WriteWhite(m_BUYING_UNIT);
            Console.Write(" Buying Weight " );
            WriteWhite(m_BUYING_WEIGHT);
            Console.Write(" Selling Unit " );
            WriteWhite(m_SELLING_UNIT);
            Console.Write(" Selling Weight " );
            WriteWhite(m_SELLING_WEIGHT);
            Console.Write(" Active Flag " );
            WriteWhite(m_ACTIVE_FLAG);
            Console.Write(" Cost " );
            WriteWhite(m_COST);
            Console.Write(" List Price " );
            WriteWhite(m_LIST_PRICE);
            Console.Write(" Sug Ret " );
            WriteWhite(m_SUG_RET);
        }

        static void WriteWhite(string value)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        public void setTest(string value)
        {
            if(value != null)
            test = value;
        }

        public string getTest()
        {
            return test;
        }

    }
}
