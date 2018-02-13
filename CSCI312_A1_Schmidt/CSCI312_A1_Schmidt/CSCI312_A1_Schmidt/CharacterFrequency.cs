using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_A1_Schmidt
{
    class CharacterFrequency
    {
        byte m_ch;
        int m_frequency;

        public byte getCharacter()
        {

            return m_ch;
        }

        public void setCharacter(byte ch)
        {
            m_ch = (byte)ch;

        }

        public int getFrequency()
        {
            return m_frequency;
        }

        public void setFrequency(int frequency)
        {
            m_frequency = frequency;
        }

        public void increment()
        {
            m_frequency++;
        }

        // Add bool
        public bool Equals()
        {
            return true;
        }

        //Add ToString that makes sense
        
        public string toString()
        {
            

            return (char)m_ch + "(" + m_ch.ToString() + ") " + m_frequency;

        }

        

    }
}
