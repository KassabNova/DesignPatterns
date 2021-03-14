using System;
using ChainOfCommandBeverages;
using ChainOfCommandBank;
namespace ChainOfCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //This first snippet shows the tasks from the template. 
            bool wantsCondiments;
            Console.WriteLine("Hello World!");
            CoffeeWithHook coffeHook=new CoffeeWithHook();
            Console.WriteLine("\nMaking coffe...");
            wantsCondiments = coffeHook.customerWantsCondiments();
            coffeHook.prepareRecipe(wantsCondiments);
            //Beverage 2
            TeaWithHook teaHook=new TeaWithHook();
            Console.WriteLine("\nMaking tea...");
            wantsCondiments = teaHook.customerWantsCondiments();
            teaHook.prepareRecipe(wantsCondiments);
            //Beverage 3
            CocoaWithHook cocoaHook=new CocoaWithHook();
            Console.WriteLine("\nMaking tea...");
            wantsCondiments = cocoaHook.customerWantsCondiments();
            cocoaHook.prepareRecipe(wantsCondiments);

            //This second snippet shows the tasks for the bank part. 


            // The other part of the client code constructs the actual chain.
            // List<Supervisor> supervisors = new List<Supervisor>
            // ({

            // });
            Console.WriteLine("\nWelcome to Citibank");

            Clerk clerk = new Clerk("Clerk 1");
            Supervisor supervisor = new Supervisor("Supervisor 1");
            Manager manager = new Manager("Manager 1");
            clerk.SetNext(supervisor);
            supervisor.SetNext(manager);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Clerk > Supervisor > Manager\n");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(1000)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(2000)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(5000)}");
            Console.WriteLine($"Approached {clerk.name}. {clerk.Handle(15000)}");

            // Console.WriteLine("Subchain: Squirrel > Dog\n");
            // Client.ClientCode(squirrel);
        }
    }
}
