using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1again_gyak
{
    internal class szamologomb : Button
    {
        public int szam;

        public szamologomb()
        {
            Height = 40;
            Width = 40;

            Click += Szamologomb_Click;
        }

        private void Szamologomb_Click(object? sender, EventArgs e)
        {
            if (szam <= 4) 
            {
                szam++;
            }
            else
            {
                szam = 1;
            }
            Text = szam.ToString();
        }
    }
}
