using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Validation : IValidation
    {
        public bool ValidateString(string s)
        {
            bool hasSpecialChar = false;
            string validated = string.Empty;
            bool isValid = false;

            char[] specialCharacters = { '~', '#', '$', '%', '^', '&', '+', '\\', '|', '`', '<', '>','*' };

            if (!(s == null))
            {
                if (s.IndexOfAny(specialCharacters) >= 0)
                {
                    hasSpecialChar = true;
                }

                if ((!s.Any(c => char.IsDigit(c))) && (!string.IsNullOrWhiteSpace(s)) && (!hasSpecialChar))
                {
                    validated = s;
                    isValid = true;
                }             

            }
            return isValid;

        }

    }
}
