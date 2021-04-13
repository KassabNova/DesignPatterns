using System;
using ChainOfCommandBank;
namespace ProjectTerm3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nWelcome to Citibank");

            Clerk clerk = new Clerk("Clerk 1");
            Supervisor supervisor = new Supervisor("Supervisor 1");
            Manager manager = new Manager("Manager 1");
            clerk.SetNext(supervisor);
            supervisor.SetNext(manager);

            State account = new State("Ricky Ricon Bank account", 42069.69);
            State account2 = new State("Student Bank account", 0.69);
            State account3 = new State("Fer's Bank account", 123.45);
            Console.WriteLine("Chain: Clerk > Supervisor > Manager\n");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(1000, account)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(1000, account2)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(2000, account2)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(5000, account3)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(15000)}");

        }
    }
}
