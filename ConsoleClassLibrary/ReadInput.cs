using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClassLibrary
{
    public class ReadInput : IReadInput
    {
        public string StringValue()
        {
            string input = Console.ReadLine().Trim();
            return input;
        }
    }
}
