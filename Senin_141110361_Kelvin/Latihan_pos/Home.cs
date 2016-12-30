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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(360, 480);
            this.MaximumSize = new Size(360, 480);
            this.ControlBox = false;
        }

        private void DataListBtn_Click(object sender, EventArgs e)
        {
            DataList dataListForm = new DataList();
            this.Hide();
            dataListForm.ShowDialog();
            this.Show();
        }

        private void InsertDataBtn_Click(object sender, EventArgs e)
        {
            InsertData insertDataForm = new InsertData();
            this.Hide();
            insertDataForm.ShowDialog();
            this.Show();
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            UpdateData updateDataForm = new UpdateData();
            this.Hide();
            updateDataForm.ShowDialog();
            this.Show();
        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {
            DeleteData deleteDataForm = new DeleteData();
            this.Hide();
            deleteDataForm.ShowDialog();
            this.Show();
        }

        private void TransactionListBtn_Click(object sender, EventArgs e)
        {
            TransactionList transactionListForm = new TransactionList();
            this.Hide();
            transactionListForm.ShowDialog();
            this.Show();
        }

        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            AddTransaction addTransactionForm = new AddTransaction();
            this.Hide();
            addTransactionForm.ShowDialog();
            this.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit exitForm = new Exit();
            exitForm.StartPosition = FormStartPosition.CenterParent;
            exitForm.ShowDialog(this);
        }
    }
}
