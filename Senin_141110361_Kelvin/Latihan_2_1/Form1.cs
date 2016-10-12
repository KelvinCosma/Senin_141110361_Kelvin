using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dmonth = new Dictionary<string, int>();
        string smonth = "";
        DateTime date;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            date = new DateTime(DateTime.Now.Year, 1, DateTime.Now.Day);
            for (int i = 1; i <= 12; i++) {
                smonth = date.ToString("MMMM");
                Month.Items.Add(smonth);
                dmonth.Add(smonth, i);
                date = date.AddMonths(1);
            }
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, 12, 28));
            for (DateTime i = new DateTime(2016, 1, 1); i.Year < 2017 ; i = i.AddDays(1)) {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday) {
                    monthCalendar1.AddBoldedDate(i);
                }
            }
            monthCalendar1.UpdateBoldedDates();
            Birth.Text = "Birth Date : 28 / 12 / 1996";
        }

        private void Month_SelectedItemChanged(object sender, EventArgs e) { Month.ForeColor = SystemColors.WindowText; }

        private void Bold_Click(object sender, EventArgs e) {
            BoldDateRange("bold");
            if (Month.Text != "Month") {
                monthCalendar1.AddAnnuallyBoldedDate(
                    new DateTime(DateTime.Now.Year, dmonth[Month.Text], Convert.ToInt32(Date.Value)));
                monthCalendar1.UpdateBoldedDates();
            }
        }

        private void De_Bold_Click(object sender, EventArgs e) {
            BoldDateRange("de-bold");
            if (Month.Text != "Month") {
                monthCalendar1.RemoveAnnuallyBoldedDate(
                    new DateTime(DateTime.Now.Year, dmonth[Month.Text], Convert.ToInt32(Date.Value)));
                monthCalendar1.UpdateBoldedDates();
            }
        }

        private void BoldDateRange(string action) {
            for (DateTime i = monthCalendar1.SelectionStart.Date; i <= monthCalendar1.SelectionEnd.Date; i = i.AddDays(1)) {
                if (action == "bold") { monthCalendar1.AddBoldedDate(i); }
                else if (action == "de-bold") { monthCalendar1.RemoveBoldedDate(i); }                
            }
            monthCalendar1.UpdateBoldedDates(); action = "";
        }
    }
}
