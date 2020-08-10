using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class SortString : ISortString
    {
        public string Ascending(string s)
        {
            
            char[] stringArray = s.ToCharArray();
            Array.Sort(stringArray);
            string sortedString = new string(stringArray);

            return sortedString;
        }

    }
}
