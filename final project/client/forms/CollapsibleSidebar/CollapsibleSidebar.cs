using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.forms.MainWindow
{
    public class CollapsibleSidebar : MenuStrip {
        private bool _expanded = false;
        private const int CollapsedWidth = 50;
        private const int ExpandedWidth = 200;
        private Form currentActiveForm;
        private Panel contentPanel = new Panel();
        public event Action<string> MenuItemClicked;

        private class MenuItemData {
            public string Icon { get; set; }
            public string Text { get; set; }
            public bool Checked { get; set; }
        }

        public CollapsibleSidebar() {
            InitializeSidebar();
            SetupMenuItems();
        }

        private void InitializeSidebar() {
            this.Width = CollapsedWidth;
            this.Dock = DockStyle.Left;
            this.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ShowItemToolTips = false;
            this.AutoSize = false;
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.ForeColor = Color.White;
        }

        private void SetupMenuItems() {
            //шторка
            var menuItems = new[]
            {
                new MenuItemData { Icon = "📊", Text = "Управление объектами", Checked = true },
                new MenuItemData { Icon = "✅", Text = "Задачи", Checked = false },
                new MenuItemData { Icon = "📄", Text = "Документация", Checked = false },
                new MenuItemData { Icon = "👥", Text = "Сотрудники", Checked = false },
                new MenuItemData { Icon = "👤", Text = "Учетная запись", Checked = false },
                new MenuItemData { Icon = "🚪", Text = "Выход", Checked = false }
            };

            // Toggle button
            var toggleButton = new ToolStripButton {
                Text = "≡",
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Alignment = ToolStripItemAlignment.Left,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White
            };

            toggleButton.Click += (s, e) => this.ToggleSidebar();
            this.Items.Insert(0, toggleButton);

            foreach (var item in menuItems) {
                var menuItem = new ToolStripButton {
                    Text = _expanded ? $"{item.Icon} {item.Text}" : item.Icon,
                    Tag = item,
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,
                    Width = _expanded ? ExpandedWidth - 10 : CollapsedWidth - 10,
                    Checked = item.Checked,
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.White
                };

                menuItem.Click += MenuItem_Click;
                this.Items.Add(menuItem);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e) {
            if (sender is ToolStripButton btn && btn.Tag is MenuItemData item) {
                foreach (ToolStripItem menuItem in this.Items) {
                    if (menuItem is ToolStripButton button && button.Tag is MenuItemData data) {
                        data.Checked = false;
                        button.Checked = false;
                    }
                }

                item.Checked = true;
                btn.Checked = true;
                OpenChildForm(item.Text);
            }
        }

        private void OpenChildForm(string menuItemText) {
            Form childForm = null;

            switch (menuItemText) {
                case "Управление объектами":
                    childForm = new ObjectsManagementForm();
                    this.Parent.Hide();
                    childForm.StartPosition = FormStartPosition.CenterScreen;
                    childForm.Show();
                    break;

                case "Задачи":
                    childForm = new TasksForm();
                    this.Parent.Hide();
                    childForm.StartPosition = FormStartPosition.CenterScreen;
                    childForm.Show();
                    break;

                case "Документация":
                    childForm = new DocumentationForm();
                    this.Parent.Hide();
                    childForm.StartPosition = FormStartPosition.CenterScreen;
                    childForm.Show();
                    break;

                case "Сотрудники":
                    childForm = new EmployeesForm();
                    this.Parent.Hide();
                    childForm.StartPosition = FormStartPosition.CenterScreen;
                    childForm.Show();
                    break;

                case "Учетная запись":
                    childForm = new AccountForm();
                    this.Parent.Hide();
                    childForm.StartPosition = FormStartPosition.CenterScreen;
                    childForm.Show();
                    break;

                case "Выход":
                    Application.Exit();
                    return;
                default:
                    MessageBox.Show($"Недоступно.");
                    return;
            }
        }

        // анимка для свертывания шапки
        public void ToggleSidebar() {
            _expanded = !_expanded;
            this.Width = _expanded ? ExpandedWidth : CollapsedWidth;
            UpdateButtonsState();
        }

        private void UpdateButtonsState() {
            foreach (ToolStripItem item in this.Items) {
                if (item is ToolStripButton btn && btn.Tag is MenuItemData menuItem) {
                    btn.Text = _expanded ? $"{menuItem.Icon} {menuItem.Text}" : menuItem.Icon;
                    btn.Width = _expanded ? ExpandedWidth - 10 : CollapsedWidth - 10;
                }
            }
        }
    }
}
