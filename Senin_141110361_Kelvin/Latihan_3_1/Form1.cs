using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        Font current;
        Random gauge = new Random();
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FontSizeComboBox.SelectedIndex = 1;
            FontComboBox.SelectedIndex = 6;
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Black.png");
        }

        private void BoldButton_Click(object sender, EventArgs e) {
            current = richTextBox1.SelectionFont;
            if (current.Bold == false) {
                if (current.Italic == true && current.Underline == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic); }
                else if (current.Italic == false && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Underline); }
                else if (current.Italic == true && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Bold); }
            }
            else {
                if (current.Italic == true && current.Underline == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Italic); }
                else if (current.Italic == false && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Underline); }
                else if (current.Italic == true && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Italic | FontStyle.Underline); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Regular); }
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e) {
            current = richTextBox1.SelectionFont;
            if (current.Italic == false) {
                if (current.Bold == true && current.Underline == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic); }
                else if (current.Bold == false && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Italic | FontStyle.Underline); }
                else if (current.Bold == true && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Italic); }
            }
            else {
                if (current.Bold == true && current.Underline == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold); }
                else if (current.Bold == false && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Underline); }
                else if (current.Bold == true && current.Underline == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Underline); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Regular); }
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e) {
            current = richTextBox1.SelectionFont;
            if (current.Underline == false) {
                if (current.Bold == true && current.Italic == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Underline); }
                else if (current.Bold == false && current.Italic == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Italic | FontStyle.Underline); }
                else if (current.Bold == true && current.Italic == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Underline); }
            }
            else {
                if (current.Bold == true && current.Italic == false) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold); }
                else if (current.Bold == false && current.Italic == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Italic); }
                else if (current.Bold == true && current.Italic == true) {
                    richTextBox1.SelectionFont = new Font(current, FontStyle.Bold | FontStyle.Italic); }
                else { richTextBox1.SelectionFont = new Font(current, FontStyle.Regular); }
            }
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            current = richTextBox1.SelectionFont;
            FontFamily fontfamily = new FontFamily(FontComboBox.Text);
            richTextBox1.SelectionFont = new Font(fontfamily, current.Size, current.Style);
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            current = richTextBox1.SelectionFont;
            float size = float.Parse(FontSizeComboBox.Text.ToString());
            richTextBox1.SelectionFont = new Font(current.FontFamily, size, current.Style);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionColor = colorDialog1.Color; }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionFont = fontDialog1.Font; }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Black.png"); richTextBox1.SelectionColor = Color.Black; }

        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Red.png"); richTextBox1.SelectionColor = Color.Red; }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Orange.png"); richTextBox1.SelectionColor = Color.Orange; }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Yellow.png"); richTextBox1.SelectionColor = Color.Yellow; }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Green.png"); richTextBox1.SelectionColor = Color.Green; }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Blue.png"); richTextBox1.SelectionColor = Color.Blue; }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/Purple.png");
            richTextBox1.SelectionColor = Color.FromArgb(192, 0, 192); }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDropDownButton.Image = new Bitmap("Images/Colors/White.png"); richTextBox1.SelectionColor = Color.White; }

        private void timer1_Tick(object sender, EventArgs e) {
            toolStripProgressBar1.Value = gauge.Next(toolStripProgressBar1.Minimum, toolStripProgressBar1.Maximum + 1); }
    }
}
