using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class SplitString
    {
        /* Complete the solution so that it splits the string into pairs of two characters. 
         * If the string contains an odd number of characters 
         * then it should replace the missing second character of the final pair with an underscore ('_').
         * 
         * 
         * 
         */
        public static string[] Solution(string str)
        {
            //append an underscore to str if it has odd number of chars
            if (str.Length % 2 ==1)
            {
                str += "_";
            }

            int pairCount = (str.Length / 2);

            string[] result = new string[pairCount];

            string pair = "";

            int pairIndex = 0;

            for(int i = 0; i < str.Length; i++)
            {
                pair += str[i];

                if (pair.Length == 2)
                {
                    result[pairIndex] = pair;
                    pairIndex++;
                    pair = "";
                }
            }

            return result;
        }

    }
}
