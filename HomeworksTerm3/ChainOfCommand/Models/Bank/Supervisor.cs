namespace ChainOfCommandBank
{
    class Supervisor : AbstractHandler
    {
        string name { get; set; }
        public Supervisor(string name)
        {
            this.name = name;
        }
        public override object Handle(object withdrawal)
        {
            if ((withdrawal as int?) <= 4000)
            {
                return $" Request for {withdrawal} handled by {this.name}\n";
            }
            else
            {
                return base.Handle(withdrawal);
            }
        }
    }
}