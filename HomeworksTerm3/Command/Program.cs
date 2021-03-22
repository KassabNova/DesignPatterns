using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light("Bathroom");
            Light light2 = new Light("Kitchen");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOnCommand lightOn2 = new LightOnCommand(light2);
            LightOffCommand lightOff = new LightOffCommand(light);
            LightOffCommand lightOff2 = new LightOffCommand(light2);
            
            remote.setCommand(lightOn, lightOff);
            remote.onButtonWasPressed();
            remote.setCommand(lightOn2, lightOff2);
            remote.onButtonWasPressed();
            //turn off
            remote.offButtonWasPressed();
            remote.setCommand(lightOn, lightOff);
            remote.offButtonWasPressed();

            ComplexRemoteControl complexRemote = new ComplexRemoteControl();

            GarageDoor door = new GarageDoor();
            DoorUpCommand openDoor = new DoorUpCommand(door);
            DoorDownCommand closeDoor = new DoorDownCommand(door);
            DoorStopCommand stopDoor = new DoorStopCommand(door);

            complexRemote.addCommand("Open", openDoor);
            complexRemote.addCommand("Close", closeDoor);
            complexRemote.addCommand("Stop", stopDoor);

            complexRemote.ButtonPress("Open");
            complexRemote.ButtonPress("Close");
            complexRemote.ButtonPress("Open");
            complexRemote.ButtonPress("Stop");

        } 
    }
}
