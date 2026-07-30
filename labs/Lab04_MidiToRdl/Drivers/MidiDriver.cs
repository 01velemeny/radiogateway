using Lab04_MidiToRdl.RDL;
using Melanchall.DryWetMidi.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_MidiToRdl.Drivers
{
    public class MidiDriver
    {
        public RdlCommand? Translate(MidiEvent midiEvent)
        {
            if (midiEvent is NoteOnEvent)
            {
                return new SetPTTCommand(true);
            }
            return null;
        }
    }
}
