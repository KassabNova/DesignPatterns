
namespace Command
{
    public class DoorDownCommand : Command
    {
        GarageDoor light;
        public DoorDownCommand(GarageDoor light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }
    }
}