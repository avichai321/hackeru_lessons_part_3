using HackerWe.Logic;
using HackerWe.book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HackerWe.UI
{
    public partial class AddClientUserControl1 : UserControl
    {
        Client clientnew=new Client();
        public event Action<Client> clientAdded;

        public AddClientUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Emailregex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!Emailregex.IsMatch(EmailtextBox5.Text)) { throw new EmailNotGoodException(); }
                clientnew.Id = int.Parse(IDtextBox1.Text);
                clientnew.FirstName = FirstNametextBox3.Text;
                clientnew.IdentityNumber = IdentifyNumbertextBox2.Text;
                clientnew.LastName = LastNametextBox4.Text;
                clientnew.Email = EmailtextBox5.Text;
                clientnew.PhoneNumber = PhoneNumbertextBox6.Text;
                Library.Clients.Insert(0,clientnew);
                Library.SaveClients();
                //richTextBox1.Text = "The new client Added succefully";
                clientAdded(clientnew);
            }
            catch (EmailNotGoodException)
            {
                MessageBox.Show("Email is not valid try again");
            }
        }

    }
}

