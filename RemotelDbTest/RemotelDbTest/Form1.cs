namespace RemotelDbTest
{
    public partial class Form1 : Form
    {
        // Ezen a objektumon kereszt�l lehet majd el�rni a t�voli adatb�zis elemeit
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kiv�tel)
            {
                MessageBox.Show(kiv�tel.InnerException.Message);
            }
        }
    }
}
