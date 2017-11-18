using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            // if n==0, then return an array of length 1, containing only a 0

            if (n == 0)
                return new double[1] { 0};


            var sequence = new List<Double>();

            sequence.AddRange(signature);

            var timesToRepeat = n;

            while (timesToRepeat > (signature.Length))

            {
                var summedValue = sequence[sequence.Count - 1] + sequence[sequence.Count - 2] + sequence[sequence.Count - 3];

                sequence.Add(summedValue);

                timesToRepeat--;
            }

            var tempList = sequence.Take(n).ToArray();


            return tempList;
        }
    }
}
