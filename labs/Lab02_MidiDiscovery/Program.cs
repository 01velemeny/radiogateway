using Melanchall.DryWetMidi.Multimedia;
namespace Lab02_MidiDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MIDI Input Devices ===");
            Console.WriteLine();
            foreach (var inputDevice in InputDevice.GetAll())
            {
                Console.WriteLine(inputDevice.Name);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
