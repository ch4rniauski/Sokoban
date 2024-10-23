namespace CourseWork3rdHalfYear.Forms
{
    public partial class PlayForm : Form
    {
        private int _colums = 0;
        private int _rows = 0;

        private int _levelNumber = 0;

        private int _windowWidth = 0;
        private int _flowLayoutPanelWith = 0;
        private int _flowLayoutPanelHeight = 0;

        private List<Control> _objectsToResize = null!;

        public PlayForm()
        {
            InitializeComponent();
            ChangeLevel(_levelNumber);
        }

        private void ChangeLevel(int levelNumber)
        {
            string pathMap = $@"..\..\..\Maps\map{levelNumber}.txt";
            string pathPrevMap = $@"..\..\..\Maps\map{levelNumber - 1}.txt";
            string pathNextMap = $@"..\..\..\Maps\map{levelNumber + 1}.txt";

            if (!File.Exists(pathPrevMap))
                pictureBoxPrevLevel.Hide();
            if (!File.Exists(pathNextMap))
                pictureBoxNextLevel.Hide();

            string[] mapInLines = File.ReadAllLines(pathMap);
            _colums = mapInLines[0].Length - 2;
            _rows = mapInLines.Length - 2;

            labelLevelNumber.Text = $"| Уровень: {levelNumber + 1}";

            FillFlowLayoutPanel(mapInLines);
        }

        private void FillFlowLayoutPanel(string[] mapInLines)
        {
            for (int i = 1; i < mapInLines.Length - 1; i++)
            {
                for (int j = 1; j < mapInLines[0].Length - 1; j++)
                {
                    PictureBox picBox;
                    picBox = new PictureBox();

                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BackColor = Color.White;
                    picBox.Margin = new Padding(0);
                    picBox.Size = new Size(flowLayoutPanel1.Width / (mapInLines[0].Length - 2), flowLayoutPanel1.Height / (mapInLines.Length - 2));
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    string pathResources = mapInLines[i][j] switch
                    {
                        '#' => @"..\..\..\Resources\StoneBlock.jpg",
                        'B' => @"..\..\..\Resources\Box.png",
                        'P' => @"..\..\..\Resources\Person.png",
                        'X' => @"..\..\..\Resources\RedCross.png",
                        _ => ""
                    };

                    if (pathResources == "")
                    {
                        flowLayoutPanel1.Controls.Add(picBox);
                        continue;
                    }
                    else
                        picBox.Load(pathResources);
                    //picBox.Cursor = Cursors.Hand;
                    //picBox.Tag = $"{j} {k}";
                    //picBox.Name = "Empty";

                    flowLayoutPanel1.Controls.Add(picBox);
                }
            }
        }

        private void pictureBoxBackToMenuForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();

            this.Close();
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ChangeLevel(_levelNumber);
        }

        private void pictureBoxNextLevel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            _levelNumber++;
            ChangeLevel(_levelNumber);
        }

        private void pictureBoxPrevLevel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            _levelNumber--;
            ChangeLevel(_levelNumber);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);

            _windowWidth = this.Width;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            _windowWidth = this.Width;

            _objectsToResize = new()
            {
                pictureBoxBackToMenuForm, pictureBoxRestart
            };

            _flowLayoutPanelWith = flowLayoutPanel1.Width;
            _flowLayoutPanelHeight = flowLayoutPanel1.Height;
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            if ((double)flowLayoutPanel1.Width >= (double)_flowLayoutPanelWith * 1.15 || (double)flowLayoutPanel1.Width * 1.15 <= (double)_flowLayoutPanelWith)
            {
                _flowLayoutPanelWith = flowLayoutPanel1.Width;

                if (flowLayoutPanel1.Controls.Count != 0)
                {
                    foreach (Control control in flowLayoutPanel1.Controls)
                        control.Size = new Size(flowLayoutPanel1.Width / _colums, _flowLayoutPanelWith / _rows);
                }
            }

            if ((double)flowLayoutPanel1.Height >= (double)_flowLayoutPanelHeight * 1.15 || (double)flowLayoutPanel1.Height * 1.15 <= (double)_flowLayoutPanelHeight)
            {
                _flowLayoutPanelHeight = flowLayoutPanel1.Height;

                if (flowLayoutPanel1.Controls.Count != 0)
                {
                    foreach (Control control in flowLayoutPanel1.Controls)
                        control.Size = new Size(_flowLayoutPanelWith / _colums, _flowLayoutPanelHeight / _rows);
                }
            }
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void PlayForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
