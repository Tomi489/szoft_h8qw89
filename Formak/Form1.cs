namespace Formak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i<j)
                    {
                        Controls.Add(button);
                        button.Top = i*20;
                        button.Left = j*20;
                        Height = 20;
                        Width = 20;
                    }
                }
            }
        }
    }
}