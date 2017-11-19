using System;

namespace Codewars
{
    public class PrimeDecomp
    {
        public static string factors(int lst)
        {
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

            string result = "";
            if (lst == 1)
                return "0";

            int i = 0;

            bool isDecomposed = false;

            var runningTotal = lst;

            var currentPrimeDivisionCount = 0;

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



     
    }
}

//"(2**2)(3**3)(5)(7)(11**2)(17)\"  
//"2*2*3*3*3*5*7*11*11*17\"