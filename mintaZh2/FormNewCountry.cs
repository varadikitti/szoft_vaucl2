using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintaZh2
{
    public partial class FormNewCountry : Form
    {
        public CountryData NewCountry = new CountryData();

        public FormNewCountry()
        {
            InitializeComponent();
            //bindingSource1 = new BindingSource();
            //bindingSource1.DataSource = NewCountry;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCountry.Name = textBox1.Text;
            NewCountry.Population = int.Parse(textBox2.Text);
            NewCountry.AreaInSquareKm = int.Parse(textBox3.Text);
        }
    }
}
