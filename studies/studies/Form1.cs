namespace studies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // feladat: oktatók ÓRÁINAK kilistázása
            panel1.Controls.Clear(); //ha ez kimarad, akkor az elsõ kattintás után eltûnik a usercontrolt
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill; //panel automatikusan átméretezõdik
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ÚJ TEREM
            panel1.Controls.Clear();
            UserControl2 userControl1 = new UserControl2();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // OKTATÓK
            panel1.Controls.Clear();
            UserControl3 userControl1 = new UserControl3();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }
    }
}
