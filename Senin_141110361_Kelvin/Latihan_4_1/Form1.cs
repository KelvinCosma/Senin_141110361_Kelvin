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

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        string filepath = "";
        bool edited = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily f in FontFamily.Families) { FontFamily_comboBox.Items.Add(f.Name); }
            for (double i = 6; i <= 72; i++) { FontSize_comboBox.Items.Add(i); }
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                  BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) {
                this.Color_comboBox.Items.Add(c.Name);
                this.BackColor_comboBox.Items.Add(c.Name);
            }
            FontSize_comboBox.SelectedIndex = 6;
            FontFamily_comboBox.SelectedItem = "Times New Roman";
            Color_comboBox.SelectedIndex = 8;
            BackColor_comboBox.SelectedIndex = 137;
            richTextBox1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
        }

        private void Color_comboBox_DrawItem(object sender, DrawItemEventArgs e) {
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

        private void BackColor_comboBox_DrawItem(object sender, DrawItemEventArgs e) {
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

        private void richTextBox1_SelectionChanged(object sender, EventArgs e) {
            Bold_Button.Checked = false;
            Italic_Button.Checked = false;
            Underline_Button.Checked = false;
            if (richTextBox1.SelectionFont != null) {
                FontFamily_comboBox.Text = richTextBox1.SelectionFont.FontFamily.Name;
                FontSize_comboBox.Text = richTextBox1.SelectionFont.Size.ToString();
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") >= 0) { Bold_Button.Checked = true; }
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") >= 0) { Italic_Button.Checked = true; }
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") >= 0) { Underline_Button.Checked = true; }
            }
            else {
                FontFamily_comboBox.Text = "";
                FontSize_comboBox.Text = "";
            }
            if (richTextBox1.SelectionColor.Name == "0") { Color_comboBox.Text = "Black"; }
            else { Color_comboBox.Text = richTextBox1.SelectionColor.Name; }
            if (richTextBox1.SelectionBackColor.Name == "0") { BackColor_comboBox.Text = "White"; }
            else { BackColor_comboBox.Text = richTextBox1.SelectionBackColor.Name; }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            edited = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                DialogResult New_Respond = MessageBox.Show("Do you want to save changes?", 
                    "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (New_Respond == DialogResult.Yes) {
                    if (filepath == "") {
                        SaveFileDialog nsave = new SaveFileDialog();
                        nsave.Filter = "RTF Files|*.rtf;";
                        if (nsave.ShowDialog() == DialogResult.OK) {
                            filepath = nsave.FileName;
                            richTextBox1.SaveFile(filepath);
                            edited = false;
                            MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                        }
                        else {  }
                    }
                    else {
                        richTextBox1.SaveFile(filepath);
                        edited = false;
                        MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                    }
                }
                else if (New_Respond == DialogResult.No) {
                    filepath = "";
                    richTextBox1.Clear();
                    edited = false;
                }
                else { }
            }
            else {
                filepath = "";
                richTextBox1.Clear();
                edited = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                DialogResult Open_Respond = MessageBox.Show("Do you want to save changes?",
                    "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Open_Respond == DialogResult.Yes) {
                    if (filepath == "") {
                        SaveFileDialog osave = new SaveFileDialog();
                        osave.Filter = "RTF Files|*.rtf;";
                        if (osave.ShowDialog() == DialogResult.OK) {
                            filepath = osave.FileName;
                            richTextBox1.SaveFile(filepath);
                            edited = false;
                            MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                        }
                        else { }
                    }
                    else {
                        richTextBox1.SaveFile(filepath);
                        edited = false;
                        MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                    }
                }
                else if (Open_Respond == DialogResult.No) {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "RTF Files|*.rtf;";
                    if (open.ShowDialog() == DialogResult.OK) {
                        filepath = open.FileName;
                        richTextBox1.LoadFile(filepath);
                        edited = false;
                        MessageBox.Show("File Open.", "Info", MessageBoxButtons.OK);
                    }
                    else { }
                }
                else { }
            }
            else {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "RTF Files|*.rtf;";
                if (open.ShowDialog() == DialogResult.OK) {
                    filepath = open.FileName;
                    richTextBox1.LoadFile(filepath);
                    edited = false;
                    MessageBox.Show("File Open.", "Info", MessageBoxButtons.OK);
                }
                else { }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (filepath == "") {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "RTF Files|*.rtf;";
                if (save.ShowDialog() == DialogResult.OK) {
                    filepath = save.FileName;
                    richTextBox1.SaveFile(filepath);
                    edited = false;
                    MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                }
                else { }
            }
            else {
                richTextBox1.SaveFile(filepath);
                edited = false;
                MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (edited) {
                DialogResult Exit_Respond = MessageBox.Show("Do you want to save changes?", 
                    "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Exit_Respond == DialogResult.Yes) {
                    if (filepath == "") {
                        SaveFileDialog esave = new SaveFileDialog();
                        esave.Filter = "RTF Files|*.rtf;";
                        if (esave.ShowDialog() == DialogResult.OK) {
                            filepath = esave.FileName;
                            richTextBox1.SaveFile(filepath);
                            edited = false;
                            MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                            Application.ExitThread();
                        }
                        else {  }
                    }
                    else {
                        richTextBox1.SaveFile(filepath);
                        edited = false;
                        MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                        Application.ExitThread();
                    }
                }
                else if (Exit_Respond == DialogResult.No) { Application.ExitThread(); }
                else {  }
            }
            else { Application.ExitThread(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (edited) {
                DialogResult Exit_Respond = MessageBox.Show("Do you want to save changes?", 
                    "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (Exit_Respond == DialogResult.Yes) {
                    if (filepath == "") {
                        SaveFileDialog esave = new SaveFileDialog();
                        esave.Filter = "RTF Files|*.rtf;";
                        if (esave.ShowDialog() == DialogResult.OK) {
                            filepath = esave.FileName;
                            richTextBox1.SaveFile(filepath);
                            edited = false;
                            MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                            Application.ExitThread();
                        }
                        else {  }
                    }
                    else {
                        richTextBox1.SaveFile(filepath);
                        edited = false;
                        MessageBox.Show("File Save.", "Info", MessageBoxButtons.OK);
                        Application.ExitThread();
                    }
                }
                else if (Exit_Respond == DialogResult.No) { Application.ExitThread(); }
                else { e.Cancel = true; }
            }
            else { Application.ExitThread(); }
        }

        private void Bold_Button_Click(object sender, EventArgs e) { CheckText("bold"); }

        private void Italic_Button_Click(object sender, EventArgs e) { CheckText("italic"); }

        private void Underline_Button_Click(object sender, EventArgs e) { CheckText("underline"); }

        private void FontSize_comboBox_SelectedIndexChanged(object sender, EventArgs e) { CheckText(); }

        private void FontFamily_comboBox_SelectedIndexChanged(object sender, EventArgs e) { CheckText(); }

        private void Color_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.SelectionColor = Color.FromName(Color_comboBox.Text);
        }

        private void BackColor_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.SelectionBackColor = Color.FromName(BackColor_comboBox.Text);
        }

        private void CheckText(string text = null) {
            bool isBold, isItalic, isUnderline;
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;
            string currentFontFamily;
            float currentSize;
            FontStyle currentFontStyle;
            this.richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
            if (length == 0) {
                currentFontFamily = (FontFamily_comboBox.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : FontFamily_comboBox.Text;
                currentSize = (FontSize_comboBox.Text == "") ? richTextBox1.SelectionFont.Size : Single.Parse(FontSize_comboBox.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic;
                isUnderline = richTextBox1.SelectionFont.Underline;

                if (text == "bold") { isBold = Bold_Button.Checked; }
                if (text == "italic") { isItalic = Italic_Button.Checked; }
                if (text == "underline") { isUnderline = Underline_Button.Checked; }

                currentFontStyle = (isBold) ? FontStyle.Bold : FontStyle.Regular;
                currentFontStyle |= (isItalic) ? FontStyle.Italic : FontStyle.Regular;
                currentFontStyle |= (isUnderline) ? FontStyle.Underline : FontStyle.Regular;

                richTextBox1.SelectionFont = new Font(currentFontFamily, currentSize, currentFontStyle);
            }
            for (int i = start; i < start + length; i++) {
                richTextBox1.SelectionChanged -= new System.EventHandler(richTextBox1_SelectionChanged);
                richTextBox1.Select(i, 1);
                currentFontFamily = (FontFamily_comboBox.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : FontFamily_comboBox.Text;
                currentSize = (FontSize_comboBox.Text == "") ? richTextBox1.SelectionFont.Size : Single.Parse(FontSize_comboBox.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic;
                isUnderline = richTextBox1.SelectionFont.Underline;

                if (text == "bold") { isBold = Bold_Button.Checked; }
                if (text == "italic") { isItalic = Italic_Button.Checked; }
                if (text == "underline") { isUnderline = Underline_Button.Checked; }

                currentFontStyle = (isBold) ? FontStyle.Bold : FontStyle.Regular;
                currentFontStyle |= (isItalic) ? FontStyle.Italic : FontStyle.Regular;
                currentFontStyle |= (isUnderline) ? FontStyle.Underline : FontStyle.Regular;

                richTextBox1.SelectionFont = new Font(currentFontFamily, currentSize, currentFontStyle);
            }
            richTextBox1.Focus();
            richTextBox1.Select(start, length);
            richTextBox1.SelectionChanged += new System.EventHandler(richTextBox1_SelectionChanged);
        }
    }
}

