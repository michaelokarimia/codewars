using System;

namespace Codewars
{
    public class RGBConverter
    {
        public static string Rgb(int red, int green, int blue)
        {
            return string.Format("{0}{1}{2}", convertToHex(red), convertToHex(green), convertToHex(blue));
        }

        private static string convertToHex(int value)
        {
            //X2 means return two digits and zero pad if needed
            if (value < 0)
            {
                return 0.ToString("X2");
            }
            if (value > 255)
            {
                return 255.ToString("X2");
            }

            return value.ToString("X2");
        }
    }
}