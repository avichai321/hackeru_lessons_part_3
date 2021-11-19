using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += (object o, EventArgs argss) =>
            {
                lblMessages.Text = "";
                timer.Stop();
            };

            Library.ReadBooksFromJSON();
            Library.ReadClientsFromJSON();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Library.SaveBooks();
            //Library.SaveBooksAsJSON();
            panel1.Controls.Clear();
            BooksUserControl booksUserControl = new BooksUserControl();
            booksUserControl.Parent = panel1;
            booksUserControl.BookAdded += (addbook) =>
             {
                 panel1.Controls.Clear();
                 BorrowingUserControl borrowing = new BorrowingUserControl();
                 borrowing.Parent = panel1;
                 lblMessages.Text = $"The book '{addbook.Name}' By {addbook.Author} added succesfully ";
                 timer.Start();
             };

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BorrowingUserControl borrowingUserControl = new BorrowingUserControl();
            borrowingUserControl.BorrowingSaved += (borrowing) =>
            {
                lblMessages.Text = "Borowing saved successfully " + borrowing.Id;
                timer.Start();
            };
            borrowingUserControl.Parent = panel1;

            borrowingUserControl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddClientUserControl1 addClientUserControl = new AddClientUserControl1();
            addClientUserControl.Parent = panel1;
            addClientUserControl.clientAdded += (NewClient) =>
            {
                panel1.Controls.Clear();
                BorrowingUserControl borrowing = new BorrowingUserControl();
                borrowing.Parent = panel1;
                lblMessages.Text = "The client " + NewClient.FullName + " added succesfully";
                timer.Start();
            };


        }
    }
}
