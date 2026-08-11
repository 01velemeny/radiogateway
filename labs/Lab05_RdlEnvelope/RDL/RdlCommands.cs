using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.RDL
{
    public class SetPTTCommand : RdlCommand
    {
        public bool Enabled { get; }
        public SetPTTCommand(bool enabled)
        {
            Enabled = enabled;
        }
    }
    public class SetTransmitCommand : RdlCommand
    {
        public bool Enabled { get; }
        public SetTransmitCommand(bool enabled)
        {
            Enabled = enabled;
        }
    }
}
