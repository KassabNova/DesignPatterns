
namespace Command
{
    public class DoorStopCommand : Command
    {
        GarageDoor door;
        public DoorStopCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void execute()
        {
            door.stop();
        }
    }
}