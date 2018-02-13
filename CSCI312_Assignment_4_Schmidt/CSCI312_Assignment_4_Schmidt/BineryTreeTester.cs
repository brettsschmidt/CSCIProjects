using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Assignment_4_Schmidt
{
    class BineryTreeTester
    {


        static void Main(string[] args)
        {
            BinerySearchTree myTree = new BinerySearchTree();
            String testData = "DBFCAEG";
            int[] intTestData = { 38 , 72,  60,  98,  76,  16,  78,  26,  58,  31,  17,  61,  25,  63,  50,  18,  55,  92,  4,   21 };

            foreach (int data in intTestData)
            {
                myTree.addNode(data, data);
            }

            //foreach (char c in testData)
            //{
              //  myTree.addNode(getKeyForString(c), c);
            //}
            myTree.printInorder();
            Console.WriteLine();
            myTree.printPostOrder();
            Console.WriteLine();
            myTree.printPreorder();
            Console.WriteLine();

           // myTree.printInorderToString();
         //   Console.WriteLine();
         //   myTree.printPostOrderToString();
            Console.WriteLine();
            //    myTree.printPreorderToString();

            Console.WriteLine("Please enter character to be searched: ");
            myTree.findNode(getKeyForString(Console.ReadLine()));

            Console.WriteLine("The binery tree has a size of: " + myTree.getSize());
            Console.ReadLine();
            


        }
        
        private static int getKeyForString(string data)
        {
            return Convert.ToInt32(Convert.ToChar(data));

        }
        private static int getKeyForString(char data)
        {
            return Convert.ToInt32(data);

        }

    }
}
