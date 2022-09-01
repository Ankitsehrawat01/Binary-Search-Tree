using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treedatastructure
{
    internal class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node(id);
            //newNode.item = id
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }

        }
        //Preorder
        public void Display(Node Root)
        {
            if (Root != null)
            {
                Console.WriteLine(Root.item + " |");
                Display(Root.leftc);
                Display(Root.rightc);
            }
        }
        public void Post(Node Root)
        {
            if (Root != null)
            {
                Post(Root.leftc);
                Post(Root.rightc);
                Console.WriteLine(Root.item + " |");
            }
        }
        public void Inorder(Node Root)
        {
            if(Root != null)
            {
                Inorder(Root.leftc);
                Console.WriteLine(Root.item + " |");
                Inorder(Root.rightc);
            }
        }
    }
}
