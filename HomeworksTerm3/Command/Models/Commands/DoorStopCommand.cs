
namespace Command
{
    public class DoorStopCommand : Command
    {
        GarageDoor light;
        public DoorStopCommand(GarageDoor light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }
    }
}