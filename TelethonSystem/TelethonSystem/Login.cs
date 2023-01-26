using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TelethonSystem
{
    public partial class Login : Form
    {
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\joann\Documents\LaSalleCollege_Pratic\ThirdSem\Multi-tierApp\Projects\firstProject\txtFile\login.txt"))
            {
                bool flag = false;

                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();
                    strArray = str.Split(',');

                    if (username_txtbox.Text == strArray[0] && password_txtbox.Text == strArray[1])
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    ETSTelethonSystem ETSTelethon = new ETSTelethonSystem();
                    this.Hide();
                    ETSTelethon.Visible = true;
                    ETSTelethon.Activate();
                }
                else if (username_txtbox.Text == "")
                {
                    MessageBox.Show("Error! Enter Username.");
                }
                else if (password_txtbox.Text == "")
                {
                    MessageBox.Show("Error! Enter Password.");
                }
                else
                {
                    if (count < 2)
                    {
                        MessageBox.Show("Wrong username and password. Try again");
                        count++;
                        username_txtbox.Clear();
                        password_txtbox.Clear();
                    }
                    else
                    {
                        if (MessageBox.Show("You exceeded the number of tries", "ERROR!", MessageBoxButtons.OK).ToString() == "OK")
                            Application.Exit();
                    }
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
