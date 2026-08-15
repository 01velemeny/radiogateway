using Lab06_RemoteControl.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_RemoteControl.Interfaces
{
    internal interface IRdlSubscriber
    {
        void Receive(RdlEnvelope envelope);
    }
}
