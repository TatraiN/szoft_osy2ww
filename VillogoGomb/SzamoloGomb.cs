using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillogoGomb;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        int szám = 0;
        public SzamoloGomb()
        {
            Click += SzamoloGomb_Click;
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            Height = 20;
            Width = 20;

        }
    }
}
// for (int i = 0; i < 20; i++)
//{
//    SzamoloGomb c = new SzamoloGomb();
//    c.Text = szám.ToString();

//}