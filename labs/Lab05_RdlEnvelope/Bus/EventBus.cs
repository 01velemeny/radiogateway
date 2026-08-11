using Lab05_RdlEnvelope.RDL;
using Lab05_RdlEnvelope.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.Bus
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
