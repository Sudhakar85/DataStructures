using System;

namespace DataStructures
{
    public class SelectionSort
    {

        int max = 10;
        int[] list = new int[10] { 1, 8, 4, 6, 0, 3, 5, 2, 7, 9 };

        public void printAll()
        {
            Console.WriteLine(string.Join(",", list));
        }

        /// <summary>
        /// O(n2)
        ///  Compare the item which is already sorted and swap the value
        /// </summary>
        public void sort()
        {
            int indexMin = 0;
            for (int i = 0; i < max; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (list[j] < list[indexMin])
                    {
                        indexMin = j;
                    }
                }

                if (indexMin != i)
                {
                    int temp = list[indexMin];
                    list[indexMin] = list[i];
                    list[i] = temp;
                }
            }

        }
    }
}
