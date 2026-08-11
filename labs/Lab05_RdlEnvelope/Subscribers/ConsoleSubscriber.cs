using Lab05_RdlEnvelope.Interfaces;
using Lab05_RdlEnvelope.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.Subscribers
{
    internal class ConsoleSubscriber : IRdlSubscriber
    {
        public void Receive(RdlEnvelope envelope)
        {
            if (envelope.Payload is SetPTTCommand pttCommand)
            {
                Console.WriteLine($"PTT: {pttCommand.Enabled}");
            }
            if (envelope.Payload is PTTStateChanged stateChanged)
            {
                Console.WriteLine($"PTT state event : {stateChanged.Value}");
            }
            //Console.WriteLine(
            //    $"[{envelope.Source} -> {envelope.Destination}] {envelope.Payload.GetType().Name}"
            //    );
        }
    }
}
