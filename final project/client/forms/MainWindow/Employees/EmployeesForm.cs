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

namespace client.forms.MainWindow
{
    public partial class EmployeesForm : Form
    {
        public Employees currentEmployee;
        public EmployeesForm() {
            InitializeComponent();
            EmployeesLayout_Fill();

            if (DBController.currentUser.rights < 1) {
                NewEmployeeButton.Visible = false;
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

                    EmployeeAccountLabel.Visible = true;
                    EmployeeAccountLayout.Visible = true;
                    EmployeeInfoLabel.Visible = true;
                    EmployeeInfoLayout.Visible = true;

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


        }

        private void EmployeeAccount_Fill() {
            EmployeeAccountLayout.Controls.Clear();


        }
    }
}
