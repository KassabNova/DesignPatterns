using ProjectTerm3;
using System;
namespace ChainOfCommandBank
{
    class Clerk : AbstractHandler
    {
        public string name { get; set; }

        public Clerk(string name)
        {
            this.name = name;
        }
        public override object Handle(object withdrawal, State account)
        {
            State backup = new State(account.accountName, account.money);
            Originator originator = new Originator(account);
            Caretaker caretaker = new Caretaker(originator);
            caretaker.Backup();
            if ((withdrawal as int?) <= 1000)
            {
                account.money = account.money - (int)withdrawal;
                if ((withdrawal as int?) > account.money)
                {
                    Console.WriteLine("Withdrawal exceeds funds. Restoring previous state");
                    caretaker.Undo();
                }
                return $" Request for {withdrawal} handled by {this.name}\n";
            }
            else
            {
                return base.Handle(withdrawal);
            }
        }
    }
}