using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintaZhEa
{
    public partial class Form1 : Form
    {

        BindingList<Futók> futók = new();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = futók; //a betöltés kipróbálásához kell
            futókBindingSource.DataSource = futók;
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
                var t = csv.GetRecords<Futók>();

                foreach (var item in t)
                {
                    futók.Add(item);
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
                    csv.WriteRecords(futók);
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
            if (futókBindingSource.Current == null) return;
            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futókBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormÚjFutó formÚjFutó = new FormÚjFutó();
            if (formÚjFutó.ShowDialog() == DialogResult.OK)
            {
                futókBindingSource.Add(formÚjFutó.ÚjFutó);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //double összeg = 0;//
            //int darab = 0;//
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in futók)
            {
                //if (item.Nemzetiseg == "USA")//
                if (item.EredmenyPerc < minimum)
                {
                    //összeg += item.EredmenyPerc;
                    //darab++;
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }

            //double átlag = összeg / darab;
            MessageBox.Show($"A legjobb idõ {minimum}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (futókBindingSource.Current == null) return;
            FormEdit formEdit = new FormEdit();
            //formEdit.ÚjFutó = FutókfutókBindingSource.Current as Futók;
            formEdit.Show();

        }
    }
}
