
namespace Command
{
    public class SimpleRemoteControl
    {
        Command onslot, offslot;
        public SimpleRemoteControl() { }
        public void setCommand(Command oncommand, Command offcommand)
        {
            onslot = oncommand;
            offslot = offcommand;

        }
        public void onButtonWasPressed()
        {
            onslot.execute();
        }
        public void offButtonWasPressed()
        {
            offslot.execute();
        }
    }

}