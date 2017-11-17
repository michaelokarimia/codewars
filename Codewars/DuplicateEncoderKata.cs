using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    public class DuplicateEncoderKata
    {

        /*
         * The goal of this exercise is to convert a string to a new string 
         * where each character in the new string is '(' if that character appears only once in the original string, 
         * or ')' if that character appears more than once in the original string.
         * Ignore capitalization when determining if a character is a duplicate.

            Examples:

            "din" => "((("

            "recede" => "()()()"

            "Success" => ")())())"

            "(( @" => "))((" 

            */


        internal static void Run()
        {
            Console.WriteLine("The goal of this exercise is to convert a string to a new string \n" +
                "where each character in the new string is '(' if that character appears only once in the original string \n" +
                "or ')' if that character appears more than once in the original string.");
            Console.WriteLine("\nEnter word to transform into output word that shows duplicates");

            Console.WriteLine("Output string is {0}", DuplicateEncode(Console.ReadLine()));
        }

        public static string DuplicateEncode(string word)
        {
            StringBuilder result = new StringBuilder();

            //make case insensitive
            word = word.ToLower();

            char[] letters = word.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            //scan all letters and add them into a dictionary, keeping count of appearances

            //then scan string again and count appearences, to build out the result string

            //O(2n) time complexity
            foreach(char c in letters)
            {
                if(dict.ContainsKey(c))
                {
                    //increment appearances count
                    var currentNumberOfAppearences = dict[c];

                    dict[c] = currentNumberOfAppearences + 1;
                }
                else
                {
                    //add new letter to dictionary
                    dict.Add(c, 1);
                }
            }

            //scan the original word again and build the result string

            foreach(char c in letters)
            {
                //letter is unique in entire word
                if(dict[c] == 1)
                {
                    result.Append('(');
                }
                //it is a duplicate letter
                else
                {
                    result.Append(')');
                }
            }


            return result.ToString();
        }
    }
}
 