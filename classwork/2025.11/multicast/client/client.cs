using System.Net;
using System.Net.Sockets;
using System.Text;

namespace client {
    public partial class client : Form {
        delegate void AppendText(string text);
        Thread listen;
        void AppendTextProc(string text) {
            textBox1.Text = text;
            listen = new Thread(new ThreadStart(Listener));
            listen.IsBackground = true;
            listen.Start();
        }

        void Listener() {
            while (true) {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint ipEP = new IPEndPoint(IPAddress.Any, 4567);
                socket.Bind(ipEP);

                IPAddress ip = IPAddress.Parse("224.5.5.5");
                socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, IPAddress.Any));
                byte[] buff = new byte[1024];
                socket.Receive(buff);
                this.Invoke(new AppendText(AppendTextProc), Encoding.UTF8.GetString(buff));
                socket.Close();
            }
        }

        public client() {
            InitializeComponent();
        }


    }
}
