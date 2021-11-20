namespace nultithered_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Search.Searchvalue += (value) =>
            {
                this.Invoke(new Action(() =>
                {
                    listBox1.Items.Add(value);
                }));
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread((value) =>
            {
            Search search = new Search(textBox1.Text, textBox2.Text);
                search.search();
               
          
            });
            thread.Start();
            
            

                 
        }
    }
}