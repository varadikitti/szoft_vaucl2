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

        public int size = 2;
        int timeSpent;
        public int jo;
        public int kezd;

        List<kartya> szamolo = new List<kartya>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.hatterkep);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

            listBox1.Items.Add("Easy");
            listBox1.Items.Add("Medium");
            listBox1.Items.Add("Hard");            
        }

        private void K_Click(object sender, EventArgs e)
        {
            kezd++;
            if (kezd == 1)
            {
                timer1.Start();
            }

            //MessageBox.Show(kezd.ToString());
            

            if (sender is kartya)
            {
                kartya k = (kartya)sender;

                if (szamolo.Count() <= 1 )
                {
                    k.Felfordit();
                    szamolo.Add(k);
                }
                else
                {
                    foreach (var v in szamolo)
                    {
                        v.Lefordit();
                    }
                    szamolo.Clear();
                    k.Felfordit();
                    szamolo.Add(k);
                }

                if (kezd%2 == 0 && elozoKartya != null)
                {
                    if (k.kintKepSzam == elozoKartya.kintKepSzam && k != elozoKartya)
                    {
                        k.Visible = false;
                        elozoKartya.Visible = false;
                        jo++;
                    }
                }
                elozoKartya = k;
            }

            label2.Text = jo.ToString();
            label3.Text = (kezd / 2 - jo).ToString();

            if (jo == (size * size) / 2)
            {
                timer1.Stop();
                MessageBox.Show($"Congratulations! # of good answers: {jo}, and the # of bad answers: {kezd / 2 - jo}. Select a harder mode it was too easy for you! :)");
                timeSpent = 0;
                kezd = 0;
                jo = 0;
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

            for (int i = 1; i < kartyaSzam; i++)
            {
                int egyik = rnd.Next(kartyaSzam);
                int masik = rnd.Next(kartyaSzam);

                int koztes = tomb[egyik];
                tomb[egyik] = tomb[masik];
                tomb[masik] = koztes;
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
            
            //MessageBox.Show(size.ToString());

            int sorSzam = 0;
            panel1.Controls.Clear();
            int[] t = Keveres(size * size);


            for (int s = 0; s < size; s++)
            {
                for (int o = 0; o < size; o++)
                {
                    kartya k = new kartya(s, o, t[sorSzam]);
                    panel1.Controls.Add(k);

                    k.Click += K_Click;
                    sorSzam++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpent++;
            label1.Text = "Time Spent: " + timeSpent.ToString() + " seconds";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}