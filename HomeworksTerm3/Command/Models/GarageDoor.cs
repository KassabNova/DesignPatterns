using System;

namespace Command
{
    public class GarageDoor
    {
        string state {get; set;}

        public GarageDoor(String state)
        {
            this.state = state;
        }

        public GarageDoor()
        {
            this.state = "Default";
        }

        public void up()
        {
            Console.WriteLine($"Door was in a {state} state and is now going up");
            this.state="opening";
        }
        public void down()
        {
            Console.WriteLine($"Door was in a {state} state and is nowgoing down");
            this.state="closing";
        }
        public void stop()
        {
            Console.WriteLine($"Door was in a {state} state and is now stopped");
            this.state="stopped";
        }
    }

}