using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.RDL
{
    public class SetPTTCommand : RdlCommand
    {
        public bool Enabled { get; }
        public SetPTTCommand(bool enabled)
        {
            Enabled = enabled;
        }
        public override string ToString()
        {
            return $"SetPTT({Enabled})";
        }
    }
}
