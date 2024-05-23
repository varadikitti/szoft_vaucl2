using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_again
{
    public partial class Form1 : Form
    {

        List<kartya> szamolalo = new List<kartya>();

        kartya elozokartya;

        public int size = 2;
        public int timespent;
        public int goodones;
        public int all;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.hatterkep);
            Height = BackgroundImage.Height;
            Width = BackgroundImage.Width;

            listBox1.Items.Add("Easy");
            listBox1.Items.Add("Medium");
            listBox1.Items.Add("Hard");
        }

        int[] Keveres(int kartyaszam)
        {
            int[] tomb = new int[kartyaszam];

            for (int i = 0; i < kartyaszam / 2; i++)
            {
                tomb[i] = i + 1;
                tomb[i + kartyaszam / 2] = i + 1;
            }

            Random rnd = new Random();

            for (int i = 1; i < kartyaszam; i++)
            {
                int egyik = rnd.Next(kartyaszam);
                int masik = rnd.Next(kartyaszam);

                int seged = tomb[egyik];
                tomb[egyik] = tomb[masik];
                tomb[masik] = tomb[seged];
            }

            return tomb;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                size = 2;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                size = 4;
            }
            else 
            { 
                size = 6; 
            }

            panel1.Controls.Clear();

            int sorszam = 0;
            int[] t = Keveres(size*size);

            for (int s = 0; s < size; s++)
            {
                for (int o = 0; o < size; o++)
                {
                    kartya k = new kartya(s, o, t[sorszam]);
                    panel1.Controls.Add(k);

                    k.Click += K_Click;
                    sorszam++;
                }
            }
        }

        private void K_Click(object sender, EventArgs e)
        {
            all++;
            if (all == 1)
            {
                timer1.Start();
            }

            if (sender is kartya)
            {
                kartya k = (kartya)sender;

                if (szamolalo.Count() <=1 )
                {
                    k.Felfordit();
                    szamolalo.Add(k);
                }
                else
                {
                    foreach (var v in szamolalo)
                    {
                        v.Lefordit();
                    }
                    szamolalo.Clear();
                    k.Felfordit();
                    szamolalo.Add(k);
                }

                if (all % 2 == 0 && elozokartya != null)
                {
                    if (k.kintkepszam == elozokartya.kintkepszam && k != elozokartya)
                    {
                        k.Visible = false;
                        elozokartya.Visible = false;
                        goodones++;
                    }
                }
                elozokartya = k;
            }

            label2.Text = goodones.ToString();
            label3.Text = (all / 2 - goodones).ToString();

            if (goodones == (size*size) / 2)
            {
                timer1.Stop();
                MessageBox.Show($"Congratulations! The # of good matches: {goodones}, and the # of bad matches: {all/2-goodones}. Select a harder mode, this level was way too easy for you! :)");
                timespent = 0;
                all = 0;
                goodones = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timespent++;
            label1.Text = "Time spent: " + timespent.ToString() + " seconds.";
        }
    }
}
