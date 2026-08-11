namespace Devop_DiceRoller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatForm temp = new StatForm();
            temp.ShowDialog();
        }

        public void sendToSQL(string Die, int result)
        {
            //Code to send these values to SQL server
        }

        private void btn1d4Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,5);
            tbxD4.Text = num.ToString();
            sendToSQL("4", num);
        }

        private void btn1d6Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            tbxD6.Text = num.ToString();
            sendToSQL("6", num);
        }

        private void btn1d8Roll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 9);
            tbxD8.Text = num.ToString();
            sendToSQL("8", num);
        }
    }
}
