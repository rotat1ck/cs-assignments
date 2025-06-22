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
using client.forms.Auth.Authentication;
using client.models.data;
using client.models.misc;

namespace client.forms.Helper {
    public partial class SettingsHelperForm : Form {
        private static string usernameEntry;
        private static string passwordEntry;
        public SettingsHelperForm(string username, string password) {
            InitializeComponent();
            usernameEntry = username;
            passwordEntry = password;
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

        private void ContinueButton_Click(object sender, EventArgs e) {
            Users adminUser = new Users {
                employee_id = 0,
                rights = 1,
                username = usernameEntry,
                password = passwordEntry,
                email = ""
            };

            Settings passwordHashing = new Settings {
                name = "password-hashing",
                value = 0
            };
            Settings safeRegister = new Settings {
                name = "safe-register",
                value = 0
            };

            if (PasswordHashingCheckBox.Checked) {
                adminUser.password = Hash(passwordEntry);
                passwordHashing.value = 1;
            }
            if (SafeRegisterCheckBox.Checked) {
                safeRegister.value = 1;
            }

            DBController.usersModel.CreateRecord(adminUser);

            DBController.settingsModel.CreateRecord(passwordHashing);
            DBController.settingsModel.CreateRecord(safeRegister);

            this.Hide();
            LoginForm form = new LoginForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
