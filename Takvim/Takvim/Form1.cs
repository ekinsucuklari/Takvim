using System.Data.SqlClient;

namespace Takvim
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source = Ozlem\\SQLEXPRESS; Initial Catalog = kullanici_bilgi; Integrated Security= TRUE");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
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
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Red;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = Convert.ToChar(nothing);
            }
        }
        bool isHere;
        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Giris", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (username == reader["username"].ToString().TrimEnd() && password == reader["password"].ToString().TrimEnd())
                {
                    isHere = true;
                    break;
                }
                else
                {
                    isHere = false;
                }
            }
            if(isHere)
            {
                MessageBox.Show("Giriþ yapýlýyor..");
            }
            else
            {
                MessageBox.Show("Giriþ baþarýsýz");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}