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
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�ssz�m; //Ha l�trehozol egy int t�pus� v�ltoz�t, 0 lesz a kezd��rt�ke, nem kell k�l�n inicializ�lni.
        int hossz = 5;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        List<hami> alma = new List<hami>();


        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(l�p�ssz�m.ToString());
            l�p�ssz�m++;

            /*
            //Fejn�veszt�s1
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            */

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            /*
           //�tk�z�svizsg�lat1
           foreach (K�gy�Elem item in Controls)
           {
               //Ha vannak m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak
               if (item.Top == fej_y && item.Left == fej_x)
               {
                   timer1.Enabled = false;
                   return;
               }
           }
           */

            //�tk�z�svizsg�lat
            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            //Fejn�veszt�s m�g
            K�gy�Elem ke = new K�gy�Elem();
            k�gy�.Add(ke); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke); //.. �s az �rlap vez�rl�inek a list�j�ba is
            

            /*
            //Farokv�g�s1
            if (Controls.Count > hossz)
            {
                //K�gy�Elem lev�gand� = Controls[0];
                //Controls.RemoveAt(0);
            }
            */

            //Farokv�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            //Felv�ltva sz�nez�s
            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}