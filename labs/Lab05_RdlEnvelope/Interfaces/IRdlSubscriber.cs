using Lab05_RdlEnvelope.RDL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.Interfaces
{
    internal interface IRdlSubscriber
    {
        void Receive(RdlEnvelope envelope);
    }
}
