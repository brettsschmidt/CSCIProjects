using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Assignment6B_Schmidt
{
    class Assignment6Execution
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                string[] fileinfo = input.Split(' ', '-', ',');
                try
                {
                
                if (fileinfo[1] == null)
                {
                    fileinfo[1] = "jobs.txt";
                }

                if (fileinfo[2] == null)
                {
                    fileinfo[2] = "traceout";
                }
            }
                catch(Exception E)
                {
                    fileinfo = new string[3 ];
                    fileinfo[1] = "jobs.txt";
                    fileinfo[2] = "traceout";
                }
                if (fileinfo[1].Contains("\\") == false)
                {
                    string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string folderPath = System.IO.Path.GetDirectoryName(filePath);
                    fileinfo[1] = (folderPath + "\\" + fileinfo[1]);
                }
                

                StreamReader inputText = new StreamReader(fileinfo[1]);
                
                ProcessHeap Proccesses = new ProcessHeap(inputText, fileinfo[2]);
            }
            catch(Exception E)

            {
                Console.WriteLine("File failed failed to load");
                Console.ReadLine();
            }
        }
    }
}
