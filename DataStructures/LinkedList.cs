using System;

namespace DataStructures
{
    public class LinkedList
    {
        private Node Head;      
        private int count;


        public void BuildList()
        {
            int n =  count = Convert.ToInt32(Console.ReadLine());

            while (n > 0 )
            {
                AddElements(Console.ReadLine());
                n--;
            }
        }

        public void printAllNodes()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + ",");
                currentNode = currentNode.nextElement;
            }

            Console.WriteLine("");
        }

        public void AddElements(string data)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.data = data;
                Head.nextElement = null;
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
            Node currentNode = Head;

            while (currentNode.nextElement != null)
            {
                currentNode = currentNode.nextElement;
            }
            Node newNode = new Node();
            newNode.data = data;
            currentNode.nextElement = newNode;
            count++;
        }

        public void AddFirst()
        {
            string data = Console.ReadLine();
            Node newNode = new Node();
            newNode.data = data;

            if (Head != null)
            {
                newNode.nextElement = Head;
                Head = newNode;
            }

            count++;
        }

        public void Reverse()
        {
            Node currentNode = Head;
            Node nextNode = null;
            while (currentNode != null)
            {
                Node temp = currentNode.nextElement;
                currentNode.nextElement = nextNode;
                nextNode = currentNode;
                currentNode = temp;
            }

            Head = nextNode;

        }
        public void Delete()
        {
            string data = Console.ReadLine();
            Node currentNode = Head;
            Node previosNode = null;

            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    previosNode.nextElement = currentNode.nextElement;
                    currentNode = null;
                    Console.WriteLine("Deleted");
                    return;
                }
                previosNode = currentNode;
                currentNode = currentNode.nextElement;
               
            }

            Console.WriteLine("Not Found...!!");
        }
        public void Find()
        {
            string data = Console.ReadLine();

            Node currentNode = Head;

            while (currentNode != null)
            {

                if (currentNode.data == data)
                {
                    Console.WriteLine("Found...!!");
                    return;
                }
                currentNode = currentNode.nextElement;
            }

            Console.WriteLine("Not Found...!!");
        }
    }

    public class Node
    {
        public string data;
        public Node nextElement;
    }
}
