using System;

namespace Command
{
    public class Light
    {
        string location {get; set;}

        public Light(String location)
        {
            this.location = location;
        }

        public Light()
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