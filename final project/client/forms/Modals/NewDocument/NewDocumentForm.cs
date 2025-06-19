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

namespace client.forms.Modals.NewDocument {
    public partial class NewDocumentForm : Form {
        public Documents Document { get; set; }
        public NewDocumentForm() {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            Document = new Documents {
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
