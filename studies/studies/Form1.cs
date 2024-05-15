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
            // feladat: oktat�k �R�INAK kilist�z�sa
            panel1.Controls.Clear(); //ha ez kimarad, akkor az els� kattint�s ut�n elt�nik a usercontrolt
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill; //panel automatikusan �tm�retez�dik
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �J TEREM
            panel1.Controls.Clear();
            UserControl2 userControl1 = new UserControl2();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // OKTAT�K
            panel1.Controls.Clear();
            UserControl3 userControl1 = new UserControl3();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }
    }
}
