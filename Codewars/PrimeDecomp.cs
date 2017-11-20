using System;

namespace Codewars
{
    public class PrimeDecomp
    {
        public static string factors(int max)
        {
            string result = "";
            if (max < 2)
                return "0";

            var maxfactor = CalcMaxfactor(max);

            bool[] flags = new bool[maxfactor + 1];

            int count = 0;

            //set all flags to true apart from 0 and 1
            for(int i = 2; i < flags.Length; i++)
            {
                flags[i] = true;
            }

            int prime = 2;

            var runningTotal = max;
            var currentPrimeDivisionCount = 0;

            var primesFound = false;



            double root = Math.Sqrt(max);
            while (prime <= root)
            {

                //squareRoot optimisation saves us a lot of time

                //cross off the remaining multipes of the prime
                crossOff(flags, prime);

                //process this prime
                currentPrimeDivisionCount = 0;
                //check if we can divide by current prime, and keep dividing it
                while (runningTotal % prime == 0)
                {
                    runningTotal = runningTotal / prime;
                    currentPrimeDivisionCount++;
                    primesFound = true;
                }
                if (currentPrimeDivisionCount > 0)
                {
                    //append it to the result string if it's been divided
                    result += string.Format("({0}{1})", prime, currentPrimeDivisionCount > 1 ? "**" + currentPrimeDivisionCount : "");
                }
                //get the next value which is set to true and cross it off
                prime = getNextPrime(flags, prime);
            }

            if (!primesFound)
            {
                return string.Format("({0})", max);
            }


            return result;
        }

        private static void crossOff(bool[] flags, int prime)
        {
            /* Cross off remaining multiples of prime. Start wihth prime * prime
             * because we if we have a k * prime, where k < prime, this value would have
             * already been cross off on a previous iteration */

            for(int i = prime * prime; i < flags.Length; i +=prime)
            {
                //increment by our prime for each iteration and cross it off
                flags[i] = false;
            }
        }


        private static int getNextPrime(bool[] flags, int prime)
        {
            int next = prime + 1;
            
            while(next < flags.Length && !flags[next])
            {
                next++;
            }

            return next;
        }


        public static int CalcMaxfactor(int n)
        {
            int k = 2;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    n /= k;
                }
                else
                {
                    ++k;
                }
            }

            return n;
        }
    }
}