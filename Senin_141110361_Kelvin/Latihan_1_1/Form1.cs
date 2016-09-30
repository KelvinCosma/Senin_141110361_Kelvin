using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Scrolled(object sender, ScrollEventArgs e)
        {
            int A = hScrollBar1.Value > hScrollBar2.Value ? hScrollBar2.Value : hScrollBar1.Value;
            int B = hScrollBar1.Value > hScrollBar2.Value ? hScrollBar1.Value : hScrollBar2.Value;
            Scrollvalue1.Text = hScrollBar1.Value.ToString();
            Scrollvalue2.Text = hScrollBar2.Value.ToString();
            MinTxt.Text = "Min Value : " + A.ToString();
            MaxTxt.Text = "Max Value : " + B.ToString();
            DateStat.MinDate = DateTime.Today;
            DateStat.MaxDate = DateTime.Today.AddYears(Math.Abs(A - B));
        }
    }
}
