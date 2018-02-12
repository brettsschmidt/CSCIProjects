/*************************************************************************/
/* Program Name:     TestP.cs                                            */
/* Date:             04/20/2017                                          */
/* Programmer:       Brett Schmidt, Austin Sirowatka, Maribel Soriano    */
/* Class:            CSCI 231                                            */
/*                                                                       */
/* Program Description:  Product Inquiry program that brings up a list   */
/*                       of products based on user input. The prodcut    */
/*                       list includes information on each product that  */
/*                       relates to what the user input. The user is     */
/*                       to look between pages at different products.    */
/*                                                                       */
/* Input:	Product # or name input by the user.                         */
/*                                                                       */
/* Output:	Products related to name or product #                        */
/*                                                                       */
/* Givens:	KeyUtil.cs, Products.txt                                     */
/*                                                                       */
/*                                                                       */
/* Testing Data: 1, 123456, apple, ice, mac                              */
/*                                                                       */
/*                                                                       */
/*************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test
{
    class TestP
    {
        static void Main(string[] args)
        {
            try
            {
                int exit = 2;
                while (exit == 2)
                {
                    FileDb(Query());
                    exit = Exiter();
                }
            
            }
            catch (Exception E)
            {

                Console.WriteLine("\nCan't open Products.txt");
                Console.WriteLine("\nC:\\Teach\\Fall11\\CISP233\\Project>");
                Console.ReadKey();
            }

        }


        // Displays header.
        public static void Header()
        {
            Console.Write(" " + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year);
            string s = "<<<Product Inquery>>>";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.Write(s);
            Console.WriteLine('\n');

        }

        // Parses query into correct direction
        public static string Query()
        {
            ClearScreen();
            Header();

            string query = "";
            int count;
            int counter = 0;

            Console.Write("Product #: ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                                              ");
            Console.ResetColor();
            Console.WriteLine('\n');
            Console.WriteLine("Type a Product # or any parts of the Product Description separated by spaces.");
            Console.SetCursorPosition(11, 2);
            Console.BackgroundColor = ConsoleColor.White;
            query = Console.ReadLine();
            int.TryParse(query, out count);
            while(count > 99999)
            {
                WrongInput(count, query);
                ClearScreen();
                Header();
                Console.Write("Product #: ");

                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("                                                              ");
                Console.ResetColor();
                Console.WriteLine('\n');
                Console.WriteLine("Type a Product # or any parts of the Product Description separated by spaces.");
                Console.SetCursorPosition(11, 2);
                Console.BackgroundColor = ConsoleColor.White;
                query = Console.ReadLine();
                int.TryParse(query, out count);

            }
            if (count != 0)
            {
                for (int coun = 0; coun <= 5; coun++)
                {

                    if (count > 0)
                    {
                        counter++;
                    }
                    count = count / 10;

                }
                counter = 5 - counter;
                string zeros;
                switch (counter)
                {
                    case 1:
                        zeros = "0";
                        break;
                    case 2:
                        zeros = "00";
                        break;
                    case 3:
                        zeros = "000";
                        break;
                    case 4:
                        zeros = "0000";
                        break;
                    default:
                        zeros = "";
                        break;
                }
                query = zeros + query;
            }
            
            else
            {
                char delimiterChar = ' ';
                string[] queries = query.Split(delimiterChar);
                if (queries.Length != 1)
                {
                    query = FileDbParse(queries, query);
                }
                else
                {
                    query = FileDbParse(query);
                }
            }


            Console.ResetColor();
            Console.WriteLine('\n');
            return query;
        }

        // Displays full product information
        public static void FileDb(string query)
        {
            ClearScreen();
            Header();

            int counter = 0;
            string line;

            //Hard code StreamReader
            //System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\brett\\Downloads\\Project\\Project\\Products.txt");
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);
            System.IO.StreamReader file = new System.IO.StreamReader(folderPath + "\\Products.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(query))
                {
                    Product2 u = new Product2();
                    u.setString(line);
                    u.toString();
                }
                counter++;
            }
            file.Close();
        }
        
        // Takes in array of queries and parses them through.
        public static string FileDbParse(string[] queries, string queri)
       {
            string query;
            string line;
            int counter = 0;
            int rows;
            
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);

            System.IO.StreamReader file = new System.IO.StreamReader(folderPath + "\\Products.txt");
            while ((line = file.ReadLine()) != null)
            {
                int checker = 0;
                foreach (string s in queries)
                {
                    if (line.ToLower().Contains(s.ToLower()))
                    {
                        checker++;
                    }
                }
                if (checker == queries.Length)
                {
                    
                    counter++;
                    
                }
            }
            file.Close();
            rows = counter / 17;
            if(rows == 0)
            {
                rows = 1;
            }
            else
            {
                rows += 2;
            }
            Product2[,] products = new Product2[rows, 17];
            counter = 0;
            rows = 0;
            
            

            file = new System.IO.StreamReader(folderPath + "\\Products.txt");
            while ((line = file.ReadLine()) != null)
            {
                int checker = 0;
                foreach (string s in queries)
                { 
                    if (line.ToLower().Contains(s.ToLower()))
                    {
                        checker++;
                    }
                }
                if(checker == queries.Length)
                {
                    products[rows, counter] = new Product2();
                    products[rows, counter].setString(line);
                    counter++;
                    if (counter == 17)
                    {
                        counter = 0;
                        rows++;
                    }
                }
            }
            file.Close();
           
            query = QuerySelection(products, queri);
            return query;
        }

        // Takes int, int, rectangle array of Product2 instances, and a string to display the screen and user's selection.
        public static void QueryDisplay(Product2[,] products, int row, int column, string query)
        {
            ClearScreen();
            Header();
            Console.Write("Product #: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(query);
            Console.ResetColor();
            Console.WriteLine("                            Page {0} out of {1}", (row + 1), products.GetLength(0));

            for (int i = 0; i < 17; i++)
            {
                if (i == column)
                {
                    try
                    {
                        products[row, i].WhiteQuerytoString();
                    }
                    catch (Exception E)
                    {

                    }
                }
                else
                {
                    try { 
                        products[row, i].QuerytoString();
                    }
                    catch(Exception E)
                    {

                    }
                }
            }

            Console.WriteLine("Press U to go up a line, D down a line, P for previous page, N for next page");
            Console.WriteLine("<Enter> to accept a line, Q to quit.");
        }

        // Takes string to allow selection UI.
        public static string FileDbParse(string query)
        {
            query = query.ToLower();
            string itemNumber = "";
            string line;
            int counter = 0;
            int rows;
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);

            
            using (StreamReader file = new StreamReader(folderPath + "\\Products.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                   
                    if (line.ToLower().Contains(query))
                    {
                        counter++;
                    }
                }
            }
                //file.Close();
                rows = counter / 17;
                if (rows == 0)
                {
                    rows = 1;
                }
                else
                {
                rows += 2;
                }
            
           

                Product2[,] products = new Product2[rows, 17];
                counter = 0;
                rows = 0;


            //TODO: Fix this
            using (StreamReader file = new StreamReader(folderPath + "\\Products.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    
                    if (line.ToLower().Contains(query))
                    {
                        products[rows, counter] = new Product2();
                        products[rows, counter].setString(line);
                        counter++;
                        if (counter == 16)
                        {
                            counter = 0;
                            rows++;
                        }
                    }
                }
            }
                
           
            itemNumber = QuerySelection(products, query);
            return itemNumber;
        }

        // Takes in read input to choose/display row and column.
        public static string QuerySelection(Product2[,] products, string query)
        {
            char selection = 'O';
            int rows = 0;
            int counter = 0;
            while (selection != 'E')
            {
                
                QueryDisplay(products, rows, counter, query);
                
                selection = KeyUtil.GetKey();
                selection = UpperCaseChar(selection);

                switch (selection)
                {
                    case 'E':
                        break;
                    case 'U':
                        if (counter != 0 && products[rows, counter] != null)
                        {
                            counter--;
                            QueryDisplay(products, rows, counter, query);
                        };
                        break;
                    case 'D':
                        counter++;
                        try
                        {
                            products[rows, counter].Test();
                            QueryDisplay(products, rows, counter, query);
                        }
                        catch (Exception E)
                        {
                            counter--;
                        }
                        break;
                    case 'P':
                        if (rows != 0)
                        {
                            rows--;
                            counter = 0;
                            QueryDisplay(products, rows, counter, query);
                        };
                        break;
                    case 'N':
                        rows++;
                        try
                        {
                            products[rows, counter].Test();
                            counter = 0;
                            QueryDisplay(products, rows, counter, query);
                        }
                        catch(Exception E)
                        {
                            rows--;
                        }   
                        break;
                    case 'Q':
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }

            return products[rows, counter].getItemNo();
        }

        // Provides the decision to exit program after query completes.
        public static int Exiter()
        {
            int decision;

            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine(" 1 Exit Program  2 New Program");
            int.TryParse(Console.ReadLine(), out decision);

            return decision;
        }
       
        // Displays in case the too many digits for a number search happens.
        public static void WrongInput(int count, string query)
        {
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine("Product # too long. Press any key to continue:");
            Console.ReadKey();
            
        }

        public static void ClearScreen()
        {
            Console.ResetColor();
            Console.Clear();
            
        }

        // When too many words are parsed.
        public static void WrongInput(int count)
        {
            ClearScreen();
            Header();
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine("Too many words, press any key to continue");
        }

        // When a product isn't found.
        public static void WrongInput(string count)
        {
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine('n');
            Console.WriteLine("Product not found.");
        }

        // Turns the key selection into upper case.
        public static char UpperCaseChar(char selection)
        {
            switch (selection)
            {
                case 'e':
                    selection = 'E';
                    break;

                case 'q':
                    selection = 'Q';
                    break;

                case 'n':
                    selection = 'N';
                    break;

                case 'p':
                    selection = 'P';
                    break;

                case 'r':
                    selection = 'R';
                    break;

                case 'l':
                    selection = 'L';
                    break;

                case 'd':
                    selection = 'D';
                    break;

                case 'u':
                    selection = 'U';
                    break;
            }


            return selection;
        }

    }
}
