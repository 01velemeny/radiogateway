using Lab04_MidiToRdl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Subscribers
{
    internal class ConsoleSubscriber
    {
        public void Receive(RdlCommand command)
        {
            Console.WriteLine(command);
        }
    }
}
