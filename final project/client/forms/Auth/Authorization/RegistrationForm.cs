using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.forms.Auth.Authentication;

namespace client.forms.Auth.Authorization {
    public partial class RegistrationForm : Form {
        public RegistrationForm() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm form = new LoginForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
