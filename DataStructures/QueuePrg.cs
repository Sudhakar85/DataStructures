using System;

namespace DataStructures
{
    public class QueuePrg
    {
        int max = 4;
        int rear = -1;
        int front = -1;
        int itemCount = 0;

        string[] queue = new string[5];

        public void Enque()
        {
            var data = Console.ReadLine();

            if (!IsFull())
            {   
                // ++rear => increment and assign
                // rear++ => assign and increment

                if(front == -1 )
                    front = 0;
                
                queue[++rear] = data;                
                itemCount++;
            }
            else
            {
                Console.WriteLine("Full");
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(queue[front++]);                
                itemCount--;
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }

        private bool IsFull()
        {
            return itemCount == max;
        }

        private bool IsEmpty()
        {
            return ( front == -1 || front > rear )
        }
    }
}
