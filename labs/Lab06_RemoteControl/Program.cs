namespace Lab06_RemoteControl;

using System.Net;
using System.Net.Sockets;
using System.Text;

internal class Program
{
    static async Task Main(string[] args)
    {
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

            if (message.Trim() == "PING")
            {
                byte[] response = Encoding.UTF8.GetBytes("PONG\n");

                await stream.WriteAsync(response);
                Console.WriteLine("Sent: PONG");
            }
            Console.WriteLine("Client disconnected.");
            Console.WriteLine("Waiting for connection...");
        }
    }
}
