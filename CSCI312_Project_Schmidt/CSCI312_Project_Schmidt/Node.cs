using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Project_Schmidt
{
    class Node: IComparable<Node>
    {
        private char m_Char;
        public int m_Freq;
        private Node m_Right;
        private Node m_Left;


        public Node(char Char)
        {
            m_Char = Char;
            m_Freq = 1;

        }

        public Node(int Freq)
        {
            m_Char = '*';
            m_Freq = Freq;
        }

        public void addNodes(char Char, List<bool> path)
        {
            if (path[0] == true)
            {
                if (path.Count > 1)
                {
                    if (this.m_Right == null)
                    {
                        this.m_Right = new Node(0);
                        path.Remove(path[0]);
                        this.m_Right.addNodes(Char, path);
                    }
                    else
                    {
                        path.Remove(path[0]);
                        this.m_Right.addNodes(Char, path);
                    }
                }
                else
                {
                    this.m_Right = new CSCI312_Project_Schmidt.Node(Char);
                }
            }
            else
            {

                if (path.Count > 1)
                {
                    if (this.m_Left == null)
                    {
                        this.m_Left = new Node(0);
                        path.Remove(path[0]);
                        this.m_Left.addNodes(Char, path);
                    }
                    else
                    {
                        path.Remove(path[0]);
                        this.m_Left.addNodes(Char, path);
                    }

                }
                else
                {
                    this.m_Left = new Node(Char);
                }
            }
                

            }
        

        public List<bool> Traverse(char Char, List<bool> path)
        {
        if (m_Right == null && m_Left == null)
        {
            if (Char.Equals(this.m_Char))
            {
                return path;
            }
            else
            {
                return null;
            }
        }
        else
        {
            List<bool> left = null;
            List<bool> right = null;

            if (m_Left != null)
            {
                List<bool> leftPath = new List<bool>();
                leftPath.AddRange(path);
                leftPath.Add(false);

                left = m_Left.Traverse(Char, leftPath);
            }

            if (m_Right != null)
            {
                List<bool> rightPath = new List<bool>();
                rightPath.AddRange(path);
                rightPath.Add(true);

                right = m_Right.Traverse(Char, rightPath);
            }

            if (left != null)
            {
                return left;
            }
            else
            {
                return right;
            }
        }
        }

        public char getChar()
        {
            return m_Char;
        }
        public void setChar(char Char)
        {
            m_Char = Char;
        }

        public void incFreq()
        {
            m_Freq++;
        }

        public int getFreq()
        {
            return m_Freq;
        }
        public void setFreq (int freq)
        {
            m_Freq = freq;
        }
        public Node getRightNode()
        {
            return m_Right;
        }
        public void setRightNode(Node right)
        {
            m_Right = right;
        }
        public Node getLeftNode()
        {
            return m_Left;
        }
        public void setLeftNode(Node Left)
        {
            m_Left = Left;
        }

        public int CompareTo(Node other)
        {
            if(this.m_Char == other.getChar())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int CompareTo(char c_Char)
        {
            if (this.m_Char == c_Char)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

