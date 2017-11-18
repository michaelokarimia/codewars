using System.Collections.Generic;

namespace Codewars
{
    public class DuplicateCounter
    {
        /*
         * Write a function that will return the count of distinct case-insensitive alphabetic characters
         * and numeric digits that occur more than once in the input string. 
         * The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits
         * 
         * */


        public static int DuplicateCount(string str)
        {

            var duplicateCount = 0;

            var dict = new Dictionary<char, bool>();

            //iterate through each char in the string
            foreach(char c in str.ToLowerInvariant())
            {
                //if char already exists in the string, 
                if(dict.ContainsKey(c))
                {
                    var alreadyCountedAsDuplicate = dict[c];
                    
                    if(!alreadyCountedAsDuplicate)
                    {
                        duplicateCount++;
                        dict[c] = true;
                    }
                    
                }
                else
                {
                    //else it's new, so add it to the dict

                    dict.Add(c, false);
                }

            }



            return duplicateCount;
        }
    }
}