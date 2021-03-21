using System;

namespace Command
{
    public class GarageDoor
    {
        string location {get; set;}

        public GarageDoor(String location)
        {
            this.location = location;
        }

        public GarageDoor()
        {
            this.location = "Default";
        }

        public void on()
        {
            Console.WriteLine(location + " light is on");
        }

        public void off()
        {
            Console.WriteLine(location + " light is off");
        }
    }

}