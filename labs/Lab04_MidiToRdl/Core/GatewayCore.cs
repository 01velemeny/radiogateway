using Lab04_MidiToRdl.Bus;
using Lab04_MidiToRdl.Interfaces;
using Lab04_MidiToRdl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Core
{
    internal class GatewayCore : IRdlSubscriber

    {
        private readonly GatewayState state = new();
        private readonly EventBus bus;
        public GatewayCore(EventBus bus)
        {
            this.bus = bus;
        }
        public void Receive(RdlCommand command)
        {
            if (command is SetPTTCommand setPtt)
            {
                state.PTTButton = setPtt.Enabled;
                Console.WriteLine($"[CORE] PTT Button = {state.PTTButton}");
                var txCommand = new SetTransmitCommand(state.PTTButton);
                bus.Publish(txCommand);
            }
        }
    }
}
