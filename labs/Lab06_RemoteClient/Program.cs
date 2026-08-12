namespace Lab06_RemoteClient;

using System.Net.Sockets;
using System.Text;

internal class Program
{
    static async Task Main(string[] args)
    {
        using TcpClient client = new TcpClient();
        await client.ConnectAsync("127.0.0.1", 5000);
        Console.WriteLine("Connected to server.");

        using NetworkStream stream = client.GetStream();
        byte[] message = Encoding.UTF8.GetBytes("PING\n");
        await stream.WriteAsync(message);
        Console.WriteLine("Sent: PING");

        byte[] buffer = new byte[1024];
        int bytesRead = await stream.ReadAsync(buffer);
        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine($"Received: {response.Trim()}");
    }
}

