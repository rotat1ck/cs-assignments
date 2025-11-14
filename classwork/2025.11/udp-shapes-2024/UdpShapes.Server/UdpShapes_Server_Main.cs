using System.Net;
using System.Net.Sockets;

namespace UdpShapes.Server;

public class UdpShapes_Server_Main {
    static async Task Main (string[] args) => await new UdpShapes_Server_Main ().Run ();

    private async Task Run () {
        UdpClient server = new UdpClient (2024);
        Console.WriteLine ("Сервер запущен");

        // Не потокобезпасная коллекция. Допустимо, потому что работает лишь 1 поток
        IList<IPEndPoint> clients = new List<IPEndPoint> ();

        while (true) {
            UdpReceiveResult received;
            try {
                received = await server.ReceiveAsync ();  // новое сообщение от клиента
            }
            catch (SocketException) {
                // Не могу никак отреагировать. Просто перейти к следующему
                continue;
            }

            IPEndPoint from = received.RemoteEndPoint;
            byte[] datagram = received.Buffer;
            
            if (!clients.Contains (from)) {
                clients.Add (from);
                Console.WriteLine ($"Добавляю клиента {from}");
            }

            // Тупой ретранслятор: что получили, то рассылаем, не глядя.
            // Не пытается разобрать содержимое датаграммы на сервере.
            // Вся обработка на клиенте.
            foreach (IPEndPoint client in clients.ToArray ())
                try {
                    await server.SendAsync (datagram, client);  // Неявное преобразование: byte[] -> ReadOnlyMemory. Означает отправить массив целиком
                }
                catch (SocketException) {
                    Console.WriteLine ($"Удаляю клиента {client}");
                    clients.Remove (client);
                }
                catch (Exception ex) {
                    Console.WriteLine (ex.Message);
                }
        }
    }
}
