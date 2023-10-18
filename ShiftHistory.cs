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
    public partial class ShiftHistory : Form
    {
        public ShiftHistory()
        {
            InitializeComponent();
        }

        private void ShiftHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShiftHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView3.Visible = false;
            using (var db = new DataClasses1DataContext())
            {
                var user = db.USERs.FirstOrDefault(u => u.user_id == UserSession.UserId);
                welcome_label.Text = user.username + "'s History";
                var shifts = db.CLOCK_IN_OUTs
                    .Where(u => u.user_id == UserSession.UserId)
                    .Select(s => new {
                        TimeIn = s.day_time_in,
                        TimeOut = s.day_time_out,
                        TotalTime = s.day_time_out - s.day_time_in
                    }).ToList();
                dataGridView1.DataSource = shifts;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage home = new UserHomePage();
            home.Show();
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var shifts = db.CLOCK_IN_OUTs
                    .Where(u => u.user_id == UserSession.UserId)
                    .Select(s => new { TimeIn = s.day_time_in, TimeOut = s.day_time_out,
                        TotalTime = s.day_time_out - s.day_time_in}).ToList();
                var date1 = dateTimePicker1.Value;
                var date2 = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1);
                var filtered = shifts.Where(p => p.TimeIn >= date1 && p.TimeIn <= date2).ToList();

                dataGridView3.DataSource = filtered;

                dataGridView1.Visible = false;
                dataGridView3.Visible = true;

            }
        }
    }
}
