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
    public partial class AdjustRate : Form
    {
        public AdjustRate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdjustRate_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var my_users = db.USERs.Where(u => u.user_type_id == 1).Select(u => u.username).ToList();
                comboBox1.DataSource = my_users;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var username = comboBox1.SelectedValue.ToString();

                var my_user_id = db.USERs
                    .Where(u => u.username == username)
                    .Select(u => u.user_id)
                    .FirstOrDefault();

                var users_current_rate = db.RATEs.Where(r => r.user_id == my_user_id).FirstOrDefault();

                users_current_rate.rate_amt = numericUpDown1.Value;

                db.SubmitChanges();

                confirmation_text.Text = 
                    "You successfully updated " + username + "'s payrate to " + 
                    "$" + numericUpDown1.Value;
            }
            
        }

        private void AdjustRate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage home = new AdminHomePage();
            home.Show();
        }
    }
}
