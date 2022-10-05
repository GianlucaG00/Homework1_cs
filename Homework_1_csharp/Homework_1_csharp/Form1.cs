namespace Homework_1_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 100;
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string id = textBox3.Text; 

            // clean the textBoxes
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";

            // print the summary 
            this.info.Text = "Welcome " + name + " " + surname + "(" + id + ")";
            
        }

   
        // name
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //surname
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // id
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // clean the textBoxes
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";

            this.progressBar1.Value = 0;
            this.info.Text = "---"; 

            msg m = new msg();
            m.Show(); 
        }
    }
}