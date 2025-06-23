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
using client.models.linking;

namespace client.forms.Modals.LinkDocument {
    public partial class LinkDocumentForm : Form {
        private Objects obj;
        public Documents_Objects link;
        public LinkDocumentForm(Objects obj) {
            InitializeComponent();
            this.obj = obj;
            DocumentsList_Fill();
        }

        private void DocumentsList_Fill() {
            DocumentsList.Items.Clear();
            DocumentsList.Text = "";
            DescriptionLabel.Text = "";

            List<Documents_Objects> allObjLinkings = DBController.documents_ObjectsModel.Query().Where(linking => linking.object_id == obj.id).ToList();
            List<Documents> allDocuments;

            if (SearchInput.Text.Trim() != "") {
                allDocuments = DBController.documentsModel.Filter(("name", SearchInput.Text.Trim()));
            } else {
                allDocuments = DBController.documentsModel.Query();
            }
            
            foreach (Documents document in allDocuments) {
                if (allObjLinkings.Any(linking => linking.document_id == document.id)) {
                    continue;
                }
                DocumentsList.Items.Add(document);
            }
            DocumentsList.DisplayMember = "name";
            if (DocumentsList.Items.Count > 0) {
                DocumentsList.SelectedIndex = 0;
                DescriptionLabel.Text = ((Documents)DocumentsList.SelectedItem).link;
            }
        }

        private void DocumentsList_Update(object sender, EventArgs e) {
            DescriptionLabel.Text = ((Documents)DocumentsList.SelectedItem).link;
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                DocumentsList_Fill();
        }

        private void LinkButton_Click(object sender, EventArgs e) {
            if (DocumentsList.SelectedItem != null) {
                link = new Documents_Objects {
                    object_id = obj.id,
                    document_id = ((Documents)DocumentsList.SelectedItem).id
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("Выберите документ из выпадающего списка");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
