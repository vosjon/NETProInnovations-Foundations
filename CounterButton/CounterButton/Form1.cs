namespace CounterButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = "Count: " + count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = "Count: " + count.ToString();
        }
    }
}