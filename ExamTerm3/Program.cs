using System;
using System.Collections.Generic;
namespace ExamTerm3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom mediator = new ChatRoom();

            List<User> users = new List<User>
            {
                new User("John", mediator),
                new User("Jane", mediator),
                new User("Jimy", mediator)
            };
            User john = users[0];
            User jane = users[1];
            User jimy = users[2];
            john.Send(john, jane, "Hi there!");
            jane.Send(jane, john, "Hey!");
            jimy.SendAll(jimy, users, "Hey!");
        }
    }
}
