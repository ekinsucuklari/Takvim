using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace Takvim
{
    public partial class Form3 : Form
    {
        SqlConnection connection = Form1.connection;

        private Timer timer;
        int month, year;
        public static string user;
        public static int static_month, static_year;
        bool isAlarmPlaying = false;
        public Form3(string username)
        {
            user = username;
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 15000;
            timer.Tick += Timer_Tick;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Text = user;
            displayDays();
            timer.Start();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;
            static_month = month;
            static_year = year;

            ChangeBackground(static_month);

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

            static_month = month;
            static_year = year;
            ChangeBackground(static_month);

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

            static_month = month;
            static_year = year;
            ChangeBackground(static_month);
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
        void ChangeBackground(int month)
        {
            if (month == 12 || month < 3)
            {
                this.BackColor = Color.Blue;
            }
            else if (month < 6 && month > 2)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\ilkbahar.png");
                daycontainer.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\ilkbahar.png");
                //this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (month < 9 && month > 5)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\yaz.png");
                daycontainer.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\yaz.png");
                // this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (month < 12 && month > 8)
            {
                this.BackColor = Color.Orange;
            }

        }

        void AlarmRing()
        {
            DateTime currentTime = DateTime.Now;
            string sqlCurrentDay = currentTime.Day.ToString() + "/" + currentTime.Month.ToString() + "/" + currentTime.Year.ToString();
            string sqlCurrentHour = currentTime.Hour.ToString() + ":" + currentTime.Minute.ToString();

            if (!connection.State.Equals(ConnectionState.Open))
                connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT startTime FROM Olaylar WHERE username = '" + user + "' AND eventDate='" + sqlCurrentDay + "' AND startTime='" + sqlCurrentHour + "';", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                string zaman = reader["startTime"].ToString();
                if (!isAlarmPlaying)
                {
                    SoundPlayer player = new SoundPlayer("C:\\Users\\moonm\\Downloads\\gitar.wav");
                    player.PlayLooping();
                    MessageBox.Show("Çalıştı alarm düt düt");
                    isAlarmPlaying = true;
                }
                if (isAlarmPlaying)
                {
                    SoundPlayer player = new SoundPlayer();
                    player.Stop();
                    isAlarmPlaying = false;
                }

            }
            reader.Close();
            connection.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AlarmRing();
        }
    }
}
