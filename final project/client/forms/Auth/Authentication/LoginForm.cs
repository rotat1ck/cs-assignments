using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.forms.MainWindow;
using client.models.data;

namespace client.forms.Auth.Authentication {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e) {
            Form childForm = null;

            List<Users> userByUsername = DBController.usersModel.Filter(("username", UsernameInput.Text), ("password", UsernameInput.Text));

            if (userByUsername.Count > 0) {
                DBController.currentUser = userByUsername[userByUsername.Count - 1];
                childForm = new ObjectsManagementForm();
                this.Hide();
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
                return;
            }

            List<Users> userByEmail = DBController.usersModel.Filter(("email", UsernameInput.Text), ("password", UsernameInput.Text));

            if (userByEmail.Count > 0) {
                DBController.currentUser = userByEmail[userByEmail.Count - 1];
                childForm = new ObjectsManagementForm();
                this.Hide();
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
                return;
            }

            MessageBox.Show("Incorrent username/email or password");
        }

        private void PasswordInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SignInButton_Click(this, e);
        }

    }
}
