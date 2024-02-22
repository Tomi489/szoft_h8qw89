namespace szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int oszlop=0; oszlop<9;oszlop++)
            {
                for (int sor = 0; sor < 9; sor++)
                {
                    Button button = new Button();
                    button.Left = oszlop * 40;
                    button.Top = sor * 40;
                    button.Width = 40;
                    button.Height = 40;
                    button.Text = ((oszlop + 1) * (sor + 1)).ToString();
                    Controls.Add(button);
                }
            }
        }
    }
}