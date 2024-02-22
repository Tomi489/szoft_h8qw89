namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for(int i=0;i<30;i++)
            {
                Sor újsor = new Sor();
                újsor.Sorszám = i;
                újsor.Érték = Fibobacci(i);
                sorok.Add(újsor);

                Button button = new Button();
                button.Text = Fibobacci(i).ToString();
                button.Top = i * 20;
                sorok.Add(újsor);
                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;
        }

        int Fibobacci(int n)
        {
            if (n == 0) { return 0;}
            if (n==1) { return 1; }
            return Fibobacci(n - 1) + Fibobacci(n - 2);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}