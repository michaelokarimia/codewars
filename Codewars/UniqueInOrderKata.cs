using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class UniqueInOrderKata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            

                var results = new List<T>();

                //loop through each element in list

                //greedy approach

                //O(n) time and space complexity

                T previous = default(T);

                foreach (T current in iterable)
                {
                    //if it is first, or if the previous is null add it to results
                    if (previous == null || previous.Equals(default(T)))
                    {
                        results.Add(current);
                    }
                    //if it is not equal to previous add it to results
                    else if (!current.Equals(previous))
                    {
                        results.Add(current);
                    }

                    previous = current;

                    //otherwise, do not add it.
                }


                return results;
            
        }
    }
}
