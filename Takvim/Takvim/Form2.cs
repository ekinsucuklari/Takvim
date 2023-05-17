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
        SqlConnection connection = Form1.connection;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Surname")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Red;

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Username")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Red;

            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Red;
                textBox4.PasswordChar = '*';
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "TCKN")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Red;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Phone Number")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Red;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "E-Mail")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Red;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Adress")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Red;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = Color.Black;
            }
        }
        char? nothing = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Surname";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Username";
                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Password";
                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = Convert.ToChar(nothing);
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "TCKN";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Phone Number";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "E-Mail";
                textBox7.ForeColor = Color.Black;
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Adress";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into Kayit (name,surname,username,password,tc_no,tel_no,e_mail,adres) values('"+textBox1.Text + "' , '"+textBox2.Text+"' , '"+textBox3.Text + "', '"+textBox4.Text + "' ,  '" + textBox5.Text + "' ,  '"+ textBox6.Text +"', '"+ textBox7.Text +"', '"+ textBox8.Text +"')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleştirildi!");
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
