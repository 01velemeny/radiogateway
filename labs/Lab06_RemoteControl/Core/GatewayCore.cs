using Lab06_RemoteControl.Bus;
using Lab06_RemoteControl.Core.State;
using Lab06_RemoteControl.Interfaces;
using Lab06_RemoteControl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_RemoteControl.Core
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
