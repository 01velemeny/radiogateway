namespace Lab06_RemoteControl;

using System.Net;
using System.Net.Sockets;
using System.Text;
using Lab06_RemoteControl.Bus;
using Lab06_RemoteControl.Core;
using Lab06_RemoteControl.RDL;

internal class Program
{
    /*static void Main(string[] args)
    {
        string json = """
        {
            "source": "CLIENT",
            "destination": "CORE",
            "command": "SetPTT",
            "value": true
        }
        """;
        RdlEnvelope envelope = RdlJsonParser.Parse(json);
        Console.WriteLine($"Source: {envelope.Source}");
        Console.WriteLine($"Destination: {envelope.Destination}");

        if (envelope.Payload is SetPTTCommand ptt)
        {
            Console.WriteLine($"PTT: {ptt.Enabled}");
        }
    }
    */
    
    static async Task Main(string[] args)
    {
        var bus = new EventBus();
        var core = new GatewayCore(bus);

        bus.Subscribe(core);
        
        var listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("TCP server startded.");
        Console.WriteLine("Waiting for connection...");
        while (true)
        {
            using TcpClient client = await listener.AcceptTcpClientAsync();
            Console.WriteLine("Client connected.");

            using NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Received : {message}");

            
            RdlEnvelope envelope = RdlJsonParser.Parse(message);

            Console.WriteLine($"Source: {envelope.Source}");
            Console.WriteLine($"Destination: {envelope.Destination}");

            if (envelope.Payload is SetPTTCommand ptt)
            {
                Console.WriteLine($"PTT: {ptt.Enabled}");
            }
            bus.Publish( envelope );

            /*
            if (message.Trim() == "PING")
            {
                byte[] response = Encoding.UTF8.GetBytes("PONG\n");

                await stream.WriteAsync(response);
                Console.WriteLine("Sent: PONG");
            }
            */
            Console.WriteLine("Client disconnected.");
            Console.WriteLine("Waiting for connection...");
            
        }
    }
    
}
