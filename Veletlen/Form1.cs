namespace Veletlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                Button button = new Button();
                
                if(random.Next(2)>0)
                {
                    Controls.Add(button);
                    button.Left= random.Next(ClientRectangle.Width);
                    button.Top= random.Next(ClientRectangle.Height);
                    button.BackColor=Color.FromArgb(random.Next(255),random.Next(255), random.Next(255));
                    button.Height = random.Next(20);
                    button.Width = random.Next(20);
                }
            }
        }
    }
}