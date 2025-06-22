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

namespace client.forms.Modals.NewEmployee {
    public partial class NewEmployeeForm : Form {
        public static Positions newPosition;
        public NewEmployeeForm() {
            InitializeComponent();
            PositionComboBox_Fill();
            RolesComboBox_Fill();
        }

        private void PositionComboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && PositionComboBox.Text != "") {
                Positions position = DBController.positionsModel.Filter(("name", PositionComboBox.Text))[0];
                if (position == null) {
                    DBController.positionsModel.CreateRecord(new Positions {
                        name = PositionComboBox.Text,
                    });
                    PositionComboBox.SelectedItem = position;
                    PositionComboBox_Fill();
                }
            }
        }

        private void PositionComboBox_Fill() {
            PositionComboBox.Items.Clear();

            List<Positions> positions = DBController.positionsModel.Query();
            foreach (Positions position in positions) {
                PositionComboBox.Items.Add(position);
                PositionComboBox.SelectedItem = position;
            }
        }

        private void RolesComboBox_Fill() {
            RolesComboBox.Items.Clear();

            List<Roles> roles = DBController.rolesModel.Query();
            foreach (Roles role in roles) {
                RolesComboBox.Items.Add(role);
                RolesComboBox.SelectedItem = role;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
