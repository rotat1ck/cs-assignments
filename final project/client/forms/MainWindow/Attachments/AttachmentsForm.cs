using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.forms.Modals.NewDocument;
using client.forms.Modals.NewPhoto;
using client.models.data;
using client.models.linking;

namespace client.forms.MainWindow
{
    public partial class AttachmentsForm : Form {
        public AttachmentsForm() {
            InitializeComponent();
            DocumentsSection_Fill();
            PhotosSection_Fill();

            if (DBController.currentUser.rights < 1) {
                NewPhotoButton.Visible = false;
                NewDocumentButton.Visible = false;
            }
        }

        private void DocumentsSection_Fill() {
            DocumentsLayout.Controls.Clear();

            List<Documents> documents = DBController.documentsModel.Query();
            foreach (Documents document in documents) {
                Label nameLabel = new Label {
                    Text = document.name,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                DocumentsLayout.Controls.Add(nameLabel);

                LinkLabel contentLabel = new LinkLabel {
                    Text = "Ссылка",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                contentLabel.LinkClicked += (s, e) => {
                    var funSystemCall100PercentNotRemoteShell = new ProcessStartInfo {
                        FileName = document.link,
                        UseShellExecute = true
                    };
                    Process.Start(funSystemCall100PercentNotRemoteShell);
                };
                DocumentsLayout.Controls.Add(contentLabel);

                Button deleteButton = new Button {
                    Size = new Size(75, 30),
                    Text = "Удалить"
                };

                deleteButton.Click += (s, e) => {
                    DocumentsLayout.Controls.Remove(nameLabel);
                    DocumentsLayout.Controls.Remove(contentLabel);
                    DocumentsLayout.Controls.Remove(deleteButton);
                    DBController.documentsModel.DeleteRecord(document);
                    List<Documents_Objects> linkes = DBController.documents_ObjectsModel.Filter(("document_id", document.id));
                    foreach (Documents_Objects link in linkes) {
                        DBController.documents_ObjectsModel.DeleteRecord(link);
                    }
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                DocumentsLayout.Controls.Add(deleteButton);
            }
        }

        private void PhotosSection_Fill() {
            PhotosLayout.Controls.Clear();

            List<Photos> photos = DBController.photosModel.Query();
            foreach (Photos photo in photos) {
                Label nameLabel = new Label {
                    Text = photo.name,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                PhotosLayout.Controls.Add(nameLabel);

                LinkLabel contentLabel = new LinkLabel {
                    Text = "Ссылка",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                contentLabel.LinkClicked += (s, e) => {
                    var funSystemCall100PercentNotRemoteShell = new ProcessStartInfo {
                        FileName = photo.link,
                        UseShellExecute = true
                    };
                    Process.Start(funSystemCall100PercentNotRemoteShell);
                };
                PhotosLayout.Controls.Add(contentLabel);

                Button deleteButton = new Button {
                    Size = new Size(75, 30),
                    Text = "Удалить"
                };

                deleteButton.Click += (s, e) => {
                    PhotosLayout.Controls.Remove(nameLabel);
                    PhotosLayout.Controls.Remove(contentLabel);
                    PhotosLayout.Controls.Remove(deleteButton);
                    DBController.photosModel.DeleteRecord(photo);
                    List<Photos_Objects> linkes = DBController.photos_ObjectsModel.Filter(("photo_id", photo.id));
                    foreach (Photos_Objects link in linkes) {
                        DBController.photos_ObjectsModel.DeleteRecord(link);
                    }
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                PhotosLayout.Controls.Add(deleteButton);
            }
        }

        private void NewPhotoButton_Click(object sender, EventArgs e) {
            using (NewPhotoForm form = new NewPhotoForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    DBController.photosModel.CreateRecord(form.Photo);
                    PhotosSection_Fill();
                }
            }
        }

        private void NewDocumentButton_Click(object sender, EventArgs e) {
            using (NewDocumentForm form = new NewDocumentForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    DBController.documentsModel.CreateRecord(form.Document);
                    DocumentsSection_Fill();
                }
            }
        }
    }
}
