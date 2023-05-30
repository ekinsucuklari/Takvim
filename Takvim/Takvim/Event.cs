using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Takvim
{
    public partial class EventForm : Form
    {
        //SQL bağlantıları açılır.
        SqlConnection connection = SingIn.connection;
        SqlConnection connection1 = SingIn.connection;
        public EventForm()
        {
            InitializeComponent();
        }
        public EventForm(string srt, string end, string evT, string evD, string desc)
        {
            //Güncelleme için değiştirilecek bilgiler çağrılıp metin kutularına yazdırılır.
            InitializeComponent();
            textBoxStart.Text = srt;
            textBoxEnd.Text = end;
            textBoxDescp.Text = desc;
            textBoxEventType.Text = evT;
            textBoxDate.Text = evD;
        }
        private void Event_Load(object sender, EventArgs e)
        {
            //Tıklanılan günün tarihi metin kutusuna yazdırılır ve değiştirilemez hale getirilir.
            textBoxDate.Text = Days.static_days + "/" + Takvim.static_month + "/" + Takvim.static_year;  
            textBoxDate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Girilen etkinlik bilgilerini SQL veritabanına aktarır.
            SqlCommand cmd = new SqlCommand("Insert into Olaylar (startTime,endTime,description,eventType,eventDate,username) values('" + textBoxStart.Text + "' , '" + textBoxEnd.Text + "' , '" + textBoxDescp.Text + "', '" + textBoxEventType.Text + "' ,  '" + textBoxDate.Text + "' ,  '" + Takvim.user + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }
    }
}
