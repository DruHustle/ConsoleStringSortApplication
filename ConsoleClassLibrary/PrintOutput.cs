using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClassLibrary
{
    public class PrintOutput : IPrintOutput 
    {
        IExecution _applicationRuntime;

        public PrintOutput(IExecution applicationRuntime)
        {
            _applicationRuntime = applicationRuntime;
        }

        public void Message(string s)
        {
            Console.WriteLine(s);
        }

        public void MessageEnd(string s)
        {
            Console.WriteLine(s);
            _applicationRuntime.Pause();
        }
    }
}
