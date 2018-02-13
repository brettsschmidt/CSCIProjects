using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSCI312_Assignment_4_Schmidt
{
    class ProcessHeap
    {
        LinkedList<m_Process>[] quantums = new LinkedList<m_Process>[5];
        LinkedList<m_Process> readyQuantum = new LinkedList<m_Process>();

        public class m_Process :IComparable<m_Process>
        {
            int m_ProccessNumber;
            int m_ArrivalTime;
            int m_ExecutionDuration;

            public m_Process(int ProccesssNumber, int ArrivalTime, int ExecutionDuration)
            {
                m_ProccessNumber = ProccesssNumber;
                m_ArrivalTime = ArrivalTime;
                m_ExecutionDuration = ExecutionDuration;
            }

            public int setExecutionDuration(int queTime)
            {
                m_ExecutionDuration = m_ExecutionDuration - queTime;
                return m_ExecutionDuration;
            }

            public int getExecutionDuration()
            {
                return m_ExecutionDuration;
            }
            
            public int getArrivalTime()
            {
                return m_ArrivalTime;
            }

            public int getProcessNumber()
            {
                return m_ProccessNumber;
            }

            public int CompareTo(m_Process other)
            {
                return m_ArrivalTime.CompareTo(other.getArrivalTime());
            }
        }

        

        BinerySearchTree readyQue = new BinerySearchTree();

        public ProcessHeap(StreamReader currentProcesses, string fileName)
        {
            while (currentProcesses.EndOfStream != false)
            {
                int inputNumber = 0;
                string currentInput = "";
                int[] informations = new int[3];
                string currentLine = currentProcesses.ReadLine();
                foreach (char c in currentLine)
                {
                    if (Convert.ToInt32(c) != 0)
                    {
                        currentInput = currentInput + c;
                    }
                    else
                    {
                        if (Convert.ToInt32(currentInput) != 0)
                        {
                            informations[inputNumber] = Convert.ToInt32(currentInput);
                            inputNumber++;
                            currentInput = "";
                        }
                    }
                }
                
                if (informations[0] != 0 || informations[1] != 0 || informations[2] != 0)
                {
                    m_Process newestProcess = new m_Process(informations[0], informations[1], informations[2]);
                    //readyQue.addNode(newestProcess.getArrivalTime(), newestProcess);
                    readyQuantum.AddLast(newestProcess);
                }
            }
            m_Process[] readyQuantumArray = readyQuantum.ToArray<m_Process>();
            Array.Sort(readyQuantumArray);
            
            

            this.RunProcesses(readyQuantumArray, fileName);

        }

        public void RunProcesses(m_Process[] readyQuantumArray, string fileName)
        {
            LinkedList<m_Process> readyQue = new LinkedList<m_Process>();
            foreach (m_Process process in readyQuantumArray)
            {
                readyQue.AddLast(process);
            }
            
            int currentTime = 0;
            bool processed = false;
            int N = 0;
            string timeTrace = "";
            string procTrace = "";
            while (processed == false)
            {
                bool goToThree = false;
                bool has_Run = false;
                if ( readyQue.First() != null &&  readyQue.First().getArrivalTime() <= currentTime)
                {
                    quantums[N].AddLast(readyQue.First());
                    timeTrace = timeTrace + "0";
                    procTrace = procTrace + quantums[N].Last().getProcessNumber();
                    readyQue.RemoveFirst();
                }
                if(quantums[N].First() != null)
                {
                    m_Process m_CurrentProccess = quantums[N].First();
                    quantums[N].RemoveFirst();
                    if(N == 0)
                    {
                        currentTime++;
                        m_CurrentProccess.setExecutionDuration(1);
                        timeTrace = timeTrace + "1";
                        procTrace = procTrace + m_CurrentProccess.getProcessNumber();
                        has_Run = true;
                    }
                    else
                    {
                        if(m_CurrentProccess.getExecutionDuration() < ((N + 1) * 2) - 2)
                        {
                            currentTime = currentTime + m_CurrentProccess.getExecutionDuration();
                            timeTrace = timeTrace + m_CurrentProccess.getExecutionDuration();
                            procTrace = procTrace + m_CurrentProccess.getProcessNumber();
                            has_Run = true;
                        }
                        else
                        {
                            timeTrace = timeTrace + (((N + 1) * 2) - 2);
                            procTrace = procTrace + m_CurrentProccess.getProcessNumber();
                        }
                        m_CurrentProccess.setExecutionDuration( ((N+1)*2)-2);
                    }
                    if(m_CurrentProccess.getExecutionDuration() > 0)
                    {
                        if(N == 4)
                        {
                            quantums[N].AddLast(m_CurrentProccess);
                        }
                        else
                        {
                            quantums[N + 1].AddLast(m_CurrentProccess);
                        }
                    }
                }

                else if(N < 5)
                {
                    N++;
                    goToThree = true;
                }
                if (goToThree == false)
                {
                    if (has_Run == false)
                    {
                        currentTime++;
                        N = 0;
                    }

                    if (readyQue.First == null && quantums[0] == null && quantums[1] == null && quantums[2] == null && quantums[3] == null && quantums[4] == null)
                    {
                        processed = true;
                    }
                }

                string filePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string folderPath = System.IO.Path.GetDirectoryName(filePath);
                
                    string desiredFileName = (folderPath + "\\" + fileName);
                
                
                System.IO.StreamWriter file = new System.IO.StreamWriter(desiredFileName + ".txt");
                using (file)
                {
                    
                    file.WriteLine("Time:    " + timeTrace);
                    file.WriteLine("Proc:    " + procTrace);

                }
            }




            

        }

    }
}
