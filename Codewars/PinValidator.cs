using System.Text.RegularExpressions;

namespace Codewars
{
    public class PinValidator
    {
        public static bool ValidatePin(string pin)
        {
            var pattern = @"^(\d{4}|\d{6})$";

            Regex regx = new Regex(pattern);

            return regx.IsMatch(pin);
        }
    }
}