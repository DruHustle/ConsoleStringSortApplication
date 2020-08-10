using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class Execution : IExecution
    {
        public void Pause()
        {
            Console.ReadKey();
        }

    }
}
