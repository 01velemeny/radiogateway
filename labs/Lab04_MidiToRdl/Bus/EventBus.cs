using Lab04_MidiToRdl.RDL;
using Lab04_MidiToRdl.Subscribers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Bus
{
    internal class EventBus
    {
        private readonly List<ConsoleSubscriber> subscribers = new List<ConsoleSubscriber>();
        public void Subscribe(ConsoleSubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Publish(RdlCommand command)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Receive(command);
            }
        }
    }
}
