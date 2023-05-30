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
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\kış.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(165, 215, 232);
            }
            else if (month < 6 && month > 2)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\ilkbahar.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(206, 216, 158);
            }
            else if (month < 9 && month > 5)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\yaz.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(239, 228, 176);
            }
            else if (month < 12 && month > 8)
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\sonbahar.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(156, 167, 119);
            }

        }

        void AlarmRing()
        {
            DateTime current = DateTime.Now;
            string sqlCurrentTime = current.Hour.ToString("00") + ":" + current.Minute.ToString("00");
            string sqlCurrentDate = current.Day.ToString()+"/"+current.Month.ToString()+"/"+current.Year.ToString();
            string connstring = "Data Source = Ozlem\\SQLEXPRESS; Initial Catalog = kullanici_bilgi; Integrated Security= TRUE";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();


                string query = "SELECT * FROM Olaylar WHERE username='" + user + "';";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string eventDate = (string)reader["eventDate"].ToString();
                        string startDate = (string)reader["startTime"].ToString();
                        
                        if (eventDate == sqlCurrentDate && startDate == sqlCurrentTime)
                        {
                            isAlarmPlaying=true;
                            SoundPlayer player = new SoundPlayer("C:\\Users\\moonm\\OneDrive\\Masaüstü\\gitar.wav");
                            player.PlayLooping();
                            MessageBox.Show("Bugün içerisinde bir etkinliğiniz var!");
                            
                            if (isAlarmPlaying==true) {
                                player.Stop();
                             }
                            break;
                        }
                        
                    }

                    reader.Close();
                }

                connection.Close();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            AlarmRing();
        }

    }
}
