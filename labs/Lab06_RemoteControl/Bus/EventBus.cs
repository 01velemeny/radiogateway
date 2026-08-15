using Lab06_RemoteControl.RDL;
using Lab06_RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_RemoteControl.Bus
{
    internal class EventBus
    {
        private readonly List<IRdlSubscriber> subscribers = new();
        public void Subscribe(IRdlSubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Publish(RdlEnvelope envelope)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Receive(envelope);
            }
        }
    }
}
