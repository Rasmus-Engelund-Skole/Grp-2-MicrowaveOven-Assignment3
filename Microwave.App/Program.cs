using System;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;

namespace Microwave.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();
            Door door = new Door();

            Output output = new Output();

            Display display = new Display(output);
            int MaximumPower = 700;
            PowerTube powerTube = new PowerTube(output, MaximumPower);

            Buzzer buzzer = new Buzzer(output);

            Light light = new Light(output);

            Microwave.Classes.Boundary.Timer timer = new Timer();

            CookController cooker = new CookController(timer, display, powerTube, buzzer);

            UserInterface ui = new UserInterface(powerButton, timeButton, startCancelButton, door, display, light, cooker, MaximumPower);

            // Finish the double association
            cooker.UI = ui;

            // Simulate a simple sequence

            for (int i = 0; i < 15; i++)
                powerButton.Press();

            timeButton.Press();

            startCancelButton.Press();

            // The simple sequence should now run

            System.Console.WriteLine("When you press enter, the program will stop");
            // Wait for input

            System.Console.ReadLine();
        }
    }
}
