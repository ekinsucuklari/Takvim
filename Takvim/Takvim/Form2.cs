using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Takvim
{
    public partial class Form2 : Form
    {
        SqlConnection connection=Form1.connection;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
            }
        }
         
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Red;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Password Again")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Red;
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Black;
            }
        }
        char? nothing = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = Convert.ToChar(nothing);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Password Again";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = Convert.ToChar(nothing);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Giris (username,password,re_password) values('" + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ')",connection); 
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleştirildi!");
        }
    }
}
