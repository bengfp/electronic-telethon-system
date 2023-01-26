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
    public partial class Prize : Form
    {
        ETSManager man = Sponsor.man;
        public Prize() 
        {
            InitializeComponent();
        }

        private void addPrize_btn_Click(object sender, EventArgs e)
        {
            string msg = man.addPrize(prizeID_txtbox.Text, desc_txtbox.Text, Convert.ToDouble(valPerPrize_txtbox.Text), Convert.ToInt32(qty_txtbox.Text), 
                Convert.ToDouble(minLimit_txtbox.Text), sponsorID_txtbox.Text);
            MessageBox.Show(msg);
        }

        private void viewPrize_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.listPrizes();
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
