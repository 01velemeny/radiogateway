using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_RemoteControl.RDL
{
    internal class RdlEnvelope
    {
        public string Source { get; }
        public string Destination { get; }
        public RdlCommand Payload { get; }
        public RdlEnvelope(string source, string destination, RdlCommand payload)
        {
            Source = source;
            Destination = destination;
            Payload = payload;
        }
    }
}
