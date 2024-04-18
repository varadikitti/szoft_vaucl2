using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintaZhEa
{
    public partial class Form1 : Form
    {

        BindingList<Fut�k> fut�k = new();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = fut�k; //a bet�lt�s kipr�b�l�s�hoz kell
            fut�kBindingSource.DataSource = fut�k;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futottakmeg.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Fut�k>();

                foreach (var item in t)
                {
                    fut�k.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(fut�k);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fut�kBindingSource.Current == null) return;
            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fut�kBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form�jFut� form�jFut� = new Form�jFut�();
            if (form�jFut�.ShowDialog() == DialogResult.OK)
            {
                fut�kBindingSource.Add(form�jFut�.�jFut�);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //double �sszeg = 0;//
            //int darab = 0;//
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in fut�k)
            {
                //if (item.Nemzetiseg == "USA")//
                if (item.EredmenyPerc < minimum)
                {
                    //�sszeg += item.EredmenyPerc;
                    //darab++;
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }

            //double �tlag = �sszeg / darab;
            MessageBox.Show($"A legjobb id� {minimum}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fut�kBindingSource.Current == null) return;
            FormEdit formEdit = new FormEdit();
            //formEdit.�jFut� = Fut�kfut�kBindingSource.Current as Fut�k;
            formEdit.Show();

        }
    }
}
