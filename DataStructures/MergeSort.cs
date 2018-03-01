using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MergeSort
    {
        int max = 10;
        int[] list = new int[10] { 1, 8, 4, 6, 0, 3, 5, 2, 7, 9 };
        int[] b = new int[10];

        public void printAll()
        {
            Console.WriteLine(string.Join(",", list));
        }

        /// <summary>
        /// O(n log n)
        ///  Compare the item which is already sorted and swap the value
        /// </summary>
        public void sort(int low, int high)
        {
            int mid = 0;

            if (low < high)
            {
                mid = (low + high) / 2;
                sort(low, mid);
                sort(mid + 1, high);
                merge(low, mid, high);
            }
            else
            {
                return;
            }
        }

        public void merge(int low, int mid, int high)
        {
            int l1, l2, i = 0;


            for (l1 = low, l2 = mid, i = low; l1 <= mid && l2 <= high; i++)
            {
                if (list[l1] <= list[l2])
                    b[i] = list[l1++];
                else
                    b[i] = list[l2++];
            }
            while (l1 <= mid)
                b[i++] = list[l1++];

            while (l2 <= high)
                b[i++] = list[l2++];

            for (i = low; i <= high; i++)
                list[i] = b[i];
        }

    }
}
