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
    public partial class MakePayment : Form
    {
        public MakePayment()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage home = new AdminHomePage();
            home.Show();
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var username = comboBox1.SelectedValue.ToString();

                var my_user_id = db.USERs
                    .Where(u => u.username == username)
                    .Select(u => u.user_id)
                    .FirstOrDefault();
                var amount = numericUpDown1.Value;
                var date = DateTime.Now;

                var payment = new PAYMENT();
                payment.user_id = my_user_id;
                payment.payment_amount = amount;
                payment.payment_date = date;

                db.PAYMENTs.InsertOnSubmit(payment);
                db.SubmitChanges();
            }
            label3.Text = "You successfully paid " + comboBox1.SelectedValue.ToString() + " $" +
                numericUpDown1.Value.ToString();
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var my_users = db.USERs.Where(u => u.user_type_id == 1).Select(u => u.username).ToList();
                comboBox1.DataSource = my_users;
            }
        }

        private void MakePayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
