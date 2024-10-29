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

        private List<Control>? _objectsToResize = null;

        private string _prevPicturePerson = "Empty";
        private List<string>? _prevPicturesBoxes = null;

        private byte _boxes = 0;
        private byte _markedBoxes = 0;

        public PlayForm()
        {
            InitializeComponent();
            ChangeLevel();
        }

        private void ChangeLevel()
        {
            _boxes = 0;
            _markedBoxes = 0;
            _prevPicturePerson = "Empty";

            string pathMap = $@"..\..\..\Maps\map{_levelNumber}.txt";
            string pathPrevMap = $@"..\..\..\Maps\map{_levelNumber - 1}.txt";
            string pathNextMap = $@"..\..\..\Maps\map{_levelNumber + 1}.txt";

            if (!File.Exists(pathPrevMap))
                pictureBoxPrevLevel.Hide();
            if (!File.Exists(pathNextMap))
                pictureBoxNextLevel.Hide();

            string[] mapInLines = File.ReadAllLines(pathMap);
            _columns = mapInLines[0].Length - 2;
            _rows = mapInLines.Length - 2;

            FillFlowLayoutPanel(mapInLines);
            EditPrevPictureNamesBoxes();
            ChangeLabelText();
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

                    string pathResources = string.Empty;

                    switch (mapInLines[i][j])
                    {
                        case '#':
                            pathResources = @"..\..\..\Resources\StoneBlock.jpg";
                            picBox.Name = "Wall";
                            break;
                        case 'B':
                            pathResources = @"..\..\..\Resources\Box.png";
                            picBox.Name = $"Box{_boxes}";
                            _boxes++;
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

            ChangeLevel();
        }

        private void pictureBoxNextLevel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            _levelNumber++;
            ChangeLevel();
        }

        private void pictureBoxPrevLevel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            _levelNumber--;
            ChangeLevel();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize!)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);

            _windowWidth = this.Width;

            labelLevelAndBoxes.Left = (_windowWidth - labelLevelAndBoxes.Width) / 2;
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

            labelLevelAndBoxes.Left = (_windowWidth - labelLevelAndBoxes.Width) / 2;
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
                    else if (flowLayoutPanel1.Controls[(_personRow - 2) * _columns + _personColumn - 1].Name.Contains("Box") 
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
                    else if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 2].Name.Contains("Box")
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
                    else if (flowLayoutPanel1.Controls[_personRow * _columns + _personColumn - 1].Name.Contains("Box")
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
                    else if (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn].Name.Contains("Box")
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

            ChangeLabelText();
        }

        private void ChangePersonPositionAndCurrentPicBox(int newPersonRow, int newPersonColumn)
        {
            string personPath = @"..\..\..\Resources\Person.png";

            PictureBox picturePerson = (flowLayoutPanel1.Controls[(_personRow - 1) * _columns + _personColumn - 1] as PictureBox)!;

            if (_prevPicturePerson == "Mark")
                picturePerson.Load(@"..\..\..\Resources\RedCross.png");
            else if (_prevPicturePerson == "Empty")
                picturePerson.Image = null;

            picturePerson.Name = _prevPicturePerson;

            picturePerson = (flowLayoutPanel1.Controls[(newPersonRow - 1) * _columns + newPersonColumn - 1] as PictureBox)!;
            _prevPicturePerson = picturePerson.Name;

            picturePerson.Load(personPath);
            picturePerson.Name = "Person";
        }

        private void ChangeBoxPosition(int newBoxRow, int newBoxColumn, int prevBoxRow, int prevBoxColumn)
        {
            string boxPath = @"..\..\..\Resources\Box.png";

            PictureBox newPictureBox = (flowLayoutPanel1.Controls[(newBoxRow - 1) * _columns + newBoxColumn - 1] as PictureBox)!;
            PictureBox prevPictureBox = (flowLayoutPanel1.Controls[(prevBoxRow - 1) * _columns + prevBoxColumn - 1] as PictureBox)!;

            int boxNumber = 0;

            if (!prevPictureBox.Name.Contains("BoxWithMark")) 
            {
                if (!Int32.TryParse(prevPictureBox.Name.Substring(3), out boxNumber))
                    boxNumber = 0;
            }
            else
            {
                if (!Int32.TryParse(prevPictureBox.Name.Substring(11), out boxNumber))
                    boxNumber = 0;
                _markedBoxes--;
            }

            string? prevPicturePath = _prevPicturesBoxes![boxNumber] switch
            {
                "Empty" => null,
                "Mark" => @"..\..\..\Resources\RedCross.png",
                _ => null
            };

            _prevPicturesBoxes![boxNumber] = newPictureBox.Name;

            if (newPictureBox.Name.Contains("Mark"))
            {
                boxPath = @"..\..\..\Resources\BoxWithMark.jpg";

                newPictureBox.Load(boxPath);
                newPictureBox.Name = $"BoxWithMark{prevPictureBox.Name.Substring(3)}";

                _markedBoxes++;
            }
            else
            {
                newPictureBox.Load(boxPath);

                if (prevPictureBox.Name.Contains("BoxWithMark"))
                    newPictureBox.Name = $"Box{prevPictureBox.Name.Substring(11)}";
                else
                    newPictureBox.Name = prevPictureBox.Name;
            }


            if (prevPicturePath is null)
            {
                prevPictureBox.Image = null;
                prevPictureBox.Name = "Empty";
            }
            else
            {
                prevPictureBox.Load(prevPicturePath);
                prevPictureBox.Name = "Mark";
            }
        }

        private void EditPrevPictureNamesBoxes(int boxNumber = 0, string newBoxName = "Empty")
        {
            _prevPicturesBoxes = new();

            for (int i = 0; i < _boxes; i++)
            {
                _prevPicturesBoxes.Add("Empty");

                if (i == boxNumber)
                    _prevPicturesBoxes[i] = newBoxName;
            }
        }

        private void ChangeLabelText()
        {
            labelLevelAndBoxes.Text = $"| Уровень: {_levelNumber + 1} | Коробок установлено: {_markedBoxes}/{_boxes} |";
        }
    }
}
