namespace CourseWork3rdHalfYear.Forms
{
    public partial class MenuForm : Form
    {
        private Rectangle _button1OriginalRectangle;
        private Rectangle _button2OriginalRectangle;
        private Rectangle _originalFormSize;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            _originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            _button1OriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            _button2OriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
        }

        private void resizeControl(Rectangle rectangle, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(_originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(_originalFormSize.Height);

            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)((rectangle.Width) * xRatio);
            int newHeight = (int)((rectangle.Height) * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void MenuForm_Resize(object sender, EventArgs e)
        {
            resizeControl(_button1OriginalRectangle, button1);
            resizeControl(_button2OriginalRectangle, button2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelCreatorForm levelCreating = new LevelCreatorForm();
            levelCreating.ShowDialog();

            this.Close();
        }
    }
}
