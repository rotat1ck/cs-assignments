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
using client.models.data;

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

        private void RegisterButton_Click(object sender, EventArgs e) {
            var safeCheck = DBController.settingsModel.Filter(("name", "safe-register"));
            if (safeCheck.Count > 0) {
                if (safeCheck[0].value == 0) {
                    UnsafeRegister();
                } else {
                    SafeRegister();
                }
            } else {
                SafeRegister();
            }
        }

        private void SafeRegister() {
            // проверка имени и фамилии
            List<Employees> employees = DBController.employeesModel.Filter(("first_name", FirstNameInput.Text), ("last_name", LastNameInput.Text));
            if (employees.Count == 0) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            }

            // проверка на существование
            Employees foundEmployee = employees[0];
            List<Users> existCheck = DBController.usersModel.Filter(("employee_id", foundEmployee.id));
            if (existCheck.Count != 0) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            }

            // проверка позиции
            List<Positions> positions = DBController.positionsModel.Filter(("name", PositionInput.Text));
            if (positions.Count == 0) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            } else if (foundEmployee.position_id != positions[0].id) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            }

            // проверка роли
            List<Roles> roles = DBController.rolesModel.Filter(("name", RoleInput.Text));
            if (roles.Count == 0) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            } else if (foundEmployee.role_id != roles[0].id) {
                MessageBox.Show("Указаны неверные данные сотрудника");
                return;
            }

            this.Hide();
            NewUserForm form = new NewUserForm(foundEmployee);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void UnsafeRegister() {
            // проверка имени и фамилии
            List<Employees> employees = DBController.employeesModel.Filter(("first_name", FirstNameInput.Text), ("last_name", LastNameInput.Text));
            if (employees.Count == 0) {
                MessageBox.Show("Указано неверное имя или фамилия");
                return;
            }

            // проверка на существование
            Employees foundEmployee = employees[0];
            List<Users> existCheck = DBController.usersModel.Filter(("employee_id", foundEmployee.id));
            if (existCheck.Count != 0) {
                MessageBox.Show("Учетная запись с данным именем и фамилией уже зарегистрирована");
                return;
            }

            // проверка позиции
            List<Positions> positions = DBController.positionsModel.Filter(("name", PositionInput.Text));
            if (positions.Count == 0) {
                MessageBox.Show("Указана несуществующая позиция");
                return;
            } else if (foundEmployee.position_id != positions[0].id) {
                MessageBox.Show("Указана неверная позиция");
                return;
            }
            
            // проверка роли
            List<Roles> roles = DBController.rolesModel.Filter(("name", RoleInput.Text));
            if (roles.Count == 0) {
                MessageBox.Show("Указана несуществующая роль");
                return;
            } else if (foundEmployee.role_id != roles[0].id) {
                MessageBox.Show("Указана неверная роль");
                return;
            }

            this.Hide();
            NewUserForm form = new NewUserForm(foundEmployee);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
