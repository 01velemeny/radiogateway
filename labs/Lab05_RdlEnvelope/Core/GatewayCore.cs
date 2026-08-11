using Lab05_RdlEnvelope.Bus;
using Lab05_RdlEnvelope.Core.State;
using Lab05_RdlEnvelope.Interfaces;
using Lab05_RdlEnvelope.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.Core
{
    internal class GatewayCore : IRdlSubscriber
    {
        private readonly EventBus bus;
        private readonly GatewayState state = new();
        public GatewayCore(EventBus bus) 
        {
            this.bus = bus;
        }
        public void Receive(RdlEnvelope envelope)
        {
            if (envelope.Destination == "CORE")
            {
                Console.WriteLine("Core received the envelope.");
                if (envelope.Payload is SetPTTCommand pttCommand)
                {
                    if (state.PTT != pttCommand.Enabled)
                    {
                        state.PTT = pttCommand.Enabled;
                        var stateEvent = new PTTStateChanged(state.PTT);
                        var envelopeNew = new RdlEnvelope(
                            "CORE",
                            "GENERAL",
                            stateEvent
                        );
                        bus.Publish(envelope);
                        Console.WriteLine(
                            $"PTT state changed - PTT: {state.PTT}"
                        );
                    }
                }
            }
        }
    }
}
