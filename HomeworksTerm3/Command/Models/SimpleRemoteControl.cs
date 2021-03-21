
namespace Command
{
    public class SimpleRemoteControl
    {
        Command onslot, offslot, button;
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
        public void ButtonPress(Command command)
        {
            button = command;
            button.execute();
        }
    }

}