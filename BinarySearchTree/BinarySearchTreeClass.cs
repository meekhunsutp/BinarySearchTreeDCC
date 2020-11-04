using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeClass
    {
        public Node RootNode;

        public BinarySearchTreeClass()
        {
            RootNode = null;
        }



        public void Add(int data)
        {
            Node nodeToAdd = new Node(data);
            if(RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            Node focusNode = RootNode;
            while(true)
            {
                if(nodeToAdd.Data < focusNode.Data)
                {
                    if(focusNode.LeftNode == null)
                    {
                        focusNode.LeftNode = nodeToAdd;
                        return;
                    }
                    else
                    {
                        focusNode = focusNode.LeftNode;
                    }
                }
                else
                {
                    if (focusNode.RightNode == null)
                    {
                        focusNode.RightNode = nodeToAdd;
                        return;
                    }
                    else
                    {
                        focusNode = focusNode.RightNode;
                    }
                }
            }

        }

        public bool Search(int data)
        {
            if (RootNode.Data == data)
            {
                return true;
            }
            Node focusNode = RootNode;
            while (true)
            {
                if (data < focusNode.Data)
                {
                    if (focusNode.LeftNode == null)
                    {
                        return false;
                    }
                    else if (focusNode.LeftNode.Data == data)
                    {
                        return true;
                    }
                    else
                    {
                        focusNode = focusNode.LeftNode;
                    }
                }
                else if (data > focusNode.Data)
                {
                    if (focusNode.RightNode == null)
                    {
                        return false;
                    }
                    else if (focusNode.RightNode.Data == data)
                    {
                        return true;
                    }
                    else
                    {
                        focusNode = focusNode.RightNode;
                    }
                
                }
            }
        }
    }
}
