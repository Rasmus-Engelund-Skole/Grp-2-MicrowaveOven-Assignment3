using Microwave.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave.Classes.Boundary
{
    public class Buzzer : IBuzzer
    {
        public event EventHandler Buz;

        public void BuzzerSound()
        {
            Buz?.Invoke(this, EventArgs.Empty);
        }
    }

}
