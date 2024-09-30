using System.Data;

namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private Rectangle _panel1OriginalRectangle;
        private Rectangle _dataGridView1OriginalRectangle;
        private Rectangle _pictureBox1OriginalRectangle;
        private Rectangle _pictureBox2OriginalRectangle;
        private Rectangle _pictureBox3OriginalRectangle;
        private Rectangle _pictureBox4OriginalRectangle;
        private Rectangle _pictureBox5OriginalRectangle;
        private Rectangle _pictureBox6OriginalRectangle;
        private Rectangle _originalFormSize;

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
            _panel1OriginalRectangle = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            _dataGridView1OriginalRectangle = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
            _pictureBox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            _pictureBox2OriginalRectangle = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            _pictureBox3OriginalRectangle = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height);
            _pictureBox4OriginalRectangle = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Width, pictureBox4.Height);
            _pictureBox5OriginalRectangle = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Width, pictureBox5.Height);
            _pictureBox6OriginalRectangle = new Rectangle(pictureBox6.Location.X, pictureBox6.Location.Y, pictureBox6.Width, pictureBox6.Height);
            _originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

        }

        private void resizeControl(Rectangle rectangle, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(_originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(_originalFormSize.Height);

            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)(rectangle.Width * xRatio);
            int newHeight = (int)((rectangle.Height) * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            resizeControl(_pictureBox1OriginalRectangle, pictureBox1);
            resizeControl(_pictureBox2OriginalRectangle, pictureBox2);
            resizeControl(_pictureBox3OriginalRectangle, pictureBox3);
            resizeControl(_pictureBox4OriginalRectangle, pictureBox4);
            resizeControl(_pictureBox5OriginalRectangle, pictureBox5);
            resizeControl(_pictureBox6OriginalRectangle, pictureBox6);
            resizeControl(_dataGridView1OriginalRectangle, dataGridView1);
            resizeControl(_panel1OriginalRectangle, panel1);
        }
    }
}
