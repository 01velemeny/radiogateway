using Lab04_MidiToRdl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Interfaces
{
    internal interface IRdlSubscriber
    {
        void Receive(RdlCommand command);
    }
}
