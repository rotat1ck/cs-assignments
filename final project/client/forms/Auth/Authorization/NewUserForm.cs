using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.models.data;

namespace client.forms.Auth.Authorization {
    public partial class NewUserForm : Form {
        public Employees employee;
        public NewUserForm(Employees employee) {
            this.employee = employee;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            if (UsernameInput.Text.Length < 3) {
                MessageBox.Show("Имя пользователя должно быть не меньше 3 символов");
                return;
            } else if (DBController.usersModel.Filter(("username", UsernameInput.Text)).Count != 0) {
                MessageBox.Show("Введенное имя пользователя уже занято");
                return;
            }

            try {
                new MailAddress(EmailInput.Text);
            } catch (FormatException) {
                MessageBox.Show("Неверно введен адрес почты");
                return;
            }

            if (PasswordInput.Text != RepeatPasswordInput.Text) {
                MessageBox.Show("Введенные пароли не совпадают");
                return;
            } else if (PasswordInput.Text.Length < 8) {
                MessageBox.Show("Длина пароля должна быть не меньше 8 символов");
                return;
            }

            Users user = new Users {
                rights = 0,
                employee_id = employee.id,
                username = UsernameInput.Text,
                password = PasswordInput.Text,
                email = EmailInput.Text
            };
            if (DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 1) {
                user.password = Hash(PasswordInput.Text);
            }
            DBController.usersModel.CreateRecord(user);
            DBController.currentUser = user;

            this.Hide();
            ObjectsManagementForm form = new ObjectsManagementForm();
            form.StartPosition = FormStartPosition.CenterParent;
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

