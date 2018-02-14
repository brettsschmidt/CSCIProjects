using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Project_Schmidt
{
    class HuffmanTester
    {
        static void Main(string[] args)
        {
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);
            MyHuffmanTree myHhuffmanTree = new MyHuffmanTree();
            Console.WriteLine("Please enter encode or decode_file address to be compressed or decompressed: ");
            string[] userInput = Console.In.ReadLine().Split(',', '_', ' ');

            string desiredFileName = folderPath + "\\" + userInput[1];
            if (userInput[0] == "encode")
            {
                string encodeThis = "";
                try
                {
                    StreamReader rs = new StreamReader(desiredFileName + ".txt");
                    using (rs)
                    {
                        encodeThis = rs.ReadToEnd();
                    }

                    StreamWriter ws = new StreamWriter(desiredFileName + "BrettCompressed.txt");
                    string[] encodedText = myHhuffmanTree.Encode(encodeThis);

                    using (ws)
                    {
                        ws.WriteLine(encodedText[0]);
                        ws.WriteLine(encodedText[1]);
                    }

                }
                catch (Exception E)
                {
                    Console.WriteLine("It didn't work!");
                }
            }
            else
            {
                try
                {
                    string[] dataStuff = new string[2];
                    StreamReader rs = new StreamReader(desiredFileName + ".txt");
                    using (rs)
                    {
                        dataStuff[0] = rs.ReadLine();
                        dataStuff[1] = rs.ReadToEnd();
                    }

                    StreamWriter ws = new StreamWriter(desiredFileName + "BrettDeCompressed.txt");
                    string decodedText = myHhuffmanTree.Decode(dataStuff[1], dataStuff[0]);
                    
                    using (ws)
                    {
                        ws.Write(decodedText);
                    }

                }
                catch (Exception E)
                {
                    Console.WriteLine("It didn't work!");
                }
            }

            Console.WriteLine("It worked!");
            Console.ReadLine();




           
        }
    }
}
