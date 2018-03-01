using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ArrayPrg
    {
        public static void AddItemByindex()
        {
            List<int> arrayData = new List<int> { 1, 2, 3, 4, 5, 8, 9, 10 };
            int index = 2;
            var itemToAdd = Convert.ToInt32(Console.ReadLine());

            int n = arrayData.Count;

            foreach (var data in arrayData)
            {
                Console.Write(data + ",");
            }
            while (n >= index)
            {
                arrayData[n + 1] = arrayData[n];
                n--;
            }

            arrayData[index] = itemToAdd;

            foreach (var data in arrayData)
            {
                Console.Write(data + ",");
            }

        }
    }
}
