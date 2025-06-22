using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.forms.Helper {
    public partial class AdminHelperForm : Form {
        public AdminHelperForm() {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e) {
            if (PasswordInput.Text != RepeatPasswordInput.Text) {
                MessageBox.Show("Пароли не совпадают");
                return;
            } else if (PasswordInput.Text == "") {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }

            this.Hide();
            SettingsHelperForm form = new SettingsHelperForm(UsernameInput.Text, PasswordInput.Text);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
