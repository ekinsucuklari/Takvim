using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim
{
    public partial class Form3 : Form
    {
        int month, year;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthName + "    " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            if (daysoftheweek == 0)
            {
                daysoftheweek = 7;
            }

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
                month++;
            
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthName + "    " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            if (daysoftheweek == 0)
            {
                daysoftheweek = 7;
            }

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            if (month == 1)
            {
                year--;
                month = 13;
            }
            
            month--;
            
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthName + "    " + year;

            DateTime startofthemonth = new DateTime(year, month , 1);

            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            if (daysoftheweek == 0)
            {
                daysoftheweek = 7;
            }
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
