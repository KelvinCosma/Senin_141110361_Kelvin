using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Settings : Form
    {
        public Settings() { InitializeComponent(); }

        private void Settings_Load(object sender, EventArgs e) {
            sApply.Enabled = false;
            Form1 formMain = (Form1)MdiParent;
            SettingColorComboBox.Text = formMain.getBgColor();
            panelBgColor.Hide();
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                  BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) { this.SettingColorComboBox.Items.Add(c.Name); }
            this.SettingColorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.SettingColorComboBox.DrawItem += new DrawItemEventHandler(SettingColorComboBox_DrawItem);
        }

        private void SettingColorComboBox_DrawItem (object sender, DrawItemEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0) {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) { Hide(); }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {  if (treeView1.SelectedNode.Text == "Background Color") { panelBgColor.Show(); } }

        private void SettingColorComboBox_SelectedIndexChanged(object sender, EventArgs e) { sApply.Enabled = true; }

        private void sOK_Click(object sender, EventArgs e)
        { Form1 formMain = (Form1)MdiParent; formMain.setBgColor(SettingColorComboBox.Text); Hide(); }

        private void sCancel_Click(object sender, EventArgs e) { Hide(); }

        private void sApply_Click(object sender, EventArgs e)
        { Form1 formMain = (Form1)MdiParent; formMain.setBgColor(SettingColorComboBox.Text); }
    }
}
