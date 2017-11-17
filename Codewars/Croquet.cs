using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    //http://www.codewars.com/kata/categorize-new-member/train/csharp

/*
 * The Western Suburbs Croquet Club has two categories of membership, Senior and Open. 
 * They would like your help with an application form that will tell prospective members which category they will be placed.
 * To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
 * In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
    Input
    Input will consist of a list of lists containing two items each. Each list contains information for a single potential member. 
    Information consists of an integer for the person's age and an integer for the person's handicap.

*/


    public class Croquet
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var resultList = new string[data.Length];

            int memberCount = 0;

            foreach(int[] member in data)
            {
                var age = member[0];
                var handicap = member[1];

                if (age >= 55 && handicap > 7)
                {
                    resultList[memberCount] = "Senior";
                }
                else
                    resultList[memberCount] = "Open";

                memberCount++;
            }



            return resultList;

        }
    }
}
