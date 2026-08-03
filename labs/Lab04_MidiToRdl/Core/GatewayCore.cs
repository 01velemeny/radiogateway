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
        public void Receive(RdlCommand command)
        {
            if (command is SetPTTCommand setPtt)
            {
                state.PTTButton = setPtt.Enabled;
                Console.WriteLine($"[CORE] PTT Button = {state.PTTButton}");
            }
        }
    }
}
