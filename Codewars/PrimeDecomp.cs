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

            int i = 0;

            bool isDecomposed = false;

            var runningTotal = lst;

            var currentPrimeDivisionCount = 0;

            int[] primes = new int[] { };

            primes = generatePrimesUpTo(lst);

            while (!isDecomposed)
            {
                //start with the smallest prime first
                var prime = primes[i];

                //check if we can divide by current prime
                if(runningTotal % prime == 0)
                {
                    runningTotal = runningTotal / prime;
                    currentPrimeDivisionCount++;
                    
                }
                else 
                {

                    //finished with this prime 

                    if (currentPrimeDivisionCount > 0)
                    {
                        //append it to the result string if it's been divided
                        result += string.Format("({0}{1})", prime, currentPrimeDivisionCount > 1 ? "**" + currentPrimeDivisionCount : "");
                    }

                    currentPrimeDivisionCount = 0;
                    i++;
                }

                if (runningTotal == 1)
                {
                    //append the last prime
                    result += string.Format("({0}{1})", prime, currentPrimeDivisionCount > 1 ? "**" + currentPrimeDivisionCount : "");
                    isDecomposed = true;
                }
            }

          

            return result;
    
        }

        private static int[] generatePrimesUpTo(int max)
        {
            var arry = new List<int>();

            if (max < 2)
                return arry.ToArray();
            
            for(int i = 2; i < max; i++)
            {
                if (isPrime(i))
                    arry.Add(i);
            }

            return arry.ToArray();
        }


        static bool isPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

//"(2**2)(3**3)(5)(7)(11**2)(17)\"  
//"2*2*3*3*3*5*7*11*11*17\"