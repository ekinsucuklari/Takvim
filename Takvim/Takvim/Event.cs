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
        SqlConnection connection1 = Form1.connection;
        public EventForm()
        {
            InitializeComponent();
        }
        public EventForm(string srt, string end, string evT, string evD, string desc)
        {
            InitializeComponent();
            textBoxStart.Text = srt;
            textBoxEnd.Text = end;
            textBoxDescp.Text = desc;
            textBoxEventType.Text = evT;
            textBoxDate.Text = evD;
        }
        private void Event_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = UserControl2.static_days + "/" + Form3.static_month + "/" + Form3.static_year;
            dateTxt = textBoxDate.Text;//ihtiyaç mı?
            textBoxDate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Olaylar (startTime,endTime,description,eventType,eventDate,username) values('" + textBoxStart.Text + "' , '" + textBoxEnd.Text + "' , '" + textBoxDescp.Text + "', '" + textBoxEventType.Text + "' ,  '" + textBoxDate.Text + "' ,  '" + Form3.user + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }
    }
}
