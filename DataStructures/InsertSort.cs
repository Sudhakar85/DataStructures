using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class InsertSort
    {
        int max = 10;
        int[] list = new int[10] { 1, 8, 4, 6, 0, 3, 5, 2, 7, 9 };

        public void printAll()
        {
            Console.WriteLine(string.Join(",", list));
        }


        /// <summary>
        ///  Compare the item which is already sorted and swap the value
        /// </summary>
        public void sort()
        {
            int valueTOinsert;
            int holePosition = 0;
            for (int i = 0; i < max; i++)
            {
                valueTOinsert = list[i];
                holePosition = i;

                while (holePosition > 0 && list[holePosition - 1] > valueTOinsert)
                {
                    list[holePosition] = list[holePosition - 1];
                    holePosition--;
                }

                if (holePosition != i)
                {
                    list[holePosition] = valueTOinsert;
                }
            }
        }
    }

}
