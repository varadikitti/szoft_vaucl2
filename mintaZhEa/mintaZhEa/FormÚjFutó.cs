using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintaZhEa
{
    public partial class FormÚjFutó : Form
    {
        public Futók ÚjFutó = new Futók();
        

        public FormÚjFutó()
        {
            InitializeComponent();
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = ÚjFutó;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÚjFutó.VersenyzoID = int.Parse(textBox1.Text);
            ÚjFutó.Nev = textBox2.Text;
            ÚjFutó.Nemzetiseg = textBox3.Text;
            ÚjFutó.EredmenyPerc = int.Parse(textBox4.Text);
            ÚjFutó.Kategoria = textBox5.Text;
        }

        private void FormÚjFutó_Load(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
