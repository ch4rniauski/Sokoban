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
            SetValuesBeforeFormLoad();
        }

        private void ResizeControl(Rectangle rectangle, Control control)
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
            ResizeControl(_button1OriginalRectangle, PlayButton);
            ResizeControl(_button2OriginalRectangle, LevelCreatorButton);
        }

        private void LevelCreatorButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelCreatorForm levelCreating = new();

            levelCreating.StartPosition = FormStartPosition.Manual;
            levelCreating.Location = this.Location;
            levelCreating.Size = this.Size;

            levelCreating.ShowDialog();

            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"..\..\..\Maps\map0.txt"))
            {
                MessageBox.Show("У Вас не загружено ни одной карты. Загрузите/создайте карту(ы) и повторите попытку.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();

            PlayForm play = new();

            play.StartPosition = FormStartPosition.Manual;
            play.Location = this.Location;
            play.Size = this.Size;

            play.ShowDialog();

            this.Close();
        }

        private void SetValuesBeforeFormLoad()
        {
            _originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            _button1OriginalRectangle = new Rectangle(PlayButton.Location.X, PlayButton.Location.Y, PlayButton.Width, PlayButton.Height);
            _button2OriginalRectangle = new Rectangle(LevelCreatorButton.Location.X, LevelCreatorButton.Location.Y, LevelCreatorButton.Width, LevelCreatorButton.Height);
        }

        private void LevelChangerButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"..\..\..\Maps\map0.txt"))
            {
                MessageBox.Show("У Вас не загружено ни одной карты. Загрузите/создайте карту(ы) и повторите попытку.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();

            ChangeLevelForm changeLevelForm = new();

            changeLevelForm.StartPosition = FormStartPosition.Manual;
            changeLevelForm.Location = this.Location;
            changeLevelForm.Size = this.Size;

            changeLevelForm.ShowDialog();

            this.Close();
        }
    }
}
