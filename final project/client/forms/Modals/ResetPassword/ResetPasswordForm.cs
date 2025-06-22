using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.forms.Modals.ResetPassword {
    public partial class ResetPasswordForm : Form {
        public string NewPassword;
        public ResetPasswordForm() {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            if (PasswordInput.Text != RepeatPasswordInput.Text) {
                MessageBox.Show("Пароли не совпадают");
                return;
            } else if (PasswordInput.Text == "") {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }

            NewPassword = PasswordInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
