using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.forms.Auth.Authentication;

namespace client.forms.Helper {
    public partial class EntryForm : Form {
        public static string url = "https://rotatick.ru/misc/cherry/client.db";
        public static string fileName = Path.GetFileName(url);
        public static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        public EntryForm() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if (!NetworkInterface.GetIsNetworkAvailable()) {
                MessageBox.Show("Сетевое подключение не обнаружено. Проверьте соединение с интернетом и повторите попытку установки.");
                return;
            }

            if (!File.Exists(filePath)) {
                using (var downloadForm = new DownloadForm()) {
                    downloadForm.Show();

                    // 🥨
                    try {
                        using (var cl = new HttpClient()) {
                            using (var response = cl.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).Result) {
                                response.EnsureSuccessStatusCode();
                                var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                                var buffer = new byte[8192];
                                long totalReadBytes = 0;

                                using (var fs = new FileStream(filePath, FileMode.Create)) {
                                    using (var stream = response.Content.ReadAsStreamAsync().Result) {
                                        int readBytes;
                                        while ((readBytes = stream.Read(buffer, 0, buffer.Length)) > 0) {
                                            fs.Write(buffer, 0, readBytes);
                                            totalReadBytes += readBytes;
                                            if (totalBytes > 0) {
                                                downloadForm.DownloadProgressBar.Value = (int)((totalReadBytes * 100) / totalBytes);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Ошибка при загрузке: " + ex.Message);
                    }
                    // 🥨

                    downloadForm.Close();
                    DBController.InitDB(filePath);
                }
            }

            this.Hide();
            AdminHelperForm form = new AdminHelperForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

    }
}
