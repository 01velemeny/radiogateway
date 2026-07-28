using Melanchall.DryWetMidi.Multimedia;
using Melanchall.DryWetMidi.Core;
using System.Linq.Expressions;
namespace Lab03_MidiEvents
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
            Console.WriteLine(e.Event);
        }
    }
}
