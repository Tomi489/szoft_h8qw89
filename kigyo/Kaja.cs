using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class Kaja : PictureBox
    {
        public static int Méret = 20;
        public Kaja()
        {
            Width = Kaja.Méret;
            Height = Kaja.Méret;
            BackColor = Color.Red;
        }
    }
}
