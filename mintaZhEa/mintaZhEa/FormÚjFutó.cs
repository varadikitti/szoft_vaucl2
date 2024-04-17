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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormÚjFutó formÚjFutó = new FormÚjFutó();
            if (formÚjFutó.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FormÚjFutó_Load(object sender, EventArgs e)
        {

        }
    }
}
