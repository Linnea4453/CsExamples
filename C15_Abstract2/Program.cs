using System;
using C15_Abstract2.Models;

namespace C15_Abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempsensor = new TempSensor();
            Console.WriteLine(tempsensor.CreateFromConnectionsString("Hostname=iot.azure.com"));
            Console.WriteLine();

            var command = tempsensor.ReciveMessage();
            Console.WriteLine($"Recived Command: {command}");

            switch (command)
            {
                case "get":
                    tempsensor.SendMessage("temperature = 12");
                    break;

                case "reset":
                    tempsensor.SendMessage("device has been reset.");
                    break;

                default:
                    tempsensor.SendMessage("command not implemented");
                    break;

            }
        }
    }
}
