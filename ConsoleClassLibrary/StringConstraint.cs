using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class StringConstraint : IStringConstraint
    {
        public string IgnorePanctuation(string s)
        {
            var sb = new StringBuilder();

            if (s != null)
            {
                foreach (char c in s)
                {
                    if (!char.IsPunctuation(c))
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
