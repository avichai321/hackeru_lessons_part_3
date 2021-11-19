namespace nultithered_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Search search = new Search(textBox1.Text, textBox2.Text);
                search.Searchvalue += (value) =>
                 {
                     listBox1.Items.Add(value);
                 };
                search.search();
            });
            thread.Start();

        }
    }
}