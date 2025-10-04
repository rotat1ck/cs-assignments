using System.Net;
using System.Net.Sockets;

namespace Async_await;
    
internal class Program {
    static void Main(string[] args) {
        Server s = new Server("127.0.0.1", 1024);
        s.Start();
        Console.Read();
        s.Stop();
    }
}

