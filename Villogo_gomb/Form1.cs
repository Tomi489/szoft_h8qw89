namespace Villogo_gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for(int i = 0;i<20;i++)
            {
                for(int j = 0;j<20;j++)
                {
                    VillogoGomb b = new VillogoGomb();
                    Controls.Add(b);
                    b.Left = i*20;
                    b.Top = j*20;
                    b.Width = 20;
                    b.Height = 20;
                }
            }
            for(int i = 10;i<21; i++)
            {
                for (int j = 10; j<21; j++)
                {
                    SzamoloGomb b = new SzamoloGomb();
                    Controls.Add(b);
                    b.Left = i*40;
                    b.Top = j*40;
                    b.Width = 40;
                    b.Height = 40;
                }
            }
        }
    }
}