using studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studies
{
    public partial class UserControl2 : UserControl
    {

        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Rooms.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Room room = new Room();
                room.Name = form2.textBox1.Text; //a Form2-ben a textbox1 Modifiers tulajdonságát publicra állítottuk

                context.Rooms.Add(room);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            dataGridView1.DataSource = (from x in context.Rooms select x).ToList();
        }
    }
}
