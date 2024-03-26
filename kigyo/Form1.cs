namespace kigyo
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lepeszam = 0;
        int hossz = 3;
        int kaja_x;
        int kaja_y;
        bool megette= true;
        int kovikajax = 0;
        int kovikajay = 0;
        List<K�gy�Elem> kigyo = new List<K�gy�Elem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fej_x += irany_x * K�gy�Elem.M�ret;
            fej_y += irany_y * K�gy�Elem.M�ret;
            K�gy�Elem elem = new K�gy�Elem();
            kigyo.Add(elem);
            foreach (K�gy�Elem item in Controls)
            {
                if(item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;
                    if(k.Left == fej_x && k.Top == fej_y)
                    {
                        timer1.Stop();
                        MessageBox.Show("V�ge a j�t�knak");
                    }
                    if(fej_x < 0 || fej_x >= ClientSize.Width || fej_y < 0 || fej_y >= ClientSize.Height)
                    {
                        timer1.Stop();
                        MessageBox.Show("V�ge a j�t�knak");
                    }
                    if(k.Left == kaja_x && k.Top == kaja_y)
                    {
                        hossz++;
                        Controls.Remove(k);
                        megette = true;
                    }
                    else
                    {
                        megette = false;
                        kovikajax = kaja_x;
                        kovikajay = kaja_y;
                    }
                }
            }
            elem.Top = fej_y;
            elem.Left = fej_x;
            if(lepeszam %2 == 0)
            {
                elem.BackColor = Color.Green;
            }
            else
            {
                elem.BackColor = Color.Yellow;
            }
            Controls.Add(elem);
            if(kigyo.Count> hossz)
            {
                K�gy�Elem lev�gand� = kigyo[0];
                Controls.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }
            if (lepeszam % 5 == 0 && megette==true)
            {
                Random rnd = new Random();
                kaja_x = rnd.Next(0, ClientSize.Width / Kaja.M�ret) * Kaja.M�ret;
                kaja_y = rnd.Next(0, ClientSize.Height / Kaja.M�ret) * Kaja.M�ret;

                K�gy�Elem kaja = new K�gy�Elem();
                kaja.Top = kaja_y;
                kaja.Left = kaja_x;
                kaja.BackColor = Color.Red;

                Controls.Add(kaja);
                megette = false;
            }
            if(megette == false)
            {
                K�gy�Elem kaja = new K�gy�Elem();
                kaja.Top = kovikajay;
                kaja.Left = kovikajax;
                kaja.BackColor = Color.Red;

                Controls.Add(kaja);
            }
            lepeszam++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode ==Keys.Up)
            {
                irany_x = 0;
                irany_y = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                irany_x = 0;
                irany_y = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                irany_x = -1;
                irany_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                irany_x = 1;
                irany_y = 0;
            }
        }
    }
}
