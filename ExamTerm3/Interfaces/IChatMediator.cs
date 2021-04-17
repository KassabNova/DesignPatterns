using System;
using System.Collections.Generic;
namespace ExamTerm3
{
    interface IChatMediator
    {
        void SendMessage(User sender, User receiver, string message);
        void ReceiveMessage(User sender, User receiver, string message);
        void BroadcastMessage(User sender, List<User> receivers, string message);
    }
}