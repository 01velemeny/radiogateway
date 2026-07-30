using Lab04_MidiToRdl.Drivers;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Multimedia;
namespace Lab04_MidiToRdl
{
    internal class Program
    {
        private static readonly MidiDriver driver = new MidiDriver();
        static void Main(string[] args)
        {
            Console.WriteLine("=== MIDI Event Monitor ===");
            Console.WriteLine();
            var driver = new MidiDriver();
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
            var command = driver.Translate(e.Event);
            if (command != null)
            {
                Console.WriteLine(command);
            }
        }
    }
}
