namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            output.Text = "Halo " + input_user.Text;
        }

        private void input_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
