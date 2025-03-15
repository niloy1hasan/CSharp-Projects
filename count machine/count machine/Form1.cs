namespace count_machine
{

    public partial class Form1 : Form
    {
        private Count counter;

        private void UpdateLabel()
        {
            count.Text = counter.get().ToString();

            if (counter.get() == 0)
            {
                button3.Enabled = false;
                button1.Enabled = false;
            }

            else if (counter.get() > 0)
            {
                button3.Enabled = true;
                button1.Enabled = true;
            }
        }


        public Form1()
        {
            InitializeComponent();
            counter = new Count();
            UpdateLabel();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter.plus();
            UpdateLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter.minus();
            UpdateLabel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            counter.reset();
            UpdateLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
