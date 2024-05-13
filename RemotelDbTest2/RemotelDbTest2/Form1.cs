namespace RemotelDbTest2
{
    public partial class Form1 : Form
    {
        // Ezen a objektumon kereszt�l lehet majd el�rni a t�voli adatb�zis elemeit
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = studentContext.Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivetel)
            {
                MessageBox.Show(kivetel.InnerException.Message);
            }
        }
    }
}
