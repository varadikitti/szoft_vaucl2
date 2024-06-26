﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memorygame2
{
    internal class kartya : PictureBox
    {
        public int kintKepSzam;

        Timer timer = new Timer();

        public kartya(int sor, int oszlop, int kepSzam)
        {
            kintKepSzam = kepSzam;

            Height = Properties.Settings.Default.kepMeret;
            Width = Properties.Settings.Default.kepMeret;

            Left = oszlop * Properties.Settings.Default.kepTavolsag + 20;
            Top = sor * Properties.Settings.Default.kepTavolsag + 20;

            Lefordit();
            //Felfordit();

            this.Click += Kartya_Click;
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
        }

        private void Kartya_Click(object sender, EventArgs e)
        {
            Felfordit();
            //timer.Start();
        }

        public void Felfordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.kepKonyvtar + kintKepSzam.ToString() + Properties.Settings.Default.kepUtotag);
        }

        public void Lefordit()
        {
            Image = Bitmap.FromFile(Properties.Settings.Default.kepKonyvtar + "card_back" + Properties.Settings.Default.kepUtotag);
        }
    }
}