using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BubbleSort
    {
        int max = 10;
        int[] list = new int[10] { 1, 8, 4, 6, 0, 3, 5, 2, 7, 9 };

        public void printAll()
        {   
            Console.WriteLine(string.Join(",", list));
        }

        public void sort()
        {
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max - 1 ; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        // Swap 
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
