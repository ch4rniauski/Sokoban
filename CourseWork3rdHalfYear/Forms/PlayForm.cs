namespace CourseWork3rdHalfYear.Forms
{
    public partial class PlayForm : Form
    {
        private int _personRow = 0;
        private int _personColumn = 0;

        private int _columns = 0;
        private int _rows = 0;

        private int _levelNumber = 0;

        private int _windowWidth = 0;
        private int _flowLayoutPanelWith = 0;
        private int _flowLayoutPanelHeight = 0;

        private List<Control> _objectsToResize = null!;

        private string _prevPictureName = "Empty";

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
            _columns = mapInLines[0].Length - 2;
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
                    //picBox.Tag = $"{i} {j}";


                    string pathResources = string.Empty;

                    switch (mapInLines[i][j])
                    {
                        case '#':
                            pathResources = @"..\..\..\Resources\StoneBlock.jpg";
                            picBox.Name = "Wall";
                            break;
                        case 'B':
                            pathResources = @"..\..\..\Resources\Box.png";
                            picBox.Name = "Box";
                            break;
                        case 'P':
                            pathResources = @"..\..\..\Resources\Person.png";
                            _personColumn = j;
                            _personRow = i;
                            picBox.Name = "Person";
                            break;
                        case 'X':
                            pathResources = @"..\..\..\Resources\RedCross.png";
                            picBox.Name = "Mark";
                            break;
                    }

                    if (pathResources == "")
                    {
                        picBox.Name = "Empty";
                        flowLayoutPanel1.Controls.Add(picBox);
                        continue;
                    }

                    picBox.Load(pathResources);
                    flowLayoutPanel1.Controls.Add(picBox);
                    //picBox.Cursor = Cursors.Hand;
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
                        control.Size = new Size(flowLayoutPanel1.Width / _columns, _flowLayoutPanelWith / _rows);
                }
            }

            if ((double)flowLayoutPanel1.Height >= (double)_flowLayoutPanelHeight * 1.15 || (double)flowLayoutPanel1.Height * 1.15 <= (double)_flowLayoutPanelHeight)
            {
                _flowLayoutPanelHeight = flowLayoutPanel1.Height;

                if (flowLayoutPanel1.Controls.Count != 0)
                {
                    foreach (Control control in flowLayoutPanel1.Controls)
                        control.Size = new Size(_flowLayoutPanelWith / _columns, _flowLayoutPanelHeight / _rows);
                }
            }
        }

        private void PlayForm_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'ц')
            {
                if (_personRow - 1 > 0)
                {
                    if (flowLayoutPanel1.Controls[(_personRow - 2) * _columns + _personColumn - 1].Name == "Empty" 
                        || flowLayoutPanel1.Controls[(_personRow - 2) * _columns + _personColumn - 1].Name == "Mark")
                    {
                        ChangePersonPositionAndCurrentPicBox(_personRow - 1, _personColumn);
                        _personRow--;
                    }
                    else if (flowLayoutPanel1.Controls[(_personRow - 2) * _columns + _personColumn - 1].Name == "Box" 
                        && _personRow - 2 > 0 
                        && (flowLayoutPanel1.Controls[(_personRow - 3) * _columns + _personColumn - 1].Name == "Empty"
                        || flowLayoutPanel1.Controls[(_personRow - 3) * _columns + _personColumn - 1].Name == "Mark"))
                    {
                        ChangeBoxPosition(_personRow - 2, _personColumn, _personRow - 1, _personColumn);
                        ChangePersonPositionAndCurrentPicBox(_personRow - 1, _personColumn);
                        _personRow--;
                    }
                }
            }
            else if (e.KeyChar == 'a' || e.KeyChar == 'ф')
            {
                if (_personColumn - 1 > 0)
                {
                    if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 2].Name == "Empty" 
                        || flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 2].Name == "Mark")
                    {
                        ChangePersonPositionAndCurrentPicBox(_personRow, _personColumn - 1);
                        _personColumn--;
                    }
                    else if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 2].Name == "Box" 
                        && _personColumn - 2 > 0 
                        && (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 3].Name == "Empty" 
                        || flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 3].Name == "Mark"))
                    {
                        ChangeBoxPosition(_personRow, _personColumn - 2, _personRow, _personColumn - 1);
                        ChangePersonPositionAndCurrentPicBox(_personRow, _personColumn - 1);
                        _personColumn--;
                    }
                }
            }
            else if (e.KeyChar == 's' || e.KeyChar == 'ы')
            {
                if (_personRow + 1 <= _rows)
                {
                    if (flowLayoutPanel1.Controls[_personRow * _columns + _personColumn - 1].Name == "Empty" 
                        || flowLayoutPanel1.Controls[_personRow * _columns + _personColumn - 1].Name == "Mark")
                    {
                        ChangePersonPositionAndCurrentPicBox(_personRow + 1, _personColumn);
                        _personRow++;
                    }
                    else if (flowLayoutPanel1.Controls[_personRow * _columns + _personColumn - 1].Name == "Box" 
                        && _personRow + 1 < _columns 
                        && (flowLayoutPanel1.Controls[(_personRow + 1) * _columns + _personColumn - 1].Name == "Empty"
                        || flowLayoutPanel1.Controls[(_personRow + 1) * _columns + _personColumn - 1].Name == "Mark"))
                    {
                        ChangeBoxPosition(_personRow + 2, _personColumn, _personRow + 1, _personColumn);
                        ChangePersonPositionAndCurrentPicBox(_personRow + 1, _personColumn);
                        _personRow++;
                    }
                }
            }
            else if (e.KeyChar == 'd' || e.KeyChar == 'в')
            {
                if (_personColumn + 1 <= _columns)
                {
                    if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn].Name == "Empty" 
                        || flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn].Name == "Mark")
                    {
                        ChangePersonPositionAndCurrentPicBox(_personRow, _personColumn + 1);
                        _personColumn++;
                    }
                    else if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn].Name == "Box"
                        && _personColumn + 1 < _rows
                        && (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn + 1].Name == "Empty"
                        || flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn + 1].Name == "Mark"))
                    {
                        ChangeBoxPosition(_personRow, _personColumn + 2, _personRow, _personColumn + 1);
                        ChangePersonPositionAndCurrentPicBox(_personRow, _personColumn + 1);
                        _personColumn++;
                    }
                }
            }
        }

        private void ChangePersonPositionAndCurrentPicBox(int newPersonRow, int newPersonColumn)
        {
            string personPath = @"..\..\..\Resources\Person.png";

            PictureBox picturePerson = (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 1] as PictureBox)!;

            if (_prevPictureName == "Mark")
                picturePerson.Load(@"..\..\..\Resources\RedCross.png");
            else if (_prevPictureName == "Empty")
                picturePerson.Image = null;

            picturePerson.Name = _prevPictureName;

            picturePerson = (flowLayoutPanel1.Controls[(newPersonRow - 1) * _columns + newPersonColumn - 1] as PictureBox)!;
            _prevPictureName = picturePerson.Name;

            picturePerson.Load(personPath);
            picturePerson.Name = "Person";
        }

        private void ChangeBoxPosition(int newBoxRow, int newBoxColumn, int prevBoxRow, int prevBoxColumn)
        {
            string boxPath = @"..\..\..\Resources\Box.png";

            PictureBox pictureBox = (flowLayoutPanel1.Controls[(newBoxRow - 1) * _columns + newBoxColumn - 1] as PictureBox)!;
            pictureBox.Load(boxPath);
            pictureBox.Name = "Box";

            pictureBox = (flowLayoutPanel1.Controls[(prevBoxRow - 1) * _columns + prevBoxColumn - 1] as PictureBox)!;
            pictureBox.Image = null;
            pictureBox.Name = "Empty";
        }
    }
}
