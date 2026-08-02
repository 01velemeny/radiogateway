using Lab04_MidiToRdl.Interfaces;
using Lab04_MidiToRdl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Subscribers
{
    internal class LoggerSubscriber : IRdlSubscriber
    {
        public void Receive(RdlCommand command)
        {
            Console.WriteLine("[LOG]" + command);
        }
    }
}
