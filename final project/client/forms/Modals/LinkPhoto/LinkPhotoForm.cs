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
using static System.Windows.Forms.LinkLabel;

namespace client.forms.Modals.LinkPhoto {
    public partial class LinkPhotoForm : Form {
        private Objects obj;
        public Photos_Objects link;
        public LinkPhotoForm(Objects obj) {
            InitializeComponent();
            this.obj = obj;
            PhotoList_Fill();
        }

        private void PhotoList_Fill() {
            PhotoList.Items.Clear();
            PhotoList.Text = "";
            DescriptionLabel.Text = "";

            List<Photos_Objects> allObjLinkings = DBController.photos_ObjectsModel.Query().Where(linking => linking.object_id == obj.id).ToList();
            List<Photos> allPhotos;

            if (SearchInput.Text.Trim() != "") {
                allPhotos = DBController.photosModel.Filter(("name", SearchInput.Text.Trim()));
            } else {
                allPhotos = DBController.photosModel.Query();
            }

            foreach (Photos document in allPhotos) {
                if (allObjLinkings.Any(linking => linking.photo_id == document.id)) {
                    continue;
                }
                PhotoList.Items.Add(document);
            }
            PhotoList.DisplayMember = "name";
            if (PhotoList.Items.Count > 0) {
                PhotoList.SelectedIndex = 0;
                DescriptionLabel.Text = ((Photos)PhotoList.SelectedItem).link;
            }
        }

        private void PhotoList_Update(object sender, EventArgs e) {
            DescriptionLabel.Text = ((Photos)PhotoList.SelectedItem).link;
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                PhotoList_Fill();
        }

        private void LinkButton_Click(object sender, EventArgs e) {
            if (PhotoList.SelectedItem != null) {
                link = new Photos_Objects {
                    object_id = obj.id,
                    photo_id = ((Photos)PhotoList.SelectedItem).id
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("Выберите фото из выпадающего списка");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
