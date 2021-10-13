using events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targil_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int mounyCount = 0;
            foreach (var user in UserCollection.Users)
            {
                mounyCount += user.TotalCash;
            }
            totalcashinthebanktextbox.Text = mounyCount.ToString();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
           loginLabel.Text = UserCollection.login(usernametextBox1.Text, passwordtextBox2.Text);
           loginLabel.Visible = true;
            if (loginLabel.Text== $"Wellcome {usernametextBox1.Text}")
            { 
                usernametextBox1.ReadOnly = true;
                passwordtextBox2.ReadOnly = true;             
                cashuploadnumericUpDown1.Visible= true;
                textBox2.Visible= true;
                totalCashlabel4.Visible = true;
                Cashtouploadlabel3.Visible= true;
                Depositbutton1.Visible=true;   
                Logoutbutton1.Visible=true;
            }
            foreach (var user in UserCollection.Users)
            {
                if (user.Username == usernametextBox1.Text && user.Password == passwordtextBox2.Text)
                {
                   textBox2.Text= user.TotalCash.ToString();
                    break;
                }
            }
        }

        private void Depositbutton1_Click(object sender, EventArgs e)
        {
            foreach (var user in UserCollection.Users)
            {
                if (user.Username==usernametextBox1.Text&& user.Password == passwordtextBox2.Text)
                {
                    user.Depositcash= Convert.ToInt32(cashuploadnumericUpDown1.Value);
                    user.TotalCash += Convert.ToInt32(cashuploadnumericUpDown1.Value);
                    textBox2.Text = user.TotalCash.ToString();
                    listBox1.Items.Add(user.ToString());
                    break;
                }
            }
            int mounyCount = 0;
            foreach (var user in UserCollection.Users)
            {
                mounyCount += user.TotalCash;
            }
            totalcashinthebanktextbox.Text = mounyCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernametextBox1.ReadOnly = false;
            passwordtextBox2.ReadOnly = false;
            loginLabel.Visible = false;
            cashuploadnumericUpDown1.Visible = false;
            textBox2.Visible = false;
            totalCashlabel4.Visible = false;
            Cashtouploadlabel3.Visible = false;
            Depositbutton1.Visible = false;
            Logoutbutton1.Visible = false;
            MessageBox.Show("Logout Succefully");
        }
    }
}
