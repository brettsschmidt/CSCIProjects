using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_18_6_Schmidt
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folderPath = System.IO.Path.GetDirectoryName(filePath);

            Console.Out.WriteLine("Please enter desired file name: ");

            string desiredFileName = folderPath + "\\" + Console.In.ReadLine();

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(desiredFileName + ".txt");
                using (file)
                {
                    file.WriteLine(bubbleSortList(100));
                    file.WriteLine(bubbleSortList(1000));
                    file.WriteLine(bubbleSortList(10000));
                    file.WriteLine(bubbleSortList(25000));
                    file.WriteLine(bubbleSortList(50000));
                   
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Not working");
            }


        }

        static int bubbleSort(int[] list)
        {
            int n = list.Length;
            int counter = 0;

            bool swapped = true;
            while (swapped == true)
            {
                swapped = false;
                for (int i = 1; i <= (n - 1); i++)
                {
                    if (list[i - 1] > list[i])
                    {
                        int swap = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = swap;
                        swapped = true;

                    }
                }
                counter++;
            }
            return counter;
        }
        


        static String bubbleSortList(int m_number)
        {
            int[] list = new int[m_number];
            Random ran = new Random();
            for (int i = 0; i < m_number; i++)
            {
                list[i] = ran.Next(1, 101);
            }

            DateTime start = DateTime.Now;
            DateTime end;
            

            bubbleSort(list);


            end = DateTime.Now;
            TimeSpan ts = end.Subtract(start);
            String m_duration = (m_number + " Integers BubbleSort Duration = " + ts.TotalMilliseconds + " ms");
            Console.WriteLine(m_duration);
            return m_duration;


        }
       

    }
}

