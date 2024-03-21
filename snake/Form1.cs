namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám; //Ha létrehozol egy int típusú változót, 0 lesz a kezdõértéke, nem kell külön inicializálni.
        int hossz = 5;

        List<KígyóElem> kígyó = new List<KígyóElem>();
        List<hami> alma = new List<hami>();


        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(lépésszám.ToString());
            lépésszám++;

            /*
            //Fejnövesztés1
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            */

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            /*
           //Ütközésvizsgálat1
           foreach (KígyóElem item in Controls)
           {
               //Ha vannak már valami ott, ahova az új fejet tenném, vége a játéknak
               if (item.Top == fej_y && item.Left == fej_x)
               {
                   timer1.Enabled = false;
                   return;
               }
           }
           */

            //Ütközésvizsgálat
            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            //Fejnövesztés még
            KígyóElem ke = new KígyóElem();
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke); //.. és az ûrlap vezérlõinek a listájába is
            

            /*
            //Farokvágás1
            if (Controls.Count > hossz)
            {
                //KígyóElem levágandó = Controls[0];
                //Controls.RemoveAt(0);
            }
            */

            //Farokvágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            //Felváltva színezés
            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}