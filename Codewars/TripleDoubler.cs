using System;

namespace Codewars
{
    public class TripleDoubler
    {
        public static int TripleDouble(long num1, long num2)
        {
            bool hasTripleDouble = false;

            bool isTriple = false;

            bool isDouble = false;

            char charToCheck = '#';

            var first = num1.ToString();

            var second = num2.ToString();

            if(first.Length < 3)
            { return 0; }

            for(int i = 2; i< first.Length && !isTriple; i++)
            {
                if(first[i] == first[i-1] && first[i] == first[i - 2])
                {
                    isTriple = true;
                    charToCheck = first[i];
                }

            }

            if(isTriple && charToCheck != '#')
            {
                //check for double in second number

                if(second.Length < 2)
                {
                    return 0;
                }

                for(int i = 1; i < second.Length && !isDouble; i++)
                {
                    if(second[i] == charToCheck && second[i] == second[i-1])
                    {
                        isDouble = true;
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}