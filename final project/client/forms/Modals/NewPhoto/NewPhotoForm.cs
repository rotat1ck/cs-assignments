using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.models.data;

namespace client.forms.Modals.NewPhoto {
    public partial class NewPhotoForm : Form {
        public Photos Photo;
        public NewPhotoForm() {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            Photo = new Photos {
                name = NameInput.Text,
                link = LinkInput.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
