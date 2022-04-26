using Microwave.Classes.Interfaces;
using System;

namespace Microwave.Classes.Boundary
{
    public class Output : IOutput
    {
        public void OutputLine(string line)
        {
            System.Console.WriteLine(line);
        }
        
        public void Beep()
        {
            Console.Beep();
        }

    }
}