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
    public partial class ModifyTimeClock : Form
    {
        public ModifyTimeClock()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage home = new AdminHomePage();
            home.Show();
        }

        private void ModifyTimeClock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ModifyTimeClock_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                var shifts = db.CLOCK_IN_OUTs
                    .Select(s => new {
                        RecordNumber = s.clock_id,
                        User = s.user_id,
                        TimeIn = s.day_time_in,
                        TimeOut = s.day_time_out,
                        TotalTime = s.day_time_out - s.day_time_in
                    }).ToList();
                dataGridView1.DataSource = shifts;
            }
            
        }
    }
}
