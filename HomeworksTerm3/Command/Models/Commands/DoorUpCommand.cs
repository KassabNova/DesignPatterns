
namespace Command
{
    public class DoorUpCommand : Command
    {
        GarageDoor door;
        public DoorUpCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void execute()
        {
            door.up();
        }
    }
}