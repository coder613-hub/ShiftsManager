using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftsManager
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void AdminHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSession.UserId = 0;
            SignIn signin = new SignIn();
            signin.Show();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakePayment payment = new MakePayment();
            payment.Show();
        }

        private void rate_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdjustRate rate = new AdjustRate();
            rate.Show();
        }

        private void time_button_Click(object sender, EventArgs e)
        {

        }
    }
}
