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
    public partial class Sponsor : Form
    {
        public static ETSManager man = new ETSManager();
        public Sponsor()
        {
            InitializeComponent();
        }

        private void addSponsor_btn_Click(object sender, EventArgs e)
        {
            string msg = man.addSponsor(sponsorID_txtbox.Text, fn_txtbox.Text, LN_txtbox.Text, 0);
            MessageBox.Show(msg);
        }

        private void viewSponsor_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.listSponsors();
        }

        private void searchSponsor_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.findSponsor(searchSponsor_txtbox.Text);
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
    }
}
