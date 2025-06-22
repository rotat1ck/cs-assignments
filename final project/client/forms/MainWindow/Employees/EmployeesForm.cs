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
using client.forms.Modals.NewEmployee;
using client.forms.Modals.ResetPassword;
using client.models.data;
using client.models.linking;

namespace client.forms.MainWindow
{
    public partial class EmployeesForm : Form {
        private Employees currentEmployee;
        private Users currentUser;

        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private ComboBox positionInput;
        private ComboBox roleInput;

        private TextBox usernameInput;
        private TextBox passwordInput;
        private TextBox emailInput;

        public EmployeesForm() {
            InitializeComponent();
            EmployeesLayout_Fill();

            if (DBController.currentUser.rights < 1) {
                NewEmployeeButton.Visible = false;
            }
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e) {
            using (NewEmployeeForm form = new NewEmployeeForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    DBController.employeesModel.CreateRecord(form.NewEmployee);
                    EmployeesLayout_Fill();
                }
            }
        }

        private void EmployeeInfoSaveButton_Click(object sender, EventArgs e) {
            currentEmployee.first_name = firstNameInput.Text;
            currentEmployee.last_name = lastNameInput.Text;
            currentEmployee.role_id = ((Roles)roleInput.SelectedItem).id;
            currentEmployee.position_id = ((Positions)positionInput.SelectedItem).id;
            DBController.employeesModel.UpdateRecord(currentEmployee);
            EmployeesLayout_Fill();
        }

        private void EmployeeAccountSaveButton_Click(object sender, EventArgs e) {
            currentUser.username = usernameInput.Text;
            if (DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 0) {
                currentUser.password = passwordInput.Text;
            }
            currentUser.email = emailInput.Text;
            DBController.usersModel.UpdateRecord(currentUser);
            EmployeesLayout_Fill();
        }

        private void EmployeeAccountPasswordResetButton_Click(object sender, EventArgs e) {
            using (ResetPasswordForm form = new ResetPasswordForm()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    currentUser.password = Hash(form.NewPassword);
                    DBController.usersModel.UpdateRecord(currentUser);
                }
            }
        }

        private void EmployeesLayout_Fill() {
            EmployeesLayout.Controls.Clear();

            List<Employees> employees = DBController.employeesModel.Query();
            foreach (Employees employee in employees) {
                Button employeeButton = new Button {
                    Size = new Size(190, 30),
                    Text = employee.last_name + " " + employee.first_name
                };
                employeeButton.Click += (s, e) => {
                    currentEmployee = employee;
                    List<Users> linkedUser = DBController.usersModel.Filter(("employee_id", employee.id));
                    if (linkedUser.Count != 0) {
                        currentUser = linkedUser[0];
                    }

                    EmployeeAccountLabel.Visible = true;
                    EmployeeAccountLayout.Visible = true;
                    EmployeeInfoLabel.Visible = true;
                    EmployeeInfoLayout.Visible = true;
                    EmployeeInfoSaveButton.Visible = false ? currentUser != null && currentUser.rights > DBController.currentUser.rights : true;

                    EmployeeInfo_Fill();
                    EmployeeAccount_Fill();
                };
                EmployeesLayout.Controls.Add(employeeButton);

                Button deleteButton = new Button {
                    Size = new Size(65, 30),
                    Text = "Удалить"
                };

                deleteButton.Click += (s, e) => {
                    EmployeesLayout.Controls.Remove(employeeButton);
                    EmployeesLayout.Controls.Remove(deleteButton);
                    DBController.employeesModel.DeleteRecord(employee);
                    List<Users> linkedUser = DBController.usersModel.Filter(("employee_id", employee.id));
                    if (linkedUser.Count != 0) {
                        DBController.usersModel.DeleteRecord(linkedUser[0]);
                    }
                };
                if (DBController.currentUser.rights < 1) {
                    deleteButton.Enabled = false;
                }
                EmployeesLayout.Controls.Add(deleteButton);
            }
        }

        private void EmployeeInfo_Fill() {
            EmployeeInfoLayout.Controls.Clear();

            // Роль
            roleInput = new ComboBox {
                DisplayMember = "name",
                ValueMember = "id",
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Top
            };
            foreach (Roles role in DBController.rolesModel.Query()) {
                roleInput.Items.Add(role);
                if (role.id == currentEmployee.role_id) {
                    roleInput.SelectedItem = role;
                }
            }
            EmployeeInfoLayout.Controls.Add(roleInput);

            // Позиция
            positionInput = new ComboBox {
                DisplayMember = "name",
                ValueMember = "id",
                DropDownStyle = ComboBoxStyle.DropDownList,
                Dock = DockStyle.Top
            };
            foreach (Positions position in DBController.positionsModel.Query()) {
                positionInput.Items.Add(position);
                if (position.id == currentEmployee.position_id) {
                    positionInput.SelectedItem = position;
                }
            }
            EmployeeInfoLayout.Controls.Add(positionInput);

            // Имя
            firstNameInput = new TextBox {
                Text = currentEmployee.first_name,
                ReadOnly = true ? currentUser != null && currentUser.rights > DBController.currentUser.rights : false,
                Dock = DockStyle.Top
            };
            EmployeeInfoLayout.Controls.Add(firstNameInput);

            // Фамилия
            lastNameInput = new TextBox {
                Text = currentEmployee.last_name,
                ReadOnly = true ? currentUser != null && currentUser.rights > DBController.currentUser.rights : false,
                Dock = DockStyle.Top
            };
            EmployeeInfoLayout.Controls.Add(lastNameInput);
        }

        private void EmployeeAccount_Fill() {
            EmployeeAccountLayout.Controls.Clear();

            if (currentUser == null) {
                // username
                Label notFound = new Label {
                    Text = "Учетная запись данного работника не зарегистрирована",
                    Dock = DockStyle.Fill
                };
                EmployeeAccountLayout.Controls.Add(notFound);
                return;
            }

            EmployeeAccountSaveButton.Visible = true;
            EmployeeAccountPasswordResetButton.Visible = true ? DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 1 : false;

            // email
            emailInput = new TextBox {
                Text = currentUser.email,
                ReadOnly = true ? currentUser != null && currentUser.rights > DBController.currentUser.rights : false,
                Dock = DockStyle.Top
            };
            EmployeeAccountLayout.Controls.Add(emailInput);

            // password
            passwordInput = new TextBox {
                Text = currentUser.password,
                ReadOnly = true ? currentUser != null && currentUser.rights > DBController.currentUser.rights : false,
                Dock = DockStyle.Top
            };
            if (DBController.settingsModel.Filter(("name", "password-hashing"))[0].value == 0) {
                EmployeeAccountLayout.Controls.Add(passwordInput);
            }

            // username
            usernameInput = new TextBox {
                Text = currentUser.username,
                ReadOnly = true ? currentUser != null && currentUser.rights > DBController.currentUser.rights : false,
                Dock = DockStyle.Top
            };
            EmployeeAccountLayout.Controls.Add(usernameInput);
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
    }
}
