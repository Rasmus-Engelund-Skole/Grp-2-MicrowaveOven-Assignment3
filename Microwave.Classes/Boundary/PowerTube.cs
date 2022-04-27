using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private int Power{ get; set; }

        private IOutput myOutput;

        private bool IsOn = false;

        public PowerTube(IOutput output, int MaximumPower)
        {
            myOutput = output;

            if (MaximumPower < 50)
                throw new ArgumentOutOfRangeException("MaximumPower", MaximumPower, "The Maximum Power must be 50 watts or higher");
            else
            Power = MaximumPower;
        }

        public void TurnOn(int power)
        {
            if (power < 1 || Power < power)
            {
                throw new ArgumentOutOfRangeException("power", power, "Must be between 1 and " + Power + " (incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}