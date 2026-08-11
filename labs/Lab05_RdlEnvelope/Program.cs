using Lab05_RdlEnvelope.Bus;
using Lab05_RdlEnvelope.Core;
using Lab05_RdlEnvelope.RDL;
using Lab05_RdlEnvelope.Subscribers;

namespace Lab05_RdlEnvelope
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var bus = new EventBus();
           var consoleSubscriber = new ConsoleSubscriber();
           var core = new GatewayCore(bus);
           bus.Subscribe(core);
           bus.Subscribe(consoleSubscriber);
           TestEnvelopeFlow(bus);
        
           //Console.WriteLine("Hello, World!");
        }
        static void TestEnvelopeFlow(EventBus bus)
        {
           //var command = new SetPTTCommand(true);
           //var envelope = new RdlEnvelope(
           //     "MIDI",
           //     "CORE",
           //     command
           //     );
           var pttOn = new RdlEnvelope(
                "MIDI",
                "CORE",
                new SetPTTCommand(true)
                );
           var pttOff = new RdlEnvelope(
                "MIDI",
                "CORE",
                new SetPTTCommand(false)
                );
           var pttOnAgain = new RdlEnvelope(
                "MIDI",
                "CORE",
                new SetPTTCommand(true)
                );
           //var transmitCommand = new SetTransmitCommand(true);
           //var transmitEnvelope = new RdlEnvelope(
           //     "CORE",
           //     "RADIO-A",
           //     transmitCommand
           //     );
           //bus.Publish(envelope);
           //bus.Publish(transmitEnvelope);
           bus.Publish(pttOn);
           bus.Publish(pttOff);
           bus.Publish(pttOff);
           bus.Publish(pttOnAgain);
        }
    }
}
