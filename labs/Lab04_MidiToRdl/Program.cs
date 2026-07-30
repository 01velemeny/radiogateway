using Melanchall.DryWetMidi.Multimedia;
using Melanchall.DryWetMidi.Core;
namespace Lab04_MidiToRdl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MIDI Event Monitor ===");
            Console.WriteLine();
            try
            {
                var inputDevice = InputDevice.GetByName("CTR2-Dial");
                Console.WriteLine("Device found:");
                inputDevice.EventReceived += InputDevice_EventReceived;
                inputDevice.StartEventsListening();
                Console.WriteLine();
                Console.WriteLine("Listening... Press ENTER to exit.");
                Console.ReadLine();
                Console.WriteLine(inputDevice.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Device not found.");
            }

            Console.WriteLine("Hello, World!");
        }

        private static void InputDevice_EventReceived(object? sender, MidiEventReceivedEventArgs e)
        {
           if (e.Event is NoteOnEvent)
            {
                var command = new SetPTTCommand(true);
                Console.WriteLine(command);
            }
        }
    }
    public class SetPTTCommand
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
