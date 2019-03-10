using System;

namespace MediatorRealExample
{
    public class Participant
    {
         public Participant(string name)
         {
             Name = name;
         }

        public virtual string Name { get; private set;}

        public virtual Chatroom Chatroom { get; set; }

        public virtual void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: {message}");
        }
    }
}