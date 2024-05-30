using System.Runtime.InteropServices;

namespace ZH1_VAUCL2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            List<sors> sorok = new List<sors>();

            int alap = 3;
            int szamlalo = 1;

            while (szamlalo < 11)
            {
                sors sor = new sors();
                sor.alap = alap;
                sor.kitevo = szamlalo;
                sor.eredmeny = (int)Math.Pow(sor.alap, sor.kitevo);

                szamlalo++;

                sorok.Add(sor);
            }

            dataGridView1.DataSource = sorok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();

                int szam = int.Parse(textBox1.Text);

                for (int i = 0; i < szam; i++)
                {
                    LikeButton g = new LikeButton();
                    g.Height = 20;
                    g.Top = i * 30;

                    panel1.Controls.Add(g);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}