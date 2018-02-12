using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI_231_Assignment7_Schmidt
{
    class SchmidtsHashTable
    {

        private int m_hashTableSize;
        private LinkedList<object>[] m_hashTable;

        public SchmidtsHashTable(int hashTableSize)
        {
            m_hashTableSize = hashTableSize;
            m_hashTable = new LinkedList<object>[m_hashTableSize];
        }

        public void set(string key, object m_value)
        {
            int largeInt = 0;

            foreach(byte c in key )
            {
                largeInt += largeInt + c;
                largeInt *= largeInt / c;
            }
            if(largeInt < 0)
            {
                largeInt = largeInt * -1;
            }

            int hashKey = largeInt % (m_hashTableSize - 1);

            try
            {
                m_hashTable[hashKey].AddLast(m_value);
            }
            catch(Exception E)
            {
                m_hashTable[hashKey] = new LinkedList<object>();
                m_hashTable[hashKey].AddLast(m_value);
            }

        }

        public object[] get(string key)
        {
            int largeInt = 0;

            foreach (byte c in key)
            {
                largeInt += largeInt + c;
                largeInt *= largeInt / c;
            }

            if (largeInt < 0)
            {
                largeInt = largeInt * -1;
            }

            int hashKey = largeInt % (m_hashTableSize - 1);

            return m_hashTable[hashKey].ToArray<object>();

        }

    }
}
