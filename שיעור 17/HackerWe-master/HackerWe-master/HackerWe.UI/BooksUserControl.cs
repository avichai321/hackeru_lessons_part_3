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


namespace HackerWe.UI
{
    public partial class BooksUserControl : UserControl
    {
        Book newbook= new Book();
        public event Action<Book> BookAdded;
        public BooksUserControl()
        {
            InitializeComponent();
        }
        private void BooksUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            newbook.Id = int.Parse(BookIdtextBox1.Text);
            newbook.IdentityNumber = IdentityNumbertextBox2.Text;
            newbook.Author = Authortextbox.Text;
            newbook.Name = BookNametextBox4.Text;
            newbook.NumberOfPages = int.Parse(NumberOfPagestextBox5.Text);
            newbook.NumberOfCopies = short.Parse(NumberofcopiestextBox6.Text);
            newbook.NumberOfBorrowedOut = 0;
            newbook.DatePublished = publisheddateTimePicker1.Value;

            Library.SaveBooksAsJSON();
            Library.Books.Add(newbook);
            richTextBox1.Text = "Book Added succefully";
            BookAdded(newbook);
        }
    }
}
