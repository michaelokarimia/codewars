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

            foreach(T current in iterable)
            {
                //if it is first, add it to results
                if (previous.Equals(default(T)))
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


            //var theType = typeof(T);

            //if (typeof(T).Equals(typeof(string)))
            //{
            //    results = results.ToArray();
            //}

            return results;
        }
    }
}
