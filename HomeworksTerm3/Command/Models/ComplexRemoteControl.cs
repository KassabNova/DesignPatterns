using System;
using System.Collections.Generic;
namespace Command
{
    public class ComplexRemoteControl
    {
        public Dictionary<string, Command> commands = new Dictionary<string, Command>();
        public ComplexRemoteControl() { }
        public void setCommand(String commandName, Command command)
        {
            commands.Add(commandName, command);
        }
        public void ButtonPress(string commandName)
        {
            Command button = commands[commandName];
            button.execute();
        }
    }

}