
namespace Command
{
    public class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }
    }
}