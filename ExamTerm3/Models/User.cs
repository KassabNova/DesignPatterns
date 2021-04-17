using System;
using System.Collections.Generic;
namespace ExamTerm3
{
    class User
    {
        private string mName;
        private IChatMediator mChatRoom;

        public User(string name, IChatMediator chatroom)
        {
            mChatRoom = chatroom;
            mName = name;
        }

        public string GetName()
        {
            return mName;
        }

        public void Send(User sender, User receiver, string message)
        {
            mChatRoom.SendMessage(sender, receiver, message);
        }
        public void SendAll(User sender, List<User> receivers, string message)
        {
            mChatRoom.BroadcastMessage(sender,receivers, message);
        }
    }
}