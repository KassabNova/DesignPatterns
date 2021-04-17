using System;
using System.Collections.Generic;
using System.Linq;
namespace ExamTerm3
{

    class ChatRoom : IChatMediator
    {
        public void SendMessage(User sender, User receiver, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("MMMM dd, H:mm")} [Sending to {receiver.GetName()}]");
            ReceiveMessage(sender, receiver, message);
        }
        public void ReceiveMessage(User sender, User receiver, string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString("MMMM dd, H:mm")} [{sender.GetName()}]:{message}");
        }
        public void BroadcastMessage(User sender, List<User> receivers, string message)
        {
            receivers
            .Where(user => user.GetName()!= sender.GetName())
            .ToList()
            .ForEach( receiver =>  SendMessage(sender, receiver, message));
        }
    }
}