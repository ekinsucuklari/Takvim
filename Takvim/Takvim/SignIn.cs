using System.Data.SqlClient;

namespace Takvim
{
    public partial class SingIn : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source = Ozlem\\SQLEXPRESS; Initial Catalog = kullanici_bilgi; Integrated Security= TRUE");//SQL baðlantýsý kurulur
        public string whosThere; //Kullanýcý adýnýn tutulmasý için oluþturulan deðiþken , diðer formlara yollanýyor.
        public SingIn()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)//Kullanýcý adý girilmesi için textbox.
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)//Þifre girilmesi için textbox.
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        char? nothing = null;//ToChar fonksiyonu içerisinde kullanmak için oluþturuldu.
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(nothing);
            }
        }
        bool isHere;
        private void button1_Click(object sender, EventArgs e)//Giriþ butonu.
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();//SQL baðlantýsý açýldý.
            SqlCommand cmd = new SqlCommand("Select username,password from Kayit", connection);//Kayýt veritabanýndan kullanýcý adý ve þifre çekildi.
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Girilen kullanýcý adý ve þifre , veritabanýndakilerle eþitse giriþ yapýlabilir.
                if (username == reader["username"].ToString().TrimEnd() && password == reader["password"].ToString().TrimEnd())
                {
                    whosThere = username;
                    isHere = true;
                    break;
                }
                else
                {
                    isHere = false;
                }
            }
            connection.Close();//SQL baðlantýsý kapatýlýr.
            if (isHere)
            {   //Giriþ iþlemi baþarýlý olunca çalýþýr.
                MessageBox.Show("Giriþ yapýlýyor..");
                this.Hide();
                Takvim takv = new Takvim(whosThere);
                takv.Show();
            }
            else
            {
                MessageBox.Show("Giriþ baþarýsýz");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Yeni kullanýcý kayýt olmak isterse SignUp ekranýna yönlendirilir.
            this.Hide();
            SignUp SignUp = new SignUp();
            SignUp.Show();
        }


    }
}