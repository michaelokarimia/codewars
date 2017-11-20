using System;
using System.Collections.Generic;

namespace Codewars
{
    public class PrimeDecomp
    {
        public static string factors(int lst)
        {
            string result = "";
            if (lst < 2)
                return "0";
            if (lst == 2)
                return "(2)";

       

            bool isDecomposed = false;

            var runningTotal = lst;

            var currentPrimeDivisionCount = 0;

            int i = 0;

            var sieve = SieveOfEratothenes(lst);

            int[] primes = GetOnlyThePrimes(sieve);

            var currentPrime = 2;
            var previousPrime = 1;

            while (!isDecomposed)
            {
                currentPrime = primes[i];

                //check if we can divide by current prime
                if (runningTotal % currentPrime == 0)
                {
                    runningTotal = runningTotal / currentPrime;
                    currentPrimeDivisionCount++;
                    
                }
                else 
                {

                    //finished with this prime 

                    if (currentPrimeDivisionCount > 0)
                    {
                        //append it to the result string if it's been divided
                        result += string.Format("({0}{1})", currentPrime, currentPrimeDivisionCount > 1 ? "**" + currentPrimeDivisionCount : "");
                    }

                    currentPrimeDivisionCount = 0;

                    //next prime
                    i++;
                }

                if (runningTotal == 1)
                {
                    //append the last prime
                    result += string.Format("({0}{1})", currentPrime, currentPrimeDivisionCount > 1 ? "**" + currentPrimeDivisionCount : "");
                    isDecomposed = true;
                }

                previousPrime = currentPrime;
            }

          

            return result;
    
        }

        private static int[] GetOnlyThePrimes(bool[] sieve)
        {
            var resultList = new List<int>();

            for(int i = 0; i < sieve.Length; i++)
            {
                if(sieve[i])
                {
                    resultList.Add(i);
                }
            }

            return resultList.ToArray();
        }

        static int GetNextPrimeInSieve(bool[] sieve, int current)
        {
            for (int i = current+1; i < sieve.Length; i++)
            {
                if(sieve[i] == true)
                {
                    return i;
                }
            }


            return 2;
        }


        /// <summary>
        /// Returns and array of bools, each item represents every integer from 0 to the max number in order.
        /// If the bool is true, then it is a prime.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        static bool[] SieveOfEratothenes(int max)
        {
            bool[] flags = new bool[max + 1];

            int count = 0;

            //set all flags to true apart from 0 and 1
            for(int i = 2; i < flags.Length; i++)
            {
                flags[i] = true;
            }

            int prime = 2;

            while(prime <= Math.Sqrt(max))
            {
                //squareRoot optimisation saves us a lot of time

                //cross off the remaining multipes of the prime
                crossOff(flags, prime);

                //get the next value which is set to true and cross it off

                prime = getNextPrime(flags, prime);
                

            }


            return flags;
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
    }
}