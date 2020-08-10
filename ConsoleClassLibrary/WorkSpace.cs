using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class WorkSpace : IWorkSpace
    {
        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}
