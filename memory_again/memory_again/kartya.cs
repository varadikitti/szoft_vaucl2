using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_again
{
    internal class kartya : PictureBox
    {
        public int kintkepszam;
        public kartya(int sor, int oszlop, int kepszam)
        {
            kintkepszam = kepszam;

            Height = Properties.Settings.Default.meret;
            Width = Properties.Settings.Default.meret;
            Left = oszlop * Properties.Settings.Default.meret;
            Top = sor * Properties.Settings.Default.meret;

            Lefordit();

            Click += Kartya_Click;
        }

        private void Kartya_Click(object sender, EventArgs e)
        {
            Felfordit();
        }

        public void Felfordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.konyvtar + kintkepszam.ToString() + Properties.Settings.Default.kiterjesztes);
        }

        public void Lefordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.konyvtar + "card_back" + Properties.Settings.Default.kiterjesztes);
        }
    }
}
