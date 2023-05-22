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
        public static string dateTxt;

        SqlConnection connection = Form1.connection;
        public EventForm()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = UserControl2.static_days + "/" + Form3.static_month + "/" + Form3.static_year;
            dateTxt = textBoxDate.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Olaylar (startTime,endTime,description,eventType,eventDate,username) values('" + textBoxStart.Text+ "' , '" + textBoxEnd.Text + "' , '" + textBoxDescp.Text + "', '" + textBoxEventType.Text + "' ,  '" + textBoxDate.Text + "' ,  '" + Form3.user + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }
    }
}
