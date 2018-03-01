using System;

namespace DataStructures
{
    public class HashTablePrg
    {

        int size = 5;

        DataItem[] item = new DataItem[5];

        public int getHashCode(int key)
        {
            return key % size;
        }

        public void Insert()
        {
            Console.WriteLine("Enter Data and Key ");
            var data = Convert.ToInt32(Console.ReadLine());
            var key = Convert.ToInt32(Console.ReadLine());

            int hasIndex = getHashCode(key);

            while (item[hasIndex] != null && item[hasIndex].key != -1)
            {
                ++hasIndex;

                hasIndex %= size;
            }

            DataItem newItem = new DataItem();
            newItem.data = data;
            newItem.key = key;

            item[hasIndex] = newItem;
        }

        public void Searh()
        {
            Console.WriteLine("Enter Key to search ");
            var key = Convert.ToInt32(Console.ReadLine());

            int hasIndex = getHashCode(key);

            while (item[hasIndex] != null)
            {
                if (item[hasIndex].key == key)
                {
                    Console.WriteLine("Found : " + item[hasIndex].data);
                    return;
                }

                ++hasIndex;

                hasIndex %= size;
            }
        }
    }

    public class DataItem
    {
        public int data;
        public int key;
    }
}

