namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreating : Form
    {
        public LevelCreating()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();

            this.Close();
        }
    }
}
