using System.Data;

namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private int _windowWidth = 0;
        private List<Control> _objectsToResize = null!;
        private DataTable _table = new DataTable();
        private Panel _panel = new Panel();

        public LevelCreatorForm()
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LevelCreatorInformationForm levelCreatorInformationForm = new LevelCreatorInformationForm();
            levelCreatorInformationForm.ShowDialog();
        }

        private void LevelCreatorForm_Load(object sender, EventArgs e)
        {
            _windowWidth = this.Width;
            _objectsToResize = new()
            {
                pictureBox5, pictureBox6, button1, label1, label2, label3, textBox1, textBox2
            };

            for (int i = 0; i < 25; i++)
            {
                PictureBox picBox;
                picBox = new PictureBox();
                picBox.Size = new Size((flowLayoutPanel1.Width - 45) / 5, (flowLayoutPanel1.Height - 45) / 5);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Cursor = Cursors.Hand;
                picBox.Load(@"D:\university\CourseWork3rdHalfYear\CourseWork3rdHalfYear\Resources\Box.png");
                flowLayoutPanel1.Controls.Add(picBox);
            }

            if (flowLayoutPanel1.Controls is not null)
            {
                foreach(var control in flowLayoutPanel1.Controls)
                {
                    if (control is PictureBox)
                    {
                        PictureBox pb = (control as PictureBox)!;
                        pb.Size = new Size((flowLayoutPanel1.Width - 45) / 2, (flowLayoutPanel1.Height - 45) / 2);
                    }
                }
            }
        }
        
        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);

            _windowWidth = this.Width;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int colums) && Int32.TryParse(textBox2.Text, out int rows))
            {

            }
            else
            {

            }
        }
    }
}
