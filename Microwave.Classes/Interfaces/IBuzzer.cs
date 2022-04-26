using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave.Classes.Interfaces
{
    public class IBuzzer
    {
        public event EventHandler Buzzer;

        public void BuzzerSound()
        {
            Buzzer?.Invoke(this, EventArgs.Empty);
        }

    }
}
