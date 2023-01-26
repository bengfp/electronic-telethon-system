using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelethonSystem
{
    public partial class ETSTelethonSystem : Form
    {
        public ETSTelethonSystem()
        {
            InitializeComponent();
        }

        private void sponsorForm_btn_Click(object sender, EventArgs e)
        {
            Sponsor sponsor = new Sponsor();
            this.Hide();
            sponsor.Visible = true;
            sponsor.Activate();
        }

        private void prizesForm_btn_Click(object sender, EventArgs e)
        {
            Prize prize = new Prize();
            this.Hide();
            prize.Visible = true;
            prize.Activate();
        }

        private void donorsForm_btn_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            this.Hide();
            donor.Visible = true;
            donor.Activate();
        }

        private void donationsForm_btn_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
            this.Hide();
            donation.Visible = true;
            donation.Activate();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Login login = new Login();
                this.Hide();
                login.Visible = true;
                login.Activate();
            } 
        }
    }
}
