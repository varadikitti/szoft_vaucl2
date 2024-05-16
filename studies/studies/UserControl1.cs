using CsvHelper;
using studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studies
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillDataSource();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var er = from x in context.Instructors
                     select x;

            listBox1.DataSource = er.ToList();
            listBox1.DisplayMember = "Name";

            //fun facts: hány elemből/instruktorból áll a tábla, ami az instruktorokat tartalmazza?
            var oktatoSzam = context.Instructors.Count();
            label1.Text = "Oktatók száma: " + oktatoSzam.ToString();

            //fun facts: melyik a legmagasabb státusz az adatbázisban?
            var legmagasabbStatus = (from x in context.Instructors
                                     select x.StatusFk).Max(); //min is lehet, stb

            //fun facts: legrangosabbak listázása
            var legrangosabb = from x in context.Instructors
                               where x.StatusFk == legmagasabbStatus
                               select x.Name;

            MessageBox.Show($"{string.Join(';', legrangosabb)}");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            var instructor = (Instructor)listBox1.SelectedItem; // or var instructor = listBox1.SelectedItem as Instructor;

            var orak = from x in context.Lessons
                       where x.InstructorFk == instructor.InstructorSk
                       select new
                       {
                           Név = x.CourseFkNavigation.Name,
                           Kód = x.CourseFkNavigation.Code,
                           Nap = x.DayFkNavigation.Name,
                           Sav = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name

                       };
            dataGridView1.DataSource = orak.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDataSource();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.StartsWith(textBox1.Text)
                                   select i).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instructor = listBox1.SelectedItem as Instructor;
            var query = from x in context.Lessons
                        where x.InstructorFk == instructor.InstructorSk
                        select new
                       {
                           Név = x.CourseFkNavigation.Name,
                           Kód = x.CourseFkNavigation.Code,
                           Nap = x.DayFkNavigation.Name,
                           Sav = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name
                       };
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(query);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
