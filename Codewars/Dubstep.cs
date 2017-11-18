using System;

namespace Codewars
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            string result = "";

            string[] searchStr = { "WUB"};

            var tempResult = input.Split(searchStr, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in tempResult)
            {
                result += " " + s;
            }

            return result.Trim();
        }
    }
}