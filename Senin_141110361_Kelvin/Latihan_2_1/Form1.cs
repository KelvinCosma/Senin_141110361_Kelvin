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
        DateTime date, sat2016 = new DateTime (2016, 1, 2), sun2016 = new DateTime(2016, 1, 3);

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
            for (int i = 0; i < 53; i++) {
                monthCalendar1.AddBoldedDate(sat2016); sat2016 = sat2016.AddDays(7);
                monthCalendar1.AddBoldedDate(sun2016); sun2016 = sun2016.AddDays(7);
            }
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, 12, 28));
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
