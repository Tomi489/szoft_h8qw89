using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villogo_gomb
{
    internal class SzamoloGomb : Button
    {
        int szam = 0;               
        public SzamoloGomb()
        {
                Height = 20;
                Width = 20;
            MouseClick += SzamoloGomb_MouseClick;
                
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            
            if(szam==5)
            {
                szam = 0;
            }
            szam++;
            Text =szam.ToString();
        }
    }
}
