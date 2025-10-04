namespace sockets;

using System.Net;
using System.Net.Sockets;
    
class Program {
    static async Task Main(string[] args) {
        // Получение локального адресса

        IPAddress.TryParse("127.0.0.1", out IPAddress? ip1);
        //IPAddress.Loopback localhost
        Console.WriteLine(ip1.AddressFamily);

        IPEndPoint endPoint = new IPEndPoint(ip1, 8080);
        Console.WriteLine(endPoint);

        string uri = "https://ya.ru";
        Uri myuri = new Uri(uri);

        var yandex = await Dns.GetHostEntryAsync("yandex.ru");
        Console.WriteLine(yandex.HostName);
        foreach (var ip2 in yandex.AddressList) {
            Console.WriteLine(ip2);
        }

        Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
        // Accept() - принятие
        // Bind() - соединение с IpEndPoint
        // Close() - закрыть соединения
        // Connect() - присоединиться
        // Listen() - запустить пассивный сокет
        // Send() - отправка
        // SocketShutdown -> Send -> Recieve -> Both - блокировка выбранного

        IPAddress ip = IPAddress.Parse("127.0.0.1");
        IPEndPoint ep = new(ip, 1024);

        socket.Bind(ep);
        socket.Listen(10);

        try {
            while (true) {
                Socket ns = socket.Accept();
                Console.WriteLine(ns.RemoteEndPoint.ToString());
                ns.Send(System.Text.Encoding.ASCII.GetBytes(
                    DateTime.Now.ToString()
                ));
                ns.Shutdown(SocketShutdown.Both);
                ns.Close();
            }
        } catch (SocketException ex) {
            Console.WriteLine(ex.Message);
        }
    }
}
