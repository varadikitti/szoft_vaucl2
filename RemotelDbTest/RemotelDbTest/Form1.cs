namespace RemotelDbTest
{
    public partial class Form1 : Form
    {
        // Ezen a objektumon keresztül lehet majd elérni a távoli adatbázis elemeit
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
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }
    }
}
