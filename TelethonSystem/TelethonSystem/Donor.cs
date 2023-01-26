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
    public partial class Donor : Form
    {
        ETSManager man = Sponsor.man;
        public Donor()
        {
            InitializeComponent();
        }

        private void saveDonorInfo_btn_Click(object sender, EventArgs e)
        {
            char cardType = ' ';
            if (visa_radioBtn.Checked)
            {
                cardType = 'v';
            }
            else if (MC_radioBtn.Checked)
            {
                cardType = 'm';
            }
            else if (amex_radioBtn.Checked)
            {
                cardType = 'a';
            }
            else
            {
                MessageBox.Show("Error! Must choose card type!");
            }

            string msg = man.addDonor(donorID_txtbox.Text, fn_textbox.Text, ln_textbox.Text, address_txtbox.Text, phone_txtbox.Text, Convert.ToChar(cardType), cNumber_txtBox.Text, expiryDate_txtBox.Text);
            
            if(man.writeDonors()== true)
            {
                richTextBox1.Text = "Donors has been successfully written in the file";
            }
            else
            {
                richTextBox1.Text = "ERROR!";
            }
            MessageBox.Show(msg);
        }

        private void listDonor_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.listDonors();
        }

        private void getDonors_Click(object sender, EventArgs e)
        {
            if (man.readDonors() == true)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Hide();
                ETSTelethonSystem man = new ETSTelethonSystem();
                man.Visible = true;
                man.Activate();
            }
        }

        private void searchDonor_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = man.findDonor(searchDonor_txtbox.Text);
        }

        private void deleteDonor_btn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (searchDonor_txtbox.Text == " " || searchDonor_txtbox.Text.Equals("Enter Donor ID"))
            {
                msg = "Donor ID is empty";
            }
            else { 
                if(MessageBox.Show("Are you sure you want to delete the donor?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    msg = man.deleteDonor(searchDonor_txtbox.Text);
                }
            }

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

        private void writeDonors_Click(object sender, EventArgs e)
        {
            if (man.writeDonors() == true)
            {
               MessageBox.Show("Donors has been successfully written in the file");
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
