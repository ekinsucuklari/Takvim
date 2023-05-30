using System.Data.SqlClient;

namespace Takvim
{
    public partial class SingIn : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source = Ozlem\\SQLEXPRESS; Initial Catalog = kullanici_bilgi; Integrated Security= TRUE");//SQL ba�lant�s� kurulur
        public string whosThere; //Kullan�c� ad�n�n tutulmas� i�in olu�turulan de�i�ken , di�er formlara yollan�yor.
        public SingIn()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)//Kullan�c� ad� girilmesi i�in textbox.
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

        private void textBox2_Enter(object sender, EventArgs e)//�ifre girilmesi i�in textbox.
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        char? nothing = null;//ToChar fonksiyonu i�erisinde kullanmak i�in olu�turuldu.
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
        private void button1_Click(object sender, EventArgs e)//Giri� butonu.
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            connection.Open();//SQL ba�lant�s� a��ld�.
            SqlCommand cmd = new SqlCommand("Select username,password from Kayit", connection);//Kay�t veritaban�ndan kullan�c� ad� ve �ifre �ekildi.
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Girilen kullan�c� ad� ve �ifre , veritaban�ndakilerle e�itse giri� yap�labilir.
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
            connection.Close();//SQL ba�lant�s� kapat�l�r.
            if (isHere)
            {   //Giri� i�lemi ba�ar�l� olunca �al���r.
                MessageBox.Show("Giri� yap�l�yor..");
                this.Hide();
                Takvim takv = new Takvim(whosThere);
                takv.Show();
            }
            else
            {
                MessageBox.Show("Giri� ba�ar�s�z");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//Yeni kullan�c� kay�t olmak isterse SignUp ekran�na y�nlendirilir.
            this.Hide();
            SignUp SignUp = new SignUp();
            SignUp.Show();
        }


    }
}