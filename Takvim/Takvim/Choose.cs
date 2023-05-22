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

namespace Takvim
{
    public partial class Choose : Form
    {
        SqlConnection connection = Form1.connection;
        public Choose()
        {
            InitializeComponent();
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            string user_Choose = Form3.user;
            string date = EventForm.dateTxt;
            
            connection.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Olaylar WHERE username='"+user_Choose+"' AND eventDate='"+date+"';",connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = (int)cmd.ExecuteScalar();
            
            while (reader.Read())
            {
                string isim = reader["description"].ToString();
                 

                RadioButton radioButton = new RadioButton();
                radioButton.Text = isim;
               

                // Radio buttonları formun bir kontrolü olarak ekleyin veya başka bir panel, grup kutusu vb. içine ekleyin.
                panel1.Controls.Add(radioButton);
            }


            //RadioButton radioButton = new RadioButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
