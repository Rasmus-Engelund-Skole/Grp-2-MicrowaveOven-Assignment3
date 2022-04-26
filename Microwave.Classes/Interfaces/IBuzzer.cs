using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave.Classes.Interfaces
{
    public interface IBuzzer
    {
        public event EventHandler Buz;

        public void BuzzerSound();
    }
}
