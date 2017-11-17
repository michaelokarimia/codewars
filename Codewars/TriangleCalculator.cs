using System;

namespace Codewars
{
    public class TriangleCalculator
    {
        /**
             You are given two angles (in degrees) of a triangle.
     
             Write a function to return the 3rd.

             Note: only positive integers will be tested.
       */

        internal static void Run()
        {
            Console.WriteLine("Enter the first angle of the triangle");

            var angleOne = Console.ReadLine();

            Console.WriteLine("Enter the second angle of the triangle");

            var angleTwo = Console.ReadLine();

            var thirdAngle = TriangleCalculator.Compute(angleOne, angleTwo);

            if (thirdAngle > 0)
            {
                Console.WriteLine("Given a triange with the first angle being {0}, " +
                    "and the second angle being {1}, \n Then the third Angle must be: {2}",
                    angleOne, angleTwo, thirdAngle);
            }
            else
            {
                Console.WriteLine("Angles provided to do not add up to 180, either shape is not a triangle or it exists in Non-Euclidean space");
            }
            
        }

        internal static int Compute(string angleOne, string angleTwo)
        {
            int firstAngle = -1;
            int secondAngle = -1;

            if (!int.TryParse(angleOne, out firstAngle))
            {
                throw new InvalidCastException();
            }

            if(!int.TryParse(angleTwo, out secondAngle ))
            {
                throw new InvalidCastException();
            }

            var result = 180 - firstAngle - secondAngle;

            return result;
        }
    }
}
