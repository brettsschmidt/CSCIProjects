using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_A1_Schmidt
{
    class CSCI312_A1_Schmidt
    {
        

        static void Main(string[] args)
        {
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);

            Console.Out.WriteLine("Please enter file address to be read: ");

            string fileName = Console.In.ReadLine();

            Console.Out.WriteLine("Please enter desired file name: ");

            string desiredFileName = folderPath + "\\" +  Console.In.ReadLine();
            string text;

            try
                {
                   text = System.IO.File.ReadAllText(fileName);

                CharacterFrequency[] chars = new CharacterFrequency[255];
                int counter = 0;
                foreach (byte c in text)
                {
                    

                    if(chars[Convert.ToInt32(c.ToString())] == null)
                    {
                        chars[Convert.ToInt32(c.ToString())] = new CharacterFrequency();
                        chars[Convert.ToInt32(c.ToString())].setCharacter(c);
                        chars[Convert.ToInt32(c.ToString())].setFrequency(1);
                        counter++;
                    }
                    else
                    {
                        chars[Convert.ToInt32(c.ToString())].increment();
                    }
                }

                System.IO.StreamWriter file = new System.IO.StreamWriter(desiredFileName + ".txt");
                using (file)
                {
                    foreach (CharacterFrequency freqs in chars)
                    {
                        if (freqs != null)
                        {
                            file.WriteLine(freqs.toString());
                        }
                    }

                }
                 
            }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Unable to read file, please try again.");
                    
                }




            


        }
    }
}
