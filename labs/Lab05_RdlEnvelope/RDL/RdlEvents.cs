using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_RdlEnvelope.RDL
{
    internal class PTTStateChanged : RdlCommand
    {
        public bool Value { get; }
        public PTTStateChanged(bool value)
        {
            Value = value;
        }
    }
}
