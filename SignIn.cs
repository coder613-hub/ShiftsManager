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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var oldUser = db.USERs.FirstOrDefault(u => u.username == username_text.Text
                        && u.password == password_text.Text);
                if (oldUser != null)
                {
                    UserSession.UserId = oldUser.user_id;
                    error_label.Text = "";

                    this.Hide();

                    var user = db.USERs.FirstOrDefault(u => u.user_id == UserSession.UserId);
                    if(user.user_type_id == 1)
                    {
                        UserHomePage home = new UserHomePage();
                        home.Show();
                    }
                    else
                    {
                        AdminHomePage admin = new AdminHomePage();
                        admin.Show();
                    }
                }
                else
                {
                    error_label.Text = "Invalid username or password. Please try again.";
                }
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
