using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.RDL
{
    internal class SetTransmitCommand : RdlCommand
    {
        public bool Enabled { get; }
        public SetTransmitCommand(bool enabled)
        {
            Enabled = enabled;
        }
        public override string ToString()
        {
             return $"SetTrasmit({Enabled})";   
        }
    }
}
