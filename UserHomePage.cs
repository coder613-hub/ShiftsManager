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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var clock_in = new CLOCK_IN_OUT();
                clock_in.user_id = UserSession.UserId;
                clock_in.day_time_in = DateTime.Now;

                db.CLOCK_IN_OUTs.InsertOnSubmit(clock_in);
                db.SubmitChanges();
            }

            clock_in_button.Visible = false;
            clock_out_button.Visible = true;

            confirmation_label.Text = "You successfully clocked in at " + DateTime.Now.ToShortTimeString();

        }

        private void clock_out_button_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var most_recent_clock = db.CLOCK_IN_OUTs.Where(c => c.user_id == UserSession.UserId)
                    .OrderByDescending(c => c.clock_id)
                    .FirstOrDefault();

                most_recent_clock.day_time_out = DateTime.Now;
                
                db.SubmitChanges();
            }

            clock_in_button.Visible = true;
            clock_out_button.Visible = false;

            confirmation_label.Text = "You successfully clocked out at " + DateTime.Now.ToShortTimeString();
        }

        private void UserHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var user = db.USERs.FirstOrDefault(u => u.user_id == UserSession.UserId);
                welcome_text.Text = "Welcome, " + user.username + "!";
                var most_recent_clock = db.CLOCK_IN_OUTs.Where(c => c.user_id == UserSession.UserId)
                    .OrderByDescending(c => c.clock_id)
                    .FirstOrDefault();
                if (most_recent_clock != null)
                {
                    // if didn't clock out yet
                    if (most_recent_clock.day_time_out == null)
                    {
                        clock_in_button.Visible = false;
                        clock_out_button.Visible = true;
                    } 
                    // clocked out already
                    else
                    {
                        clock_in_button.Visible = true;
                        clock_out_button.Visible = false;
                    }
                } 
                // never clocked in
                else
                {
                    clock_in_button.Visible = true;
                    clock_out_button.Visible = false;
                }
                var totalsecondsfromshifts = db.CLOCK_IN_OUTs
                    .Where(u => u.user_id == UserSession.UserId
                     && u.day_time_out != null)
                    .Select(s => s.day_time_out - s.day_time_in)
                    .Sum(span => (double?)span.Value.TotalSeconds);
                var totalhours = totalsecondsfromshifts / 3600;
                var rate = db.RATEs.Where(u => u.user_id == UserSession.UserId).Select(r => r.rate_amt)
                    .FirstOrDefault();
                var totalowedalltime = (decimal?)totalhours * rate;

                var totalpayments = db.PAYMENTs
                    .Where(p => p.user_id == UserSession.UserId)
                    .Sum(p => (decimal?)p.payment_amount);
                var final_owed = totalowedalltime - totalpayments;
                //Users should see the total unpaid amount (shift hours x rate) - payments).
                owed_label.Text = "The company currently owes you $" + (final_owed ?? 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            confirmation_label.Text = "";

            this.Hide();
            ShiftHistory history = new ShiftHistory();
            history.Show();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSession.UserId = 0;
            SignIn signin = new SignIn();
            signin.Show();
        }
    }
}
