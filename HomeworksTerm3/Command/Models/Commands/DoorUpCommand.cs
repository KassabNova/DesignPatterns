
namespace Command
{
    public class DoorUpCommand : Command
    {
        GarageDoor light;
        public DoorUpCommand(GarageDoor light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }
    }
}