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

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        Random gauge = new Random();
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            foreach (FontFamily f in FontFamily.Families) { FontComboBox.Items.Add(f.Name); }
            for (double i = 6; i <= 72; i++) { FontSizeComboBox.Items.Add(i); }
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                  BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList) { this.ColorComboBox.Items.Add(c.Name); }
            FontSizeComboBox.SelectedIndex = 6;
            FontComboBox.SelectedItem = "Times New Roman";
            ColorComboBox.SelectedIndex = 8;
            CheckText();
            richTextBox1.ForeColor = Color.Black;            
        }

        private void ColorComboBox_DrawItem(object sender, DrawItemEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0) {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 8, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e) {
            BoldButton.Checked = false;
            ItalicButton.Checked = false;
            UnderlineButton.Checked = false;
            if (richTextBox1.SelectionFont != null) {
                FontComboBox.Text = richTextBox1.SelectionFont.FontFamily.Name;
                FontSizeComboBox.Text = richTextBox1.SelectionFont.Size.ToString();
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") >= 0) { BoldButton.Checked = true; }
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") >= 0) { ItalicButton.Checked = true; }
                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") >= 0) { UnderlineButton.Checked = true; }
            }
            else {
                FontComboBox.Text = "";
                FontSizeComboBox.Text = "";
            }
            if (richTextBox1.SelectionColor.Name == "0") { ColorComboBox.Text = "Black"; }
            else { ColorComboBox.Text = richTextBox1.SelectionColor.Name; }
        }

        private void BoldButton_Click(object sender, EventArgs e) { CheckText("bold"); }

        private void ItalicButton_Click(object sender, EventArgs e) { CheckText("italic"); }

        private void UnderlineButton_Click(object sender, EventArgs e) { CheckText("underline"); }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e) { CheckText(); }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e) { CheckText(); }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.SelectionColor = Color.FromName(ColorComboBox.Text);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionColor = colorDialog1.Color; }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionFont = fontDialog1.Font; }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            toolStripProgressBar1.Value = gauge.Next(toolStripProgressBar1.Minimum, toolStripProgressBar1.Maximum + 1); }

        private void CheckText(string text = null){
            bool isBold, isItalic, isUnderline;
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;
            string currentFontFamily;
            float currentSize;
            FontStyle currentFontStyle;
            this.richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
            if (length == 0) {
                currentFontFamily = (FontComboBox.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : FontComboBox.Text;
                currentSize = (FontSizeComboBox.Text == "") ? richTextBox1.SelectionFont.Size : Single.Parse(FontSizeComboBox.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic;
                isUnderline = richTextBox1.SelectionFont.Underline;

                if (text == "bold") { isBold = BoldButton.Checked; }
                if (text == "italic") { isItalic = ItalicButton.Checked; }
                if (text == "underline") { isUnderline = UnderlineButton.Checked; }

                currentFontStyle = (isBold) ? FontStyle.Bold : FontStyle.Regular;
                currentFontStyle |= (isItalic) ? FontStyle.Italic : FontStyle.Regular;
                currentFontStyle |= (isUnderline) ? FontStyle.Underline : FontStyle.Regular;

                richTextBox1.SelectionFont = new Font(currentFontFamily, currentSize, currentFontStyle);
            }
            for (int i = start; i < start + length; i++) {
                richTextBox1.SelectionChanged -= new System.EventHandler(richTextBox1_SelectionChanged);
                richTextBox1.Select(i, 1);
                currentFontFamily = (FontComboBox.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : FontComboBox.Text;
                currentSize = (FontSizeComboBox.Text == "") ? richTextBox1.SelectionFont.Size : Single.Parse(FontSizeComboBox.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic; 
                isUnderline = richTextBox1.SelectionFont.Underline;

                if (text == "bold") { isBold = BoldButton.Checked; }
                if (text == "italic") { isItalic = ItalicButton.Checked; }
                if (text == "underline") { isUnderline = UnderlineButton.Checked; }

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
