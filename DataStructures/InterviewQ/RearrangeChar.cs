using System;
using System.Collections;

namespace DataStructures.InterviewQ
{
    public class RearrangeChar
    {

        public static void GetInput()
        {
            var value = Console.ReadLine();
            char [] array = value.ToCharArray();
            int [] freq = new int[array.Length];
            string distinctVal = "";
            int index = 0;

            // aabccd
            // abcd
            for (int i = 0; i < array.Length; i++)
            {
                var split = value.Split(new char[1] { array[i] });
                if (!distinctVal.Contains(array[i].ToString()))
                {
                    freq[index] = split.Length - 1;
                    distinctVal += array[i];
                    index++;
                }
            }

            
            char[] distinctValue = distinctVal.ToCharArray();

            string result = "";
            index = 0;

            bool nextVaueFound = false;
            while(result.Length < array.Length)
            {                
                result += distinctValue[index];  
                freq[index]--;

                for (int i = 0; i < distinctVal.Length; i++)
                {
                    if (distinctValue[i] != distinctVal[index] && freq[i] != 0)
                    {
                        nextVaueFound = true;
                        index = i;
                        break;
                    }
                }

                if (!nextVaueFound)
                {
                    Console.WriteLine("Can not Rearrange!!");
                    break;
                }
                
            }

            if(nextVaueFound)
                Console.WriteLine("Result :" + result);


        }

    }
}
