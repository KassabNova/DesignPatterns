namespace ChainOfCommandBank
{
    class Manager : AbstractHandler
    {
        string name { get; set; }
        public Manager(string name)
        {
            this.name = name;
        }
        public override object Handle(object withdrawal)
        {
            if ((withdrawal as int?) <= 9000)
            {
                return $" Request for {withdrawal} handled by {this.name}\n";
            }
            else
            {
                return $"No facility to handle a request of {withdrawal} \n";

            }
        }
    }
}