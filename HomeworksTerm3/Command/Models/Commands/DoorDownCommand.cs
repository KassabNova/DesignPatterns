
namespace Command
{
    public class DoorDownCommand : Command
    {
        GarageDoor door;
        public DoorDownCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void execute()
        {
            door.down();
        }
    }
}