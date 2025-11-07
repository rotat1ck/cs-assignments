using System.Net.Sockets;
using System.Text;

namespace chat_client {
    public partial class Form1 : Form {
        private TcpClient server = new TcpClient();
        private CancellationTokenSource cancel = new CancellationTokenSource();

        public Form1() {
            InitializeComponent();
        }

        private async void say_Click(object sender, EventArgs e) {
            string name = textBox1.Text;
            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show("¬ведите им€");
            }

            string mess = textBox2.Text;
            if (string.IsNullOrWhiteSpace(mess)) {
                MessageBox.Show("¬ведите сообщение");
            }
            mess = $"{name}:{mess}";

            byte[] buffer = Encoding.UTF8.GetBytes(mess);
            await server.GetStream().WriteAsync(buffer, 0, buffer.Length);
            textBox2.Text = string.Empty;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            cancel.Cancel();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            await server.ConnectAsync("127.0.0.1", 2024);

            await ListenToServer();
        }

        private async Task ListenToServer() {
            byte[] buffer = new byte[1024];
            while (true) {
                if (cancel.IsCancellationRequested) return;
                int read = await server.GetStream().ReadAsync(buffer, 0, buffer.Length, cancel.Token);
                if (cancel.IsCancellationRequested) return;

                string mess = Encoding.UTF8.GetString(buffer, 0, read);
                textBox3.Text = $"{textBox3.Text}\r\n{mess}";
            }
        }
    }
}
