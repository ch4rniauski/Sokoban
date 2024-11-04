namespace CourseWork3rdHalfYear.Forms
{
    public partial class ChangeLevelForm : Form
    {
        private int _columns = 0;
        private int _rows = 0;

        private int _levelNumber = 0;

        private int _windowWidth = 0;
        private int _flowLayoutPanelWith = 0;
        private int _flowLayoutPanelHeight = 0;

        private List<Control> _objectsToResize = null!;

        private bool _isBox = false;
        private bool _isWall = false;
        private bool _isPerson = false;
        private bool _isMark = false;
        private bool _isBroom = false;

        private byte _personAmount = 0;
        private int _boxesAmount = 0;
        private int _marksAmount = 0;

        private bool _isMapChangedWithoutSave = false;

        public ChangeLevelForm()
        {
            InitializeComponent();
            ChangeLevel();
            SetValuesBeforeFormLoad();
        }

        private void SetValuesBeforeFormLoad()
        {
            _windowWidth = this.Width;

            _objectsToResize = new()
            {
                BackToMenuFormPictureBox, InformationPictureBox, SaveButton, PrevLevelPictureBox, NextLevelPictureBox, LevelAndBoxeLabel, DeleteLevelButton
            };

            _flowLayoutPanelWith = FlowLayoutPanel.Width;
            _flowLayoutPanelHeight = FlowLayoutPanel.Height;
        }

        private void ChangeLevelForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);

            _windowWidth = this.Width;
        }

        private void FillFlowLayoutPanel(string[] mapInLines)
        {
            for (int i = 1; i < mapInLines.Length - 1; i++)
            {
                for (int j = 1; j < mapInLines[0].Length - 1; j++)
                {
                    PictureBox picBox = new();

                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BackColor = Color.White;
                    picBox.Margin = new Padding(0);
                    picBox.Size = new Size(FlowLayoutPanel.Width / (mapInLines[0].Length - 2), FlowLayoutPanel.Height / (mapInLines.Length - 2));
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Cursor = Cursors.Hand;

                    picBox.MouseClick += new MouseEventHandler(PutPictureInPicBoxOnClick!);

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

                            _boxesAmount++;

                            break;
                        case 'P':
                            pathResources = @"..\..\..\Resources\Person.png";
                            picBox.Name = "Person";

                            _personAmount++;

                            break;
                        case 'X':
                            pathResources = @"..\..\..\Resources\RedCross.png";
                            picBox.Name = "Mark";

                            _marksAmount++;

                            break;
                    }

                    if (pathResources == "")
                    {
                        picBox.Name = "Empty";
                        FlowLayoutPanel.Controls.Add(picBox);
                        continue;
                    }

                    picBox.Load(pathResources);
                    FlowLayoutPanel.Controls.Add(picBox);
                }
            }
        }

        private void PutPictureInPicBoxOnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                string pathRecources = @"..\..\..\Resources\";
                PictureBox picture = (sender as PictureBox)!;

                _isMapChangedWithoutSave = true;

                if (_isBox && picture.Name != "Box")
                {
                    _boxesAmount++;

                    if (picture.Name == "Mark")
                        _marksAmount--;
                    else if (picture.Name == "Person")
                        _personAmount--;

                    picture.Load(Path.Combine(pathRecources + "Box.png"));
                    picture.Name = "Box";
                }
                else if (_isMark && picture.Name != "Mark")
                {
                    _marksAmount++;

                    if (picture.Name == "Box")
                        _boxesAmount--;
                    else if (picture.Name == "Person")
                        _personAmount--;

                    picture.Load(Path.Combine(pathRecources + "RedCross.png"));
                    picture.Name = "Mark";
                }
                else if (_isPerson && picture.Name != "Person")
                {
                    if (_personAmount == 0)
                    {
                        _personAmount++;

                        if (picture.Name == "Mark")
                            _marksAmount--;
                        else if (picture.Name == "Box")
                            _boxesAmount--;

                        picture.Load(Path.Combine(pathRecources + "Person.png"));
                        picture.Name = "Person";
                    }
                    else
                        MessageBox.Show("На карте не может быть больше одного персонажа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (_isWall && picture.Name != "Wall")
                {
                    if (picture.Name == "Mark")
                        _marksAmount--;
                    else if (picture.Name == "Box")
                        _boxesAmount--;
                    else if (picture.Name == "Person")
                        _personAmount--;

                    picture.Load(Path.Combine(pathRecources + "StoneBlock.jpg"));
                    picture.Name = "Wall";
                }
                else if (_isBroom)
                {
                    if (picture.Name == "Person")
                        _personAmount--;
                    else if (picture.Name == "Box")
                        _boxesAmount--;
                    else if (picture.Name == "Mark")
                        _marksAmount--;
                    else if (picture.Name == "Empty")
                        _isMapChangedWithoutSave = false;

                    picture.Image = null;
                    picture.Name = "Empty";
                }
                else
                    _isMapChangedWithoutSave = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                PictureBox picture = (sender as PictureBox)!;

                _isMapChangedWithoutSave = true;

                if (picture.Name == "Empty")
                    _isMapChangedWithoutSave = false;

                picture.Image = null;
                picture.Name = "Empty";
            }
        }

        private void ChangeLevel()
        {
            _boxesAmount = 0;
            _marksAmount = 0;

            string pathMap = $@"..\..\..\Maps\map{_levelNumber}.txt";
            string pathPrevMap = $@"..\..\..\Maps\map{_levelNumber - 1}.txt";
            string pathNextMap = $@"..\..\..\Maps\map{_levelNumber + 1}.txt";

            if (!File.Exists(pathPrevMap))
                PrevLevelPictureBox.Hide();
            else
                PrevLevelPictureBox.Show();

            if (!File.Exists(pathNextMap))
                NextLevelPictureBox.Hide();
            else
                NextLevelPictureBox.Show();


            string[] mapInLines = File.ReadAllLines(pathMap);
            _columns = mapInLines[0].Length - 2;
            _rows = mapInLines.Length - 2;

            FillFlowLayoutPanel(mapInLines);
            ChangeLabelText();
        }

        private void ChangeLabelText()
        {
            LevelAndBoxeLabel.Text = $"| Уровень: {_levelNumber + 1} |";
        }

        private void BoxPictureBox_Click(object sender, EventArgs e)
        {
            _isBox = true;

            _isWall = false;
            _isPerson = false;
            _isMark = false;
            _isBroom = false;
        }

        private void WallPictureBox_Click(object sender, EventArgs e)
        {
            _isWall = true;

            _isBox = false;
            _isPerson = false;
            _isMark = false;
            _isBroom = false;
        }

        private void MarkPictureBox_Click(object sender, EventArgs e)
        {
            _isMark = true;

            _isBox = false;
            _isWall = false;
            _isPerson = false;
            _isBroom = false;
        }

        private void PersonPictureBox_Click(object sender, EventArgs e)
        {
            _isPerson = true;

            _isBox = false;
            _isWall = false;
            _isMark = false;
            _isBroom = false;
        }

        private void BroomPictureBox_Click(object sender, EventArgs e)
        {
            _isBroom = true;

            _isWall = false;
            _isPerson = false;
            _isMark = false;
            _isBox = false;
        }

        private void PrevLevelPictureBox_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel.Controls.Clear();

            _levelNumber--;
            ChangeLevel();
        }

        private void NextLevelPictureBox_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel.Controls.Clear();

            _levelNumber++;
            ChangeLevel();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_personAmount == 0)
            {
                MessageBox.Show("Установите персонажа на карту", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (_boxesAmount != _marksAmount)
            {
                MessageBox.Show("Количество ящиков не соответствует количеству меток", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (_boxesAmount == 0)
            {
                MessageBox.Show("Установите как хотя бы один ящик", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string path = $@"..\..\..\Maps\map{_levelNumber}.txt";
            SaveMap(path);

            _isMapChangedWithoutSave = false;
        }

        private void SaveMap(string path)
        {
            char[,] map = new char[_rows + 2, _columns + 2];

            for (int j = 0; j < _columns + 2; j++)
            {
                map[0, j] = '#';
                map[_rows + 1, j] = '#';
            }

            for (int j = 1; j < _rows + 2; j++)
            {
                map[j, 0] = '#';
                map[j, _columns + 1] = '#';
            }

            for (int j = 1; j < _rows + 1; j++)
            {
                for (int k = 1; k < _columns + 1; k++)
                {
                    map[j, k] = FlowLayoutPanel.Controls[(j - 1) * _columns + (k - 1)].Name switch
                    {
                        "Box" => 'B',
                        "Person" => 'P',
                        "Wall" => '#',
                        "Mark" => 'X',
                        _ => '\0'
                    };
                }
            }

            using (StreamWriter textWriter = new(path))
            {
                for (int j = 0; j < _rows + 2; j++)
                {
                    for (int k = 0; k < _columns + 2; k++)
                    {
                        textWriter.Write(map[j, k]);
                    }
                    textWriter.Write('\n');
                }
            }
        }

        private void InformationPictureBox_Click(object sender, EventArgs e)
        {
            LevelCreatorInformationForm levelCreatorInformationForm = new();
            levelCreatorInformationForm.ShowDialog();
        }

        private void BackToMenuFormPictureBox_Click(object sender, EventArgs e)
        {
            if (_isMapChangedWithoutSave)
            {
                DialogResult result = MessageBox.Show("Сохранить внесённые изменения?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string path = $@"..\..\..\Maps\map{_levelNumber}.txt";

                    SaveMap(path);
                }
            }
            this.Hide();
            this.Close();

            MenuForm menuForm = new();

            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Location = this.Location;
            menuForm.Size = this.Size;

            menuForm.ShowDialog();
        }

        private void RenameMaps()
        {
            for (int i = _levelNumber + 1; ; i++)
            {
                string path = $@"..\..\..\Maps\map{i}.txt";

                if (File.Exists(path))
                {
                    string newPath = $@"..\..\..\Maps\map{i - 1}.txt";
                    File.Move(path, newPath);
                }
                else
                    return;
            }
        }

        private void DeleteLevelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить карту?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            string pathMap = $@"..\..\..\Maps\map{_levelNumber}.txt";
            string pathPrevMap = $@"..\..\..\Maps\map{_levelNumber - 1}.txt";
            string pathNextMap = $@"..\..\..\Maps\map{_levelNumber + 1}.txt";

            File.Delete(pathMap);

            FlowLayoutPanel.Controls.Clear();

            if (File.Exists(pathPrevMap))
            {
                RenameMaps();

                _levelNumber--;
                ChangeLevel();

                pathMap = $@"..\..\..\Maps\map{_levelNumber + 1}.txt";
                if (File.Exists(pathMap))
                    NextLevelPictureBox.Show();
            }
            else if (File.Exists(pathNextMap))
            {
                RenameMaps();

                _levelNumber++;
                ChangeLevel();
            }
            else
            {
                this.Hide();
                this.Close();

                MenuForm menuForm = new();

                menuForm.StartPosition = FormStartPosition.Manual;
                menuForm.Location = this.Location;
                menuForm.Size = this.Size;

                menuForm.ShowDialog();
            }
        }
    }
}
