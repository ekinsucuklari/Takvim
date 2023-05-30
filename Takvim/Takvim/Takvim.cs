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
    public partial class Takvim : Form
    {
        SqlConnection connection = SingIn.connection;

        private Timer timer; //Alarm için oluşturuldu.
        int month, year; //Ay ve yılı tutan global değişkenler.
        public static string user; //Kullanıcı adını tutan değişken.
        public static int static_month, static_year; //Ay ve yılı başka formlara göndermek için tutan static değişkenler.
        bool isAlarmPlaying = false; //Alarmın çaldığını kontrol eden değişken.
        public Takvim(string username)
        {
            user = username;
            InitializeComponent();
            timer = new Timer();
            //15 saniyede bir alarmı çalıştırır.
            timer.Interval = 15000;
            timer.Tick += Timer_Tick;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Text = user; //Takvim ekranında kullanıcı adını yazdırmaya yarar.
            displayDays();
            timer.Start();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now; //Sistem tarihini tutan değişken.
            //Sistem saatine göre ay ve yıl eklendi.
            month = now.Month;
            year = now.Year;
            static_month = month;
            static_year = year;

            ChangeBackground(static_month);

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);//Ayın adını çeker.
            LBLDATE.Text = monthName + "    " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);//Ayın ilk gününü çeker.

            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            MonthDaysCreate(daysoftheweek, days);

        }

        private void button1_Click(object sender, EventArgs e) //Next Butonu
        {

            daycontainer.Controls.Clear(); //Tüm paneli temizler.
            //Aralık ayına geldiğinde month değişkenini ocak olarak değiştirip yılı bir arttırır.
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

            MonthDaysCreate(daysoftheweek, days);
        }
        private void button2_Click(object sender, EventArgs e)//Previous Butonu
        {
            daycontainer.Controls.Clear();
            //Ocak ayına geldiğinde month değişkenini aralık olarak değiştirip yılı bir azaltır.
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

            MonthDaysCreate(daysoftheweek,days);

        }

        void MonthDaysCreate(int daysoftheweek , int days)
        {
            if (daysoftheweek == 0)
            {
                daysoftheweek = 7;
            }

            for (int i = 1; i < daysoftheweek; i++)
            {
                //Ayın ilk gününe kadar olan kısımlara boş userControl oluşturulur.
                Empty ucblank = new Empty();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                //Ayın ilk gününden itibaren günlerini sırasıyla yazan userController oluşturulur.
                Days ucdays = new Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        void ChangeBackground(int month)//Mevsimlere göre arka plan resmi değiştirir.
        {
            if (month == 12 || month < 3)//Kış ayları için
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\kış.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(165, 215, 232);
            }
            else if (month < 6 && month > 2)//İlkbahar ayları için
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\ilkbahar.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(206, 216, 158);
            }
            else if (month < 9 && month > 5)//Yaz ayları için
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\yaz.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(239, 228, 176);
            }
            else if (month < 12 && month > 8)//Sonbahar ayları için
            {
                this.BackgroundImage = Image.FromFile("C:\\Users\\moonm\\OneDrive\\Masaüstü\\Takvim\\sonbahar.png");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                daycontainer.BackColor = Color.FromArgb(156, 167, 119);
            }

        }

        void AlarmRing()
        {
            DateTime current = DateTime.Now;//Sistem tarihi ve saati alınır.
            string sqlCurrentTime = current.Hour.ToString("00") + ":" + current.Minute.ToString("00");//İki basamaklı sistem saati alınır
            string sqlCurrentDate = current.Day.ToString() + "/" + current.Month.ToString() + "/" + current.Year.ToString();//Sistem saatinin sadece tarihi alınır
            string connstring = "Data Source = Ozlem\\SQLEXPRESS; Initial Catalog = kullanici_bilgi; Integrated Security= TRUE";//SQL bağlantısı tekrar kurulur.
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();


                string query = "SELECT * FROM Olaylar WHERE username='" + user + "';";//Kullanıcı adına ait tüm bilgiler çağırılır

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string eventDate = (string)reader["eventDate"].ToString();
                        string startDate = (string)reader["startTime"].ToString();
                        //Eğer sistem saati ve günüyle SQL'deki Satırda eventDate ve startTime aynı ise alarm çalar
                        if (eventDate == sqlCurrentDate && startDate == sqlCurrentTime)
                        {
                            isAlarmPlaying = true;
                            SoundPlayer player = new SoundPlayer("C:\\Users\\moonm\\OneDrive\\Masaüstü\\gitar.wav");
                            player.PlayLooping();
                            MessageBox.Show("Bugün içerisinde bir etkinliğiniz var!");

                            if (isAlarmPlaying == true)//mesegabox kapandığında alarm sesi de kapanır.
                            {
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
        private void Timer_Tick(object sender, EventArgs e)//15 saniyede bir AlarmRing metodunu çağırır.
        {
            AlarmRing();
        }

    }
}
