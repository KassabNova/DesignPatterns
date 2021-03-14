namespace ChainOfCommandBank
{
    class Clerk : AbstractHandler
    {
        public string name { get; set; }

        public Clerk(string name)
        {
            this.name = name;
        }
        public override object Handle(object withdrawal)
        {
            if ((withdrawal as int?) <= 1000)
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