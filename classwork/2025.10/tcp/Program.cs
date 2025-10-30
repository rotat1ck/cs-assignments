using System.Net.Sockets;
using System.Text;

namespace tcp {
    internal class Program {
        static async Task Main(string[] args) {
            var port = 80;
            var url = "www.ya.ru";
            using Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try {
                await tcpSocket.ConnectAsync(url, port);
                Console.WriteLine($"Подключение к {url} установлено");

                var mes = $"GET / HTTP/1.1\r\nHost: {url}\r\nConnection: close\r\n\r\n";
                var messageBytes = Encoding.UTF8.GetBytes(mes);
                int bytesSend = await tcpSocket.SendAsync(messageBytes);
                tcpSocket.Shutdown(SocketShutdown.Send);
                Console.WriteLine($"Отправлено {bytesSend} байт");

                var respBytes = new byte[512];
                var builder = new StringBuilder();
                int bytes;
                do {
                    bytes = await tcpSocket.ReceiveAsync(respBytes);
                    string response = Encoding.UTF8.GetString(respBytes);
                    builder.Append(response);
                } while (bytes > 0);

                Console.WriteLine(builder);
                await tcpSocket.DisconnectAsync(true);
            }
            catch (SocketException ex) {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
