using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI231_Project_Schmidt
{
    class ProductDB
    {

        
        public static string[] lines = System.IO.File.ReadAllLines(@"C:\Users\brett\Downloads\Project\Project\Products.txt");
       
        
       public static Product[] List(String query)
        {
            LinkedList<Product> list = new LinkedList<Product>();


            //return product;
        }
       
        public static Product Create(String line)
        {
            Product product = new Product();
            try
            {
                product.setString(line);
            }
            catch (Exception e)
            {
                
            }
            return product;
        }

   
      
    }
}
