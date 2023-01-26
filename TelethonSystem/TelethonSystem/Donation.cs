using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETSClassLibrary;

namespace TelethonSystem
{
    public partial class Donation : Form
    {
        ETSManager man = Sponsor.man;
        public Donation()
        {
            InitializeComponent();
        }

        private void showPrize_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.listQualifiedPrizes(Convert.ToDouble(amount_txtbox.Text));
        }

        private void addDonation_btn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string msg = man.addDonation(donID_txtbox.Text, Convert.ToString(date), dID_txtbox.Text, Convert.ToDouble(amount_txtbox.Text), prID_txtbox.Text, Convert.ToInt32(number_txtbox.Text));
            MessageBox.Show(msg);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Hide();
                ETSTelethonSystem man = new ETSTelethonSystem();
                man.Visible = true;
                man.Activate();
            }
        }

        private void listDonation_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.listDonations();
        }
    }
}
