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
        SqlConnection connection = Form1.connection;
        public Choose()
        {
            InitializeComponent();
        }
        List<RadioButton> rbl = new List<RadioButton>();
        private void Choose_Load(object sender, EventArgs e)
        {

            string user_Choose = Form3.user;
            string date = UserControl2.static_days + "/" + Form3.static_month + "/" + Form3.static_year;

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE username='" + user_Choose + "' AND eventDate='" + date + "';", connection);

            SqlDataReader reader = cmd.ExecuteReader();

            int y = 65;
            int syc = 0;
            while (reader.Read())
            {
                string isim = reader["description"].ToString();
                RadioButton radioButton = new RadioButton();

                radioButton.Text = isim;
                radioButton.AutoSize = true;
                radioButton.Location = new Point(101, y);
                this.Controls.Add(radioButton);
                rbl.Add(radioButton);
                syc++;
                y += radioButton.Height + 10;
            }

            if (syc == 0)
            {

                label1.Text = "Bugün için bir etkinlik yok.";

            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)//yeni kayıt
        {
            EventForm eventForm = new EventForm();
            eventForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//güncelleme
        {
            foreach (RadioButton radioButton in rbl)
            {
                if (radioButton.Checked)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE description='" + radioButton.Text + "';", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                        reader.Read();
                        string start = reader.GetString(reader.GetOrdinal("startTime"));
                        string end = reader.GetString(reader.GetOrdinal("endTime"));
                        string evntD = reader.GetString(reader.GetOrdinal("eventDate"));
                        string descrip = reader.GetString(reader.GetOrdinal("description"));
                        string evntT = reader.GetString(reader.GetOrdinal("eventType"));
                        connection.Close();

                        SqlCommand cmdd = new SqlCommand("DELETE FROM Olaylar WHERE description='" + radioButton.Text + "';", connection);
                        connection.Open();
                        cmdd.ExecuteNonQuery();
                        connection.Close();

                        EventForm eventForm = new EventForm(start, end, evntT, evntD, descrip);
                        eventForm.Show();

                    }
                    connection.Close();
                }
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//silme
        {
            foreach (RadioButton radioButton in rbl)
            {
                if (radioButton.Checked)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Olaylar WHERE description='" + radioButton.Text + "';", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        connection.Close();

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
