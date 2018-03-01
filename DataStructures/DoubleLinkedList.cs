using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoubleLinkedList
    {
        private DNode Head;
        private DNode Last;
        private int count;

        public void BuildList()
        {
            int n = count = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                AddElements(Console.ReadLine());
                n--;
            }
        }

        public void AddElements(string data)
        {
            if (Head == null)
            {
                Head = new DNode();
                Head.data = data;
                Head.nextElement = null;
                Head.previousElement = null;
            }
            else
            {
              AddLast(data);
            }
        }


        public void AddLast()
        {
            AddLast(Console.ReadLine());

        }

        public void AddLast(string data)
        {
            DNode currentNode = Head;

            while (currentNode.nextElement != null)
            {
                currentNode = currentNode.nextElement;
            }
            DNode newNode = new DNode();
            newNode.data = data;
            currentNode.nextElement = newNode;
            newNode.previousElement = currentNode;
            count++;

            Last = newNode;
        }


        public void printAllNodes()
        {
            DNode currentNode = Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + ",");
                currentNode = currentNode.nextElement;
            }

            Console.WriteLine("");
        }

        public void reversePrintAll()
        {
            DNode currentNode = Last;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + ",");
                currentNode = currentNode.previousElement;
            }

            Console.WriteLine("");
        }
    }

    public class DNode
    {
        public string data;
        public DNode nextElement;
        public DNode previousElement;
    }
}
