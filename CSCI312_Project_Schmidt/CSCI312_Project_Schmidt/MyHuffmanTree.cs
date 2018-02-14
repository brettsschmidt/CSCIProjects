using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_Project_Schmidt
{
    class MyHuffmanTree
    {
        private List<Node> nodes = new List<Node>();
        private Node m_Root;
        private List<bool> treeCopy = new List<bool>();
        private List<char> treeChars = new List<char>();
        private bool copyTreeRan;
        private string treeInfos;
        
        public MyHuffmanTree()
        {
            copyTreeRan = false;
        }

        public void BuildTree(string compressMe)
        {
            
            foreach (char c in compressMe)
            {
                bool incremented = false;
                foreach (Node c_Nodes in nodes)
                {
                    if(c_Nodes.CompareTo(c) == 1)
                    {
                        incremented = true;
                        c_Nodes.incFreq();
                    }
                }
                if(!incremented)
                {
                    nodes.Add(new Node(c));
                }
            }
            List<Node> charNodes = nodes.OrderBy(node => node.m_Freq).ToList<Node>();
            treeInfos = "";
            while (nodes.Count > 1)
            {
                List<Node> orgNodes = nodes.OrderBy(node => node.m_Freq).ToList<Node>();
                

                if(orgNodes.Count >= 2)
                {
                    List<Node> twoChildNodes = orgNodes.Take(2).ToList<Node>();

                    Node newDaddyNode = new Node((twoChildNodes[0].getFreq() + twoChildNodes[1].getFreq()));
                    newDaddyNode.setLeftNode(twoChildNodes[0]);
                    newDaddyNode.setRightNode(twoChildNodes[1]);
                    nodes.Remove(twoChildNodes[0]);
                    nodes.Remove(twoChildNodes[1]);
                    nodes.Add(newDaddyNode);
                }
                this.m_Root = nodes.FirstOrDefault();
            }

            foreach (Node CharNode in charNodes)
            {
                List<bool> codedChar = this.m_Root.Traverse(CharNode.getChar(), new List<bool>());
                
                
                foreach (bool b in codedChar)
                {
                    treeInfos += Convert.ToInt16(b);
                }
                treeInfos += CharNode.getChar();
               
            }
            
        }

        public string[] Encode(string compressMe)
        {
            List<bool> codedCompressMe = new List<bool>();
            this.BuildTree(compressMe);

            foreach(char c in compressMe)
            {
                List<bool> codedChar = this.m_Root.Traverse(c, new List<bool>());
                if (codedChar != null)
                {
                    codedCompressMe.AddRange(codedChar);
                }
            }

            int i = 0;
            string compressedString = "";
            int total = 0;

            // while((codedCompressMe.Count % 8) != 0)
            //  {

            //   List<bool> codedChar = this.m_Root.Traverse(' ', new List<bool>());
            //   if (codedChar != null)
            // {
            //    codedCompressMe.AddRange(codedChar);
            // }
            // }

            Console.WriteLine();
            

            foreach(bool b in codedCompressMe)
            {
                Console.Write(Convert.ToInt16(b));
                compressedString += Convert.ToInt16(b);
               // if(b)
                //{
                  //  total += (int)Math.Pow(2, i);
                //}

                //i++;
                //if(i >= 8)
                //{
                  //  compressedString += (total + " ");
                    //total = 0;
                    //i = 0;
                //}
            }

            Console.WriteLine();
            compressedString += total;
            //treeInfos += '~';
            string[] folderFiles = new string[2];
            folderFiles[0] = treeInfos;
            folderFiles[1] = compressedString;

            return folderFiles;

        }

        public string Decode(string decodeme, string CloneMyTree)
        {
            
            cloneTree(CloneMyTree);
            
            
            Node currentNode = this.m_Root;
            string decompressMe = "";
            List<bool> bits = new List<bool>();

           // string[] breakUpNumbers = decodeme.Split(' ');

            //foreach (char c in decodeme)
            //{
              //  int byteTime = Convert.ToInt32(c);

               // if(byteTime < 128)
               // {
                //    bits.Add(false);
              //  }
              //  if(byteTime < 64)
              //  {
               //     bits.Add(false);
               // }
                //if(byteTime < 32)
               // {
               //     bits.Add(false);
               // }
               // if(byteTime < 16)
               // {
               //     bits.Add(false);
               // }
               // if(byteTime < 8)
               // {
                //    bits.Add(false);
                //}

                //while (byteTime > 0)
               // {
                   // if ((byteTime % 2) == 1)
                   // {
                   //     bits.Add(true);
                   // }
                   // else
                   // {
                    //    bits.Add(false);
                   // }

                   // byteTime = byteTime / 2;
                //}
            //}
            Console.WriteLine();
            foreach (char c in decodeme)
            {
                if(c == '1')
                {
                    bits.Add(true);
                }
                else
                {
                    bits.Add(false);
                }
            }

            foreach(bool bit in bits)
            {
                Console.Write(Convert.ToInt16(bit));
                if(bit)
                {
                    if(currentNode.getRightNode() != null)
                    {
                        currentNode = currentNode.getRightNode();
                    }
                    
                }
                else
                {
                    if(currentNode.getLeftNode() != null)
                    {
                        currentNode = currentNode.getLeftNode();
                    }
                }

                if(this.IsLeaf(currentNode))
                {
                    decompressMe += currentNode.getChar();
                    currentNode = this.m_Root;
                }
            }
            return decompressMe;
        }
        
        public bool IsLeaf(Node node)
        {
            return (node.getLeftNode() == null && node.getRightNode() == null);
        }

        public Node getRoot()
        {
            
            return m_Root;
        }
        public void setRoot(Node Root)
        {
            m_Root = Root;
        }
        //public string copyTree()
        //{

            //Console.Write(m_RootNode.getObj().ToString() + ", ");
            // printPreorder(m_RootNode.getLeftNode());
            // printPreorder(m_RootNode.getRightNode());

            
            //copyTree(m_Root);
            
           // string treeOutput = "";
           // bool isNode = true;
           // int currentChar = 0;

           // foreach(bool b in treeCopy)
            //{
                
                  //  treeOutput += Convert.ToInt16(b);
                  //  if(b && isNode)
                  //  {
                  //      treeOutput += treeChars[currentChar];
                  //      currentChar++;
                //    }

                

           // isNode = !isNode;
           // }

            
           /// copyTreeRan = true;
           // return treeOutput;

       // }

        

        private void copyTree(Node node)
        {
            if(copyTreeRan)
            {
                return;
            }

            if (node != null)
            {

                if(node.getLeftNode() == null && node.getRightNode() == null)
                {
                    treeCopy.Add(true);
                    treeChars.Add(node.getChar());

                }
                else
                {
                    treeCopy.Add(false);
                }

                if (node.getLeftNode() != null)
                {
                    treeCopy.Add(true);
                    copyTree(node.getLeftNode());
                }
                if (node.getRightNode() != null)
                {
                    treeCopy.Add(false);
                    copyTree(node.getRightNode());
                }
            }
        }

        public void cloneTree(string treeInfo)
        {
            

            string cloneTreeInfo = treeInfo;

            
            
            m_Root = new Node(0);
            List<bool> currentPath = new List<bool>();

            foreach (char c in cloneTreeInfo)
            {
                if(c != '1' && c != '0')
                {
                    m_Root.addNodes(c, currentPath);
                    currentPath.Clear();
                    
                }
                else
                {
                    if (c == '1')
                    {
                        currentPath.Add(true);
                    }
                    else
                    {
                        currentPath.Add(false);
                    }
                }
                


                
            }
            
        }

        

    }
}
