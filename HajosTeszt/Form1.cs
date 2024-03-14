namespace HajosTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> Összeskérdés;
        List<Kérdés> Aktuáliskérdések;
        int Aktuáliskérdés = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = KérdésBetöltés();
            Aktuáliskérdések = new List<Kérdés>();
            for (int i = 0; i < 7; i++)
            {
                Aktuáliskérdések.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = Aktuáliskérdések;

            Kérdésmegjelenítés(Aktuáliskérdések[Aktuáliskérdés]);
        }

        void Kérdésmegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            válaszGomb1.Text = kérdés.Válasz1;
            válaszGomb2.Text = kérdés.Válasz2;
            válaszGomb3.Text = kérdés.Válasz3;
            következõ1.Text = "Következõ kérdés";

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        List<Kérdés> KérdésBetöltés()
        {
            List<Kérdés> kérdések = new List<Kérdés>();

            /*try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "n/a";
                string[] tömb = sor.Split("\t");
                if (tömb.Length != 7) continue; /*nem száll el a program :) */
                Kérdés k = new Kérdés();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kérdések.Add(k);
            }
            sr.Close();

            return kérdések;
        }

        private void következõ1_Click(object sender, EventArgs e)
        {

        }
    }
}