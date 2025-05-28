using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.forms.MainWindow
{
    public class CollapsibleSidebar : MenuStrip
    {
        private bool _expanded = false;
        private const int CollapsedWidth = 50;
        private const int ExpandedWidth = 200;

        public event Action<string> MenuItemClicked;

        private class MenuItemData
        {
            public string Icon { get; set; }
            public string Text { get; set; }
            public bool Checked { get; set; }
        }

        public CollapsibleSidebar()
        {
            InitializeSidebar();
            SetupMenuItems();
        }

        private void InitializeSidebar()
        {
            this.Width = CollapsedWidth;
            this.Dock = DockStyle.Left;
            this.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ShowItemToolTips = false;
            this.AutoSize = false;
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.ForeColor = Color.White;
        }

        private void SetupMenuItems()
        {
            var menuItems = new[]
            {
                new MenuItemData { Icon = "📊", Text = "Управление объектами", Checked = false },
                new MenuItemData { Icon = "✅", Text = "Задачи", Checked = true },
                new MenuItemData { Icon = "📄", Text = "Документация", Checked = false },
                new MenuItemData { Icon = "👥", Text = "Сотрудники", Checked = false },
                new MenuItemData { Icon = "👤", Text = "Учетная запись", Checked = false },
                new MenuItemData { Icon = "🚪", Text = "Выход", Checked = false }
            };
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

            this.MenuItemClicked += (menuItem) => {
                if (menuItem == "Выход") {
                    Application.Exit();
                }
                else {
                    MessageBox.Show($"В работе"); // ДОДЕЛАТЬ
                }
            };

            foreach (var item in menuItems)
            {
                var menuItem = new ToolStripButton
                {
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

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn && btn.Tag is MenuItemData item)
            {
                MenuItemClicked?.Invoke(item.Text);
            }
        }

        public void ToggleSidebar()
        {
            _expanded = !_expanded;
            this.Width = _expanded ? ExpandedWidth : CollapsedWidth;
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            foreach (ToolStripItem item in this.Items)
            {
                if (item is ToolStripButton btn && btn.Tag is MenuItemData menuItem)
                {
                    btn.Text = _expanded ? $"{menuItem.Icon} {menuItem.Text}" : menuItem.Icon;
                    btn.Width = _expanded ? ExpandedWidth - 10 : CollapsedWidth - 10;
                }
            }
        }
    }
}
