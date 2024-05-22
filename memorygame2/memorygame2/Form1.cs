using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memorygame2
{
    public partial class Form1 : Form
    {
        kartya elozoKartya;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.hatterkep);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

            int sorSzam = 0;
            int[] t = Keveres(16);


            for (int s = 0; s < 4; s++)
            {
                for (int o = 0; o < 4; o++)
                {
                    kartya k = new kartya(s, o, t[sorSzam]);
                    Controls.Add(k);

                    k.Click += K_Click;
                    sorSzam++;
                }
            }
        }

        private void K_Click(object sender, EventArgs e)
        {
            if (sender is kartya)
            {
                kartya k = (kartya)sender;

                if (elozoKartya != null) 
                {
                    if (k.kintKepSzam == elozoKartya.kintKepSzam && k != elozoKartya)
                    {
                        k.Visible = false;
                        elozoKartya.Visible = false;
                    }
                }
                elozoKartya = k;

            }
            
        }

        int[] Keveres(int kartyaSzam)
        {
            int[] tomb = new int[kartyaSzam];

            for (int i = 0; i < kartyaSzam / 2; i++)
            {
                tomb[i] = i + 1;
                tomb[i + kartyaSzam / 2] = i + 1;
            }

            Random rnd = new Random();

            for (int i = 0; i < kartyaSzam; i++)
            {
                int egyik = rnd.Next(kartyaSzam);
                int masik = rnd.Next(kartyaSzam);

                int koztes = tomb[egyik];
                tomb[egyik] = tomb[masik];
                tomb[masik] = koztes;
            }

            return tomb;
        }
    }
}