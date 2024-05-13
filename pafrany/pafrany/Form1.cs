namespace pafrany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Fuchsia, 1);

            double[,] t = {
                {0,0,0.16,0,0,0},
                {0.85,0.04,-0.04,0.85,0,1.60},
                {0.20,-0.26,0.23,0.22,0,1.60 },
                {-0.15,0.28,0.26,0.24,0,0.44 }
            };

            double x = 0;
            double y = 0;

            Random rnd = new Random();

            for (int i = 0; i < 50000; i++) 
            { 
                int v = rnd.Next(100);
                int s = 0;

                if (v == 0) s = 0;
                if (v >= 1 && v < 86) s = 1;
                if (v >= 86 && v < 93) s = 2;
                if (v >= 93) s = 3;

                double a = t[s, 0];
                double b = t[s, 1];
                double c = t[s, 2];
                double d = t[s, 3];
                double ee = t[s, 4];
                double f = t[s, 5];

                double ux = a * x + b * y + ee;
                double uy = c * x + d * y + f;

                double dx = ClientRectangle.Width / 2;

                g.DrawLine(p, (int)(x * 100 + dx), (int)(y * 100), (int)(x * 100 + 1 + dx), (int)(y * 100));


                x= ux;
                y= uy;
            }
        }
    }
}
