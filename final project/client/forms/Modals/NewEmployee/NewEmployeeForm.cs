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
        public Employees NewEmployee;

        public NewEmployeeForm() {
            InitializeComponent();
            PositionComboBox_Fill();
            RolesComboBox_Fill();
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

        private void PositionComboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && PositionComboBox.Text != "") {
                List<Positions> positions = DBController.positionsModel.Filter(("name", PositionComboBox.Text));
                if (positions.Count == 0) {
                    DBController.positionsModel.CreateRecord(new Positions {
                        name = PositionComboBox.Text,
                    });
                    PositionComboBox_Fill();
                    PositionComboBox.SelectedItem = DBController.positionsModel.Filter(("name", PositionComboBox.Text))[0];
                }
            }
        }

        private void RolesComboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && RolesComboBox.Text != "") {
                List<Roles> roles = DBController.rolesModel.Filter(("name", RolesComboBox.Text));
                if (roles.Count == 0) {
                    DBController.rolesModel.CreateRecord(new Roles {
                        name = RolesComboBox.Text,
                    });
                    RolesComboBox_Fill();
                    RolesComboBox.SelectedItem = DBController.rolesModel.Filter(("name", RolesComboBox.Text))[0];
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e) {
            NewEmployee = new Employees {
                first_name = FirstNameInput.Text,
                last_name = LastNameInput.Text,
                position_id = ((Positions)PositionComboBox.SelectedItem).id,
                role_id = ((Roles)RolesComboBox.SelectedItem).id
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
