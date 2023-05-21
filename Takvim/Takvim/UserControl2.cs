using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim
{
    public partial class UserControl2 : UserControl
    {
        public static string static_days;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            labelday.Text = numday + "";
        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
            static_days = labelday.Text;
            //this.Hide();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
