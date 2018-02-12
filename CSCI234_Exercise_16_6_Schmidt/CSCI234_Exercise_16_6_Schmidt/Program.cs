using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_16_6_Schmidt
{
    class Program
    {
        static void Main(string[] args)
        {
            FiveLetterWordReader myReader = new FiveLetterWordReader();

            Console.WriteLine("Please enter a five letter word: ");
            try
            {
                string[] threeComb = myReader.ThreeLetterCombinations(Console.ReadLine());
                foreach (string word in threeComb)
                {
                    Console.WriteLine(word);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
            }
            
            

            Console.ReadKey();
           

        }
    }

    class FiveLetterWordReader
    {
        public string[] ThreeLetterCombinations(string fiveLetters)
        {
            if(fiveLetters.Length != 5)
            {
                throw new FormatException(string.Format("Too many or too little letters, string had {0} letters", fiveLetters.Length));
            }

            char[] chars = fiveLetters.ToCharArray();
            LinkedList<string> threeCombs = new LinkedList<string>();
            for(int a = 0; a < 3; a++)
            {
                for(int b = 1; b < 4; b++)
                {
                    for(int c = 2; c < 5; c++)
                    {
                        if(c > b && c > a && b > a)
                        {
                            threeCombs.AddLast(string.Format("{0}{1}{2}", chars[a], chars[b], chars[c]).ToLower());
                        }
                    }
                }
            }

            return threeCombs.ToArray<string>();

        }
    }

}
