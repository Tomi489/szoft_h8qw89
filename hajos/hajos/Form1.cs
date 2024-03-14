namespace hajos
{
    public partial class Form1 : Form
    {
        List<k�rd�s> �sszesk�rd�s;
        List<k�rd�s> AktualisK�rd�sek = new List<k�rd�s>();
        int Megjelen�tettk�rd�ssz�ma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesk�rd�s = K�rd�sekBeolvas�sa();
            for (int i = 0; i < 7; i++)
            {
                AktualisK�rd�sek.Add(�sszesk�rd�s[0]);
                �sszesk�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisK�rd�sek;
            K�rd�sMegjelenit�se(AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma]);
        }

        void K�rd�sMegjelenit�se(k�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;
            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        List<k�rd�s> K�rd�sekBeolvas�sa()
        {
            List<k�rd�s> k�rd�sek = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");
                if (t�mb.Length != 7) { continue; }
                k�rd�s k = new();
                k.K�rd�sSz�veg = t�mb[1].ToUpper();
                k.V�lasz1 = t�mb[2].Trim('"');
                k.V�lasz2 = t�mb[3].Trim('"');
                k.V�lasz3 = t�mb[4].Trim('"');
                k.URL = t�mb[5];
                int x = 0;
                int.TryParse(t�mb[6], out x);
                k.HelyesV�lasz = x;

                k�rd�sek.Add(k);
            }
            sr.Close();
            return k�rd�sek;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelen�tettk�rd�ssz�ma++;
            if (Megjelen�tettk�rd�ssz�ma == 7) { Megjelen�tettk�rd�ssz�ma = 0; };
            K�rd�sMegjelenit�se(AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            if (AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�lasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma++;
            } else
            {
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            if (AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�lasz == 2)
            {
                textBox2.BackColor = Color.LightGreen;
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma++;
            }
            else
            {
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            if (AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�lasz == 3)
            {
                textBox3.BackColor = Color.LightGreen;
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma++;
            }
            else
            {
                AktualisK�rd�sek[Megjelen�tettk�rd�ssz�ma].HelyesV�laszokSz�ma = 0;
            }
        }
    }
}