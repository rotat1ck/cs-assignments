using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.forms.Auth.Authorization;
using client.forms.MainWindow;
using client.models.data;

namespace client.forms.Auth.Authentication {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e) {
            Form childForm = null;

            List<Users> userByUsername;
            if (DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 1) {
                userByUsername = DBController.usersModel.Filter(("username", UsernameInput.Text), ("password", Hash(PasswordInput.Text)));
            } else {
                userByUsername = DBController.usersModel.Filter(("username", UsernameInput.Text), ("password", PasswordInput.Text));
            }

            if (userByUsername.Count > 0) {
                DBController.currentUser = userByUsername[userByUsername.Count - 1];
                childForm = new ObjectsManagementForm();
                this.Hide();
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
                return;
            }

            List<Users> userByEmail;
            if (DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 1) {
                userByEmail = DBController.usersModel.Filter(("email", UsernameInput.Text), ("password", Hash(PasswordInput.Text)));
            } else {
                userByEmail = DBController.usersModel.Filter(("email", UsernameInput.Text), ("password", PasswordInput.Text));
            }

            if (userByEmail.Count > 0) {
                DBController.currentUser = userByEmail[userByEmail.Count - 1];
                childForm = new ObjectsManagementForm();
                this.Hide();
                childForm.StartPosition = FormStartPosition.CenterScreen;
                childForm.Show();
                return;
            }

            MessageBox.Show("Ќеверное им€ пользовател€/адрес почты или пароль");
        }

        private void PasswordInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                SignInButton_Click(this, e);
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        public static string Hash(string password) {
            using (SHA256 sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
