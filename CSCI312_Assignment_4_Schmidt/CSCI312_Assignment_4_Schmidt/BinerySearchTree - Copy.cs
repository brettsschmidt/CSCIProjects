using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Assignment_4_Schmidt
{
    class BinerySearchTree 
    {
        private int m_Size;

        private Node m_RootNode;

        private class Node
        {
            private int m_Key;
            private Object m_Obj;
            private Node rightNode;
            private Node leftNode;
            private int m_Size;

            public Node (int key, Object obj, int size)
            {
                this.m_Key = key;
                this.m_Obj = obj;
                this.m_Size = size;
            }

            public Object getObj()
            {
                return m_Obj;
            }

            public int getKey()
            {
                return m_Key;
            }

            public Node getLeftNode()
            {
                return leftNode;
            }

            public Node getRightNode()
            {
                return rightNode;
            }
            public void setLeftNode(Node LeftNode)
            {
                leftNode = LeftNode;
            }
            public void setRightNode(Node RightNode)
            {
                rightNode = RightNode;
            }
        }

        public BinerySearchTree()
        {
            m_Size = 0;
        }

        public int getSize()
        {
            return m_Size;
        }

        public void addNode(int key, Object obj)
        {
            if(key == 0 || obj == null)
            {
                return;
            }
            m_RootNode = addNode(m_RootNode, key, obj);
            m_Size++;
        }

        private Node addNode(Node node, int key, Object obj)
        {
            if(node == null)
            {
                return new Node(key, obj, 1);
            }
            int m_place = key.CompareTo(node.getKey());
            if (m_place < 0)
            {
                node.setLeftNode(addNode(node.getLeftNode(), key, obj));
            }
            else if(m_place > 0)
            {
                node.setRightNode(addNode(node.getRightNode(), key, obj));
            }
                return node;
        }

        public Object findNode(int key)
        {
            Node foundObject = findNode(m_RootNode, key);
            if (foundObject != null)
            {
                Console.WriteLine("Found Node with char: " + foundObject.getObj().ToString() + "; and a key of: " + foundObject.getKey());
                return foundObject.getObj();
            }
            else
            {
                Console.WriteLine("Nothing found.");
                return null;
            }
           
        }
        


        private Node findNode(Node node, int key)
        {
            Console.WriteLine("Looking at Node: " + node.getObj().ToString());
            if(node.getKey() == key)
            {
                return node;
            }
            else if(node.getKey() > key)
            {
                if(node.getLeftNode() == null)
                {
                    return null;
                }
                return findNode(node.getLeftNode(), key);
            }
            else if (node.getKey() < key)
            {
                if(node.getRightNode() == null)
                {
                    return null;
                }
                return findNode(node.getRightNode(), key);
            }
            else
            {
                return null;
            }

        }

        public void printPreorder()
        {
            Console.Write("Preorder: ");
            //Console.Write(m_RootNode.getObj().ToString() + ", ");
            // printPreorder(m_RootNode.getLeftNode());
            // printPreorder(m_RootNode.getRightNode());
            printPreorder(m_RootNode);
        }

        private void printPreorder(Node node)
        {
            
            if (node != null)
            {
                Console.Write(node.getObj().ToString() + ", ");

                if (node.getLeftNode() != null)
                {
                    printPreorder(node.getLeftNode());
                }
                if (node.getRightNode() != null)
                {
                    printPreorder(node.getRightNode());
                }
            }
        }
       
        public void printInorder()
        {
            Console.Write("Inorder: ");
            printInorder(m_RootNode);
        }

        private void printInorder(Node node)
        {
            

            if (node != null)
            {
                if (node.getLeftNode() != null)
                {
                    printInorder(node.getLeftNode());
                }
                Console.Write(node.getObj().ToString() + ", ");
                if (node.getRightNode() != null)
                {
                    printInorder(node.getRightNode());
                }
            }
        }

        public void printPostOrder()
        {
            Console.Write("Postorder: ");
            printPostOrder(m_RootNode);
        }

        private void printPostOrder(Node node)
        {
            

            if (node != null)
            {
                if (node.getLeftNode() != null)
                {
                    printPostOrder(node.getLeftNode());
                }
                if (node.getRightNode() != null)
                {
                    printPostOrder(node.getRightNode());
                }
                Console.Write(node.getObj().ToString() + ", ");
            }

        }

       


    }

   
}
