namespace zh1again_gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // ****************************  S Z O R Z Ó T Á B L A  **************************** //

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button button = new Button();

                    button.Text = (i * j).ToString();
                    button.Left = i * 40;
                    button.Top = j * 40;
                    button.Height = 40;
                    button.Width = 40;

                    panel1.Controls.Add(button);
                }
            }


            // ****************************  F I B O N A C C I  **************************** //

            List<fibo_elem> elemek = new List<fibo_elem>();

            for (int i = 0; i < 10; i++)
            {
                fibo_elem fibo = new fibo_elem();
                fibo.sorszam = i + 1;
                fibo.ertek = Fibonacci(i);
                elemek.Add(fibo);
            }

            dataGridView1.DataSource = elemek;

            // formloadon kívül is lehet, lehet inkább ott kéne hehe; nem tök mindegy, ide is jó

            int Fibonacci(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }


            // ****************************  P A S C A L  **************************** //

            int m = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (sor >= oszlop)
                    {
                        Button button = new Button();
                        button.Top = m * sor;
                        button.Left = panel2.Width / 2 - sor * 20 + oszlop * 40;
                        button.Height = m;
                        button.Width = m;
                        panel2.Controls.Add(button);

                        int p = Fakt(sor) / (Fakt(oszlop) * (Fakt(sor - oszlop)));

                        button.Text = p.ToString();
                    }
                }
            }

            int Fakt(int n)
            {
                int eredmeny = 1;
                for (int i = 1; i <= n; i++) eredmeny *= i;
                return eredmeny;
            }


            // ****************************  S A K K T Á B L A  **************************** //

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Label btn = new Label();

                    btn.Left = i * 20;
                    btn.Top = j * 20;
                    btn.Height = 20;
                    btn.Width = 20;

                    if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0) { btn.BackColor = Color.Black; }
                    else if ((i + 1) % 2 == 1 && (j + 1) % 2 == 1) { btn.BackColor = Color.Black; }
                    //if ( ( (i+1)%2 == 1 && (j+1)%2 == 0 ) || ( (i + 1) % 2 == 1 && (j + 1) % 2 == 0) ) { btn.BackColor = Color.Beige; }
                    else { btn.BackColor = Color.Beige; }

                    panel3.Controls.Add(btn);
                }
            }


            // ****************************  V I L L O G Ó   +   S Z Í N E Z Õ D Õ    G O M B  **************************** //

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    villogogomb button = new villogogomb();

                    button.Text = ((i + 1) * (j + 1)).ToString();
                    button.Height = 40;
                    button.Width = 40;
                    button.Left = i * 40;
                    button.Top = j * 40;

                    panel4.Controls.Add(button);
                }
            }


            // ****************************  S Z Á M O L Ó   G O M B  **************************** //

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    szamologomb button = new szamologomb();

                    button.Left = panel5.Width/2 - 40 + i * 40;
                    button.Top = j * 40;
                    
                    panel5.Controls.Add(button);
                }
            }


            // ****************************  V É L E T L E N   G O M B O K  **************************** //

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                Label label = new Label();

                label.Width = rnd.Next(5, 50);
                label.Height = rnd.Next(5, 50);
                label.Left = rnd.Next(0, panel6.Width-label.Width);
                label.Top = rnd.Next(0, panel6.Height-label.Height);
                label.BackColor = Color.FromArgb( rnd.Next(256), rnd.Next(256), rnd.Next(256) );

                panel6.Controls.Add(label);
            }


            // ****************************  H Á R O M S Z Ö G  **************************** //

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i >= j)
                    {
                        Label label = new Label();

                        label.Width = 30;
                        label.Height = 30;
                        label.Left = panel7.Width/2 - 15 * i + 30 * j;
                        label.Top = label.Height * i;
                        label.BackColor = Color.CornflowerBlue;
                        label.BorderStyle = BorderStyle.FixedSingle;

                        panel7.Controls.Add(label);
                    }
                }
            }


            // ****************************  K A R Á C S O N Y F A  **************************** //

            // lomb

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i >= j)
                    {
                        Label label = new Label();

                        label.Width = 30;
                        label.Height = 30;
                        label.Left = panel8.Width/2 - 15 * i + 30 * j;
                        label.Top = label.Height * i;
                        label.BackColor = Color.Green;

                        panel8.Controls.Add(label);
                    }
                }
            }

            // törzs

            for (int i = 0; i < 3; i++)
            {
                Label lbl = new Label();
                lbl.Width = 30;
                lbl.Height = 30;
                lbl.Left = panel8.Width / 2;
                lbl.Top = lbl.Height * i + 300;
                lbl.BackColor = Color.Brown;

                panel8.Controls.Add(lbl);
            }
        }
    }
}
