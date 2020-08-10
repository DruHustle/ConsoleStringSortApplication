using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class MapString : IMapString
    {
        public string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}
