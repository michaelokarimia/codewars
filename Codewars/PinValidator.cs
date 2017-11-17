using System.Text.RegularExpressions;

namespace Codewars
{
    public class PinValidator
    {
        public static bool ValidatePin(string pin)
        {
            var pattern = "";

            if (pin.Length == 4)
            {
                pattern = @"\d{4}";
            }
            else if(pin.Length == 6)
            {
                pattern = @"\d{6}";
            }
            else
            { return false; }

           

            Regex regx = new Regex(pattern);

            return regx.IsMatch(pin);
        }
    }
}