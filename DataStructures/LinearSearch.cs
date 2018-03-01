using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinearSearch
    {
        int MAX = 20;
        int [] intArray = new int[20]{ 1, 2, 3, 4, 6, 7, 9, 11, 12, 14, 15, 16, 17, 19, 33, 34, 43, 45, 55, 66 };
        int comparisons = 0;

        /// <summary>
        /// O(n) - Poor Time Complexity
        /// </summary>
        public void LinearFind()
        {
            var data = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < MAX; i++)
            {
                comparisons++;
                if (data == intArray[i])
                {
                    Console.WriteLine("Found!! : " + comparisons.ToString());
                    comparisons = 0;
                    return;
                }
            }

            Console.WriteLine("Not Found :( : " + comparisons.ToString() );
            comparisons = 0;
        }

        /// <summary>
        ///  O ( log N )
        ///  
        ///  Data Has to be sorted before using this algorithm
        /// </summary>
        public void BinarySearch()
        {
            var data = Convert.ToInt32(Console.ReadLine());

            int mid = 0;
            int low = 0;
            int high = MAX - 1;

            while (low <= high)
            {
                comparisons++;
                mid = (low + high) / 2;

                if (intArray[mid] < data)
                {
                    low = mid + 1;
                }
                else if (intArray[mid] > data)
                {
                    high = mid - 1;
                }
                else
                {
                    Console.WriteLine("Found!! : " + comparisons.ToString());
                    comparisons = 0;
                    return;
                }
            }

            
            Console.WriteLine("Not Found :( : " + comparisons.ToString());
            comparisons = 0;

        }


        /// <summary>
        ///  O ( log(log N) )
        ///  
        ///  Data Has to be sorted before using this algorithm
        ///  Improve the BST
        ///  BST doesnt use sorted value but this one uses the sorted value to find the mid item
        /// </summary>
        public void InterpolationSearch()
        {
            var data = Convert.ToInt32(Console.ReadLine());

            int mid = 0;
            int low = 0;
            int high = MAX - 1;            

            while (low <= high)
            {
                comparisons++;

                if (high - low == 0)
                {                    
                    Console.WriteLine("Not Found :( : " + comparisons.ToString());
                    comparisons = 0;
                    return;
                }

                mid = low + ( ((high - low) / (intArray[high] - intArray[low])) * (data - intArray[low]) );

                if (intArray[mid] == data)
                {   
                    Console.WriteLine("Found!! : " + comparisons.ToString());
                    comparisons = 0;
                    return;
                }
                else if (intArray[mid] < data)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }                
            }
        }
    }
}
