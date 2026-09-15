using System.Net;
using System.Net.Sockets;
using System.Text;

namespace server {
    public partial class Form1 : Form {
        static string mes = string.Empty;
        static int interval = 1000;
        Thread sender = new Thread(new ThreadStart(MulticastSend));

        public Form1() {
            InitializeComponent();
            sender.IsBackground = true;
            sender.Start();
        }

        static void MulticastSend() {
            while (true) {
                Thread.Sleep(interval);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
                IPAddress dest = IPAddress.Parse("224.5.5.5");
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(dest));

                IPEndPoint ipEP = new IPEndPoint(dest, 4567);
                socket.Connect(ipEP);
                socket.Send(Encoding.UTF8.GetBytes(mes));
                socket.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            mes = textBox1.Text;
        }
    }
}
