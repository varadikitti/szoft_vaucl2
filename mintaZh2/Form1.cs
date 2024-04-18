using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace mintaZh2
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = countryList;
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("european_countries.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<CountryData>();
                foreach (var item in tomb)
                {
                    countryList.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCountryEdit fce = new FormCountryEdit();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

        //save
        private void button4_Click(object sender, EventArgs e)
        {
            //using (var writer = new StreamWriter("european_countries.csv"))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
                // Write records to the CSV file
            //    csv.WriteRecords(countryList);
            //};
            //Close();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecord(countryList);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormNewCountry formNewCountry = new FormNewCountry();
            if (formNewCountry.ShowDialog() == DialogResult.OK)
            {
                countryDataBindingSource.Add(formNewCountry.NewCountry);
            }
        }
    }
}
