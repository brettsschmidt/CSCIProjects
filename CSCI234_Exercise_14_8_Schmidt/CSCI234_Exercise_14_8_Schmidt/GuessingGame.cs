using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Exercise_14_8_Schmidt
{
    class GuessingGame
    {
        private int numberToGuess;
        private int lastGuess;

        public GuessingGame()
        {
            Random numberGenerator = new Random();
            numberToGuess = numberGenerator.Next(1000);
            lastGuess = 0;
            
        }

        public Answer UserGuess(int guess)
        {
            bool WarmOrCold;

            if (numberToGuess - guess < 0 && numberToGuess - lastGuess < 0)
            {
                if (((numberToGuess - guess) * -1  < (numberToGuess - lastGuess) * -1))
                {
                    WarmOrCold = true;
                }
                else
                {
                    WarmOrCold = false;
                }
            }
            else if(numberToGuess - guess < 0 && numberToGuess - lastGuess > 0)
            {
                if (((numberToGuess - guess) * -1 < (numberToGuess - lastGuess) ))
                {
                    WarmOrCold = true;
                }
                else
                {
                    WarmOrCold = false;
                }
            }
            else if(numberToGuess - guess > 0 && numberToGuess - lastGuess < 0)
            {
                if (((numberToGuess - guess)  < (numberToGuess - lastGuess) * -1))
                {
                    WarmOrCold = true;
                }
                else
                {
                    WarmOrCold = false;
                }
            }
            else
            {
                if (((numberToGuess - guess) < (numberToGuess - lastGuess)))
                {
                    WarmOrCold = true;
                }
                else
                {
                    WarmOrCold = false;
                }
            }

            lastGuess = guess;

            if(guess < numberToGuess)
            {
                return new CSCI234_Exercise_14_8_Schmidt.Answer(guess + " is too low", false, WarmOrCold);
            }
            else if(guess > numberToGuess)
            {
                return new Answer(guess + " is too high", false, WarmOrCold);
            }
            else
            {
                return new Answer("Correct!", true, WarmOrCold);
            }
        }

    }

    public class Answer
    {
        private string m_clue;
        private bool m_correct;
        private bool m_WarmOrCold;

        public Answer(string clue, bool correct, bool WarmOrCold)
        {
            m_clue = clue;
            m_correct = correct;
            m_WarmOrCold = WarmOrCold;
        }

        public bool getWarmOrCold()
        {
            return m_WarmOrCold;
        }

        public bool getCorrect()
        {
            return m_correct;
        }

        public string getClue()
        {
            return m_clue;
        }
    }
}
