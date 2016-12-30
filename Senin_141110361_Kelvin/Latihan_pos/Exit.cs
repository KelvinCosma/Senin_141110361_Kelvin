using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_pos
{
    public partial class Exit : MetroFramework.Forms.MetroForm
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
