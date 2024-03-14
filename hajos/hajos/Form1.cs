namespace hajos
{
    public partial class Form1 : Form
    {
        List<kérdés> Összeskérdés;
        List<kérdés> AktualisKérdések = new List<kérdés>();
        int Megjelenítettkérdésszáma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = KérdésekBeolvasása();
            for (int i = 0; i < 7; i++)
            {
                AktualisKérdések.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKérdések;
            KérdésMegjelenitése(AktualisKérdések[Megjelenítettkérdésszáma]);
        }

        void KérdésMegjelenitése(kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;
            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        List<kérdés> KérdésekBeolvasása()
        {
            List<kérdés> kérdések = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");
                if (tömb.Length != 7) { continue; }
                kérdés k = new();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];
                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kérdések.Add(k);
            }
            sr.Close();
            return kérdések;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelenítettkérdésszáma++;
            if (Megjelenítettkérdésszáma == 7) { Megjelenítettkérdésszáma = 0; };
            KérdésMegjelenitése(AktualisKérdések[Megjelenítettkérdésszáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            if (AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma++;
            } else
            {
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            if (AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálasz == 2)
            {
                textBox2.BackColor = Color.LightGreen;
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma++;
            }
            else
            {
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            if (AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálasz == 3)
            {
                textBox3.BackColor = Color.LightGreen;
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma++;
            }
            else
            {
                AktualisKérdések[Megjelenítettkérdésszáma].HelyesVálaszokSzáma = 0;
            }
        }
    }
}