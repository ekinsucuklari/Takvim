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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Takvim
{
    public partial class Choose : Form
    {
        SqlConnection connection = SingIn.connection;
        public Choose()
        {
            InitializeComponent();
        }
        List<RadioButton> rbl = new List<RadioButton>();//Oluşturulan radiobutonlarını tutmak için liste
        private void Choose_Load(object sender, EventArgs e)
        {

            string user_Choose = Takvim.user;//Aynı kullanıcı adını kullanabilmek için
            string date = Days.static_days + "/" + Takvim.static_month + "/" + Takvim.static_year;//Tarihi kullanmak için

            connection.Open();
            //SQL'deki aynı kullanıcı adı ve etkiblik tarihine sahip olan bütün satırlar çekilir.
            SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE username='" + user_Choose + "' AND eventDate='" + date + "';", connection);

            SqlDataReader reader = cmd.ExecuteReader();

            int y = 65;//kaçıncı pixelden başlayacağı
            int syc = 0;
            while (reader.Read())
            {
                string aciklama = reader["description"].ToString();//Açıklama satırı atanır
                RadioButton radioButton = new RadioButton();

                radioButton.Text = aciklama;//Oluşturulan radiobutonlarına bu açıklamalar atanır
                radioButton.AutoSize = true;
                radioButton.Location = new Point(101, y);
                radioButton.BackColor = Color.Transparent;
                this.Controls.Add(radioButton);//Forma radiobutonu eklenir
                rbl.Add(radioButton);
                syc++;//sayac arttırılır ki etkinlik var mı yok mu tespit etmek için kullanılacak
                y += radioButton.Height + 10;
            }

            if (syc == 0)//Eğer sayaç 0 ise hiç etkinlik yoktur
            {

                label1.Text = "Bugün için bir etkinlik yok.";

            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)//yeni kayıt
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//güncelleme
        {
            foreach (RadioButton radioButton in rbl)//Listedeki her raddiobutonuna bakılır
            {
                if (radioButton.Checked)//seçilen radio butonu varsa tıklandığında bunun üzerinden işlem yapılır
                {
                    connection.Open();
                    //seçilen radiobutonun text'i ile SQL'de description satırı aynı olan tüm satırlar çekilir
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE description='" + radioButton.Text + "' AND username='"+Takvim.user+"';", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Değiştirilicek değerler atanır
                        reader.Read();
                        string start = reader.GetString(reader.GetOrdinal("startTime"));
                        string end = reader.GetString(reader.GetOrdinal("endTime"));
                        string evntD = reader.GetString(reader.GetOrdinal("eventDate"));
                        string descrip = reader.GetString(reader.GetOrdinal("description"));
                        string evntT = reader.GetString(reader.GetOrdinal("eventType"));
                        connection.Close();
                        //Kayıt SQL'den silinir çünkü Event formunda bir daha kaydedilecektir
                        SqlCommand cmdd = new SqlCommand("DELETE FROM Olaylar WHERE description='" + radioButton.Text + "';", connection);
                        connection.Open();
                        cmdd.ExecuteNonQuery();
                        connection.Close();

                        EventForm eventForm = new EventForm(start, end, evntT, evntD, descrip);
                        eventForm.ShowDialog();
                    }
                    connection.Close();
                }
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//silme
        {
            foreach (RadioButton radioButton in rbl)//Listedeki her raddiobutonuna bakılır
            {
                if (radioButton.Checked)//seçilen radio butonu varsa tıklandığında bunun üzerinden işlem yapılır
                {
                    //seçilen radiobutonun text'i ile SQL'de description satırı aynı olan tüm satırlar çekilir
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE description='" + radioButton.Text + "' AND username='" + Takvim.user + "';", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        connection.Close();
                        //Kayıt SQL'den silinir.
                        SqlCommand cmdd = new SqlCommand("DELETE FROM Olaylar WHERE description='" + radioButton.Text + "';", connection);
                        connection.Open();
                        cmdd.ExecuteNonQuery();
                        connection.Close();
                    }
                    connection.Close();
                }
            }
            this.Hide();
        }
    }
}
