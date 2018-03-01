using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Tree
    {
        BNode root;

        public void Insert()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            BNode current;
            BNode parent;

            BNode newNode = new BNode();
            newNode.data = value;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                current = root;

                while (true)
                {
                    parent = current; // Maintain the Parent

                    if (value < parent.data)
                    {
                        current = parent.leftChid;  // // Maintain the Left Node as Parent

                        if (current == null)
                        {
                            parent.leftChid = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = parent.rightChild; // Maintain the Right Node as Parent

                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }


        public void Search()
        {
            Console.WriteLine("Enter Data to search");
            var val = Convert.ToInt32(Console.ReadLine());

            BNode parent = root;

            while (parent != null)
            {
                if (val < parent.data)
                {
                    parent = parent.leftChid;
                }
                else if (val > parent.data)
                {
                    parent = parent.rightChild;
                }
                else
                {
                    Console.WriteLine("Found...!!");
                    return;
                }
            }
        }


        public void Pre_Order_Traverse()
        {
            Pre_Order_Traverse(root);
        }

        public void Pre_Order_Traverse(BNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);

                Pre_Order_Traverse(root.leftChid);
                Pre_Order_Traverse(root.rightChild);
            }

        }

        public void In_Order_Traverse()
        {
            In_Order_Traverse(root);
        }

        public void In_Order_Traverse(BNode root)
        {
            if (root != null)
            {
                In_Order_Traverse(root.leftChid);

                Console.WriteLine(root.data);

                In_Order_Traverse(root.rightChild);
            }
        }

        public void Post_Order_Traverse()
        {
            Post_Order_Traverse(root);
        }

        public void Post_Order_Traverse(BNode root)
        {
            if (root != null)
            {
                Post_Order_Traverse(root.leftChid);
                Post_Order_Traverse(root.rightChild);

                Console.WriteLine(root.data);
            }
        }
    }

    public class BNode
    {
        public int data;
        public BNode leftChid;
        public BNode rightChild;
    }
}
