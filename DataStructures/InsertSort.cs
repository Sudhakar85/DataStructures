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
        /// Example : 5492389 Skip 1 Value
        // Step 1 : Skip 5 
        // Step 2 : Swap 5 and 4 like 459
        // Step 3 : Skip 9 like 459
        // Step 4: : in While loop ( Swap 9 to 2 and all the way to like 2459 )
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
