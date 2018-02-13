using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Assignment_5_Schmidt
{
    class Calculator
    {

        private class CareTaker
        {
            Momento m_currentMomento;

            public Momento getMomento()
            {
                return m_currentMomento;
            }

            public Momento addMomento(decimal solution)
            {
                if(m_currentMomento == null)
                {
                    m_currentMomento = new CSCI312_Assignment_5_Schmidt.Calculator.Momento(solution);
                }
                else
                {
                    Momento newMomento = new Momento(m_currentMomento, solution);
                    m_currentMomento = newMomento;
                }
                return m_currentMomento;
            }
            
            public Momento undoMomento()
            {
                if(m_currentMomento == null || m_currentMomento.getLastMomento() == null)
                {
                    return null;
                }
                else
                {
                    Momento undoMomento = m_currentMomento.getLastMomento();
                    m_currentMomento = undoMomento;
                    return m_currentMomento;
                }
            }

            public Momento clearMomento()
            {
                m_currentMomento = null;
                return m_currentMomento;
            }
        }

        private class Momento
        {
            decimal m_runningTotal;
            decimal m_currentSolution;
            Momento m_lastMomento;
            
            

            public Momento(decimal firstSolution)
            {
                m_currentSolution = firstSolution;
                m_runningTotal = firstSolution;
            }

            public Momento(Momento lastMomento, decimal currentSolution)
            {
                m_currentSolution = currentSolution;
                m_lastMomento = lastMomento;
                setRunningTotal(m_lastMomento.getRunningTotal());
            }

            public decimal getCurrentSolution()
            {
                return m_currentSolution;
            }

            public Momento getLastMomento()
            {
                return m_lastMomento;
            }

            public decimal getRunningTotal()
            {
                return m_runningTotal;
            }

            public void setRunningTotal(decimal lastRunningTotal)
            {
                m_runningTotal = m_currentSolution + lastRunningTotal;
            }
        }

        CareTaker theUndertaker = new CareTaker();

        public string newOperation(string operation)
        {
            switch (operation)
            {
                case "UNDO":
                    try
                    {
                        return undoOperation(theUndertaker.undoMomento().getRunningTotal());
                    }
                    catch (Exception E)
                    {
                        theUndertaker.clearMomento();
                        return undoOperation(0);
                    }
               
                case "CLEAR":
                    theUndertaker.clearMomento();
                    return undoOperation(0);

                case "EXIT":
                    return null;

                default:
                    return this.operatorOperation(operation);
                    
            }
        }

        private string operatorOperation(string newestOperation)
        {
            string[] operators = newestOperation.Split(null);
            
            decimal m_firstNumberal;
            decimal m_secondNumberal;
            try
            {
                if (operators[0] == "0" && operators[2] != "0")
                {
                    m_secondNumberal = Convert.ToDecimal(operators[2]);
                    m_firstNumberal = 0;
                    if (m_secondNumberal == 0)
                    {
                        return wrongInput();
                    }
                }

                else if (operators[0] != "0" && operators[2] == "0")
                {
                    m_secondNumberal = 0;
                    m_firstNumberal = Convert.ToDecimal(operators[0]);
                    if (m_firstNumberal == 0)
                    {
                        return wrongInput();
                    }
                }
                else if (operators[0] != "0" && operators[2] != "0")
                {
                    m_secondNumberal = Convert.ToDecimal(operators[2]);
                    m_firstNumberal = Convert.ToDecimal(operators[0]);

                    if (m_firstNumberal == 0 || m_secondNumberal == 0)
                    {
                        return wrongInput();
                    }
                }
                else
                {
                    m_secondNumberal = 0;
                    m_firstNumberal = 0;
                }

                switch (operators[1])
                {
                    case "+":
                        theUndertaker.addMomento(m_firstNumberal + m_secondNumberal);
                        return "Sum: " + theUndertaker.getMomento().getCurrentSolution() + "; Running Total: " + theUndertaker.getMomento().getRunningTotal();

                    case "-":
                        theUndertaker.addMomento(m_firstNumberal - m_secondNumberal);
                        return "Difference: " + theUndertaker.getMomento().getCurrentSolution() + "; Running Total: " + theUndertaker.getMomento().getRunningTotal();


                    case "*":
                        theUndertaker.addMomento(m_firstNumberal * m_secondNumberal);
                        return "Product: " + theUndertaker.getMomento().getCurrentSolution() + "; Running Total: " + theUndertaker.getMomento().getRunningTotal();

                    case "/":
                        theUndertaker.addMomento(m_firstNumberal / m_secondNumberal);
                        return "Quotient: " + theUndertaker.getMomento().getCurrentSolution() + "; Running Total: " + theUndertaker.getMomento().getRunningTotal();

                    default:
                        return wrongInput();

                }
            }
            catch(Exception E)
            {
                return wrongInput();
            }

        }

        


        private static string wrongInput()
        {
            return "Invalid input. Please enter in format: decimal-number operation decimal-number.";
        }

        private static string undoOperation(decimal runningTotal)
        {
            

            return ("Running Total:" + runningTotal);
        }




    }
}
