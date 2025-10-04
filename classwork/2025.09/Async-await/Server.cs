using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Async_await;

internal class Server {
    delegate void ConnectDelegate(Socket s);
    delegate void StartNetwork(Socket s);
    Socket? socket;
    IPEndPoint endP;

    public Server(string strArr, int port) {
        endP = new IPEndPoint(IPAddress.Parse(strArr), port);
    }

    async Task Server_Connect(Socket s) {
        await s.SendAsync(Encoding.ASCII.GetBytes(DateTime.Now.ToString()));
        s.Shutdown(SocketShutdown.Both);
        s.Close();
    }

    async Task Server_Begin(Socket s) {
        while (true) {
            try {
                while (s != null) {
                    var ns = await s.AcceptAsync();
                    Console.WriteLine($"{ns.RemoteEndPoint} connected");
                    await Server_Connect(ns);
                }
            } catch (SocketException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public async void Start() {
        if (socket != null) {
            return;
        }

        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(endP);
        socket.Listen(10);
        await Server_Begin(socket);
    }

    public void Stop() {
        if (socket != null) {
            try {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            } catch (SocketException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

