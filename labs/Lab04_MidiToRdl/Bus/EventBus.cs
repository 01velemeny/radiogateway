using Lab04_MidiToRdl.Interfaces;
using Lab04_MidiToRdl.RDL;
using Lab04_MidiToRdl.Subscribers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Bus
{
    internal class EventBus
    {
        private readonly List<IRdlSubscriber> subscribers = new();
        public void Subscribe(IRdlSubscriber subscriber)
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
