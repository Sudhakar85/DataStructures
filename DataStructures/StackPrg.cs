using System;

namespace DataStructures
{
    public class StackPrg
    {
        int maxSize = 4;
        int top = 0;
        string [] stack = new string[5];

        public void Push()
        {
            var data = Console.ReadLine();

            if (!IsFull())
            {
                top = top + 1;
                stack[top] = data;               
            }
            else
            {
                Console.WriteLine("Full");
            }

        }

        public void pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(stack[top]);
                top = top - 1;
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }

        private bool IsFull()
        {
            return top == maxSize;
        }

        private bool IsEmpty()
        {
            return top == -1;
        }


    }

}
