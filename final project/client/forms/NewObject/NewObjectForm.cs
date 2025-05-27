using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace client.forms.NewObject {
    public partial class NewObjectForm : Form {
        public Objects NewObject { get; private set; }

        public NewObjectForm() {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            NewObject = new Objects {
                object_type = int.Parse(ObjectTypeInput.Text),
                name = NameInput.Text,
                description = DescriptionInput.Text,
                location = LocationInput.Text,
                number = int.Parse(NumberInput.Text)
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
