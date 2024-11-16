namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private int _columns = 0;
        private int _rows = 0;

        private int _windowWidth = 0;
        private int _flowLayoutPanelWidth = 0;

        private List<Control> _objectsToResize = null!;

        private bool _isBox = false;
        private bool _isWall = false;
        private bool _isPerson = false;
        private bool _isMark = false;
        private bool _isBroom = false;

        private byte _personAmount = 0;
        private int _boxesAmount = 0;
        private int _marksAmount = 0;

        private bool _isMapSaved = false;
        private bool _isMapChangedWithoutSave = false;
        private int _savedMapNumber = 0;

        public LevelCreatorForm()
        {
            InitializeComponent();
            SetValuesBeforeFormLoad();
        }

        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);

            _windowWidth = this.Width;

            ChangeFlowLayoutPanelSize();
        }

        private void FillFlowLayoutPanel()
        {
            for (int j = 1; j < _rows + 1; j++)
            {
                for (int k = 1; k < _columns + 1; k++)
                {
                    PictureBox picBox = new();

                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BackColor = Color.White;
                    picBox.Margin = new Padding(0);
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Cursor = Cursors.Hand;
                    picBox.Name = "Empty";

                    picBox.MouseClick += new MouseEventHandler(PutPictureInPicBoxOnClick!);

                    FlowLayoutPanel.Controls.Add(picBox);
                }
            }

            ChangeFlowLayoutPanelSize();
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
                else if (picture.Name == "Box")
                    _boxesAmount--;
                else if (picture.Name == "Person")
                    _personAmount--;
                else if (picture.Name == "Mark")
                    _marksAmount--;

                picture.Image = null;
                picture.Name = "Empty";
            }
        }

        private void BoxPictureBox_Click(object sender, EventArgs e)
        {
            _isBox = true;

            _isWall = false;
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

        private void WallPictureBox_Click(object sender, EventArgs e)
        {
            _isWall = true;

            _isBox = false;
            _isPerson = false;
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

        private void InformationPictureBox_Click(object sender, EventArgs e)
        {
            LevelCreatorInformationForm levelCreatorInformationForm = new();
            levelCreatorInformationForm.ShowDialog();
        }

        private void StartOrSaveButton_Click(object sender, EventArgs e)
        {
            if (StartOrSaveButton.Text == "Начать")
            {
                StartOrSaveButton.Font = new Font("Segoe UI", 11);

                if (Int32.TryParse(ColumsTextBox.Text, out int colums) && Int32.TryParse(RowsTextBox.Text, out int rows))
                {
                    if (colums < 4 || rows < 4)
                    {
                        ColumsTextBox.Clear();
                        RowsTextBox.Clear();
                        MessageBox.Show("Количество рядов и столбцов не может быть меньше 4", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (colums > 25 || rows > 25)
                    {
                        ColumsTextBox.Clear();
                        RowsTextBox.Clear();
                        MessageBox.Show("Количество рядов и столбцов не может быть больше 25", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        StartOrSaveButton.Text = "Сохранить";

                        MapDimensionLabel.Hide();
                        ColumsLabel.Hide();
                        RowsLabel.Hide();
                        ColumsTextBox.Hide();
                        RowsTextBox.Hide();

                        _columns = colums;
                        _rows = rows;

                        ColumsTextBox.Clear();
                        RowsTextBox.Clear();
                        FillFlowLayoutPanel();
                    }
                }
                else
                {
                    ColumsTextBox.Clear();
                    RowsTextBox.Clear();
                    MessageBox.Show("Ввведите корректные числа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (StartOrSaveButton.Text == "Сохранить")
            {
                if (_personAmount == 0)
                {
                    MessageBox.Show("Установите персонажа на карту", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (_boxesAmount != _marksAmount )
                {
                    MessageBox.Show("Количество ящиков не соответствует количеству меток", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (_boxesAmount == 0)
                {
                    MessageBox.Show("Установите как хотя бы один ящик", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_isMapChangedWithoutSave)
                {
                    string path = @"..\..\..\Maps\";
                    if (_isMapSaved)
                    {
                        DialogResult result = MessageBox.Show("Сохранить изменения в уже созданную карту?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            path = Path.Combine(Path.Combine(path + $"map{_savedMapNumber}.txt"));
                            SaveMap(path);
                            return;
                        }
                    }
                    _isMapSaved = true;

                    for (int i = 0; ; i++)
                    {
                        if (!File.Exists(Path.Combine(path + $"map{i}.txt")))
                        {
                            _savedMapNumber = i;
                            path = Path.Combine(Path.Combine(path + $"map{i}.txt"));

                            SaveMap(path);

                            break;
                        }
                    }

                    _isMapChangedWithoutSave = false;
                }
            }
        }

        private void BackToMenuFormPictureBox_Click(object sender, EventArgs e)
        {
            if (_isMapChangedWithoutSave)
            {
                if (_isMapSaved)
                {
                    DialogResult result1 = MessageBox.Show("Сохранить внесённые изменения?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result1 == DialogResult.Yes)
                    {
                        DialogResult result2 = MessageBox.Show("Сохранить изменения в уже созданную карту?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        string path = $@"..\..\..\Maps\";

                        if (result2 == DialogResult.Yes)
                        {
                            path = Path.Combine(Path.Combine(path + $"map{_savedMapNumber}.txt"));
                            SaveMap(path);
                        }
                        else
                        {
                            for (int i = 0; ; i++)
                            {
                                if (!File.Exists(Path.Combine(path + $"map{i}.txt")))
                                {
                                    path = Path.Combine(Path.Combine(path + $"map{i}.txt"));
                                    SaveMap(path);
                                    break;
                                }
                            }
                            SaveMap(path);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Сохранить внесённые изменения?", "Уточнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string path = $@"..\..\..\Maps\";

                        for (int i = 0; ; i++)
                        {
                            if (!File.Exists(Path.Combine(path + $"map{i}.txt")))
                            {
                                path = Path.Combine(Path.Combine(path + $"map{i}.txt"));
                                SaveMap(path);
                                break;
                            }
                        }
                        SaveMap(path);
                    }
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

        private void SetValuesBeforeFormLoad()
        {
            _windowWidth = this.Width;

            _objectsToResize = new()
            {
                BackToMenuFormPictureBox, InformationPictureBox, StartOrSaveButton, MapDimensionLabel, RowsLabel, ColumsLabel, ColumsTextBox, RowsTextBox
            };

            _flowLayoutPanelWidth = FlowLayoutPanel.Width;
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

        private void ChangeFlowLayoutPanelSize()
        {
            int formSize = 0;
            int imageSize = 0;

            if (this.Width < this.Height - Panel.Height - 40)
            {
                formSize = this.Width - 40;
                imageSize = formSize / _columns;

                FlowLayoutPanel.Width = formSize;
                FlowLayoutPanel.Height = imageSize * _rows;

                if (FlowLayoutPanel.Height > this.Height - Panel.Height - 40)
                {
                    formSize = this.Height - Panel.Height - 40;
                    imageSize = formSize / _rows;

                    FlowLayoutPanel.Height = formSize;
                    FlowLayoutPanel.Width = imageSize * _columns;
                }
            }
            else
            {
                formSize = this.Height - Panel.Height - 40;
                imageSize = formSize / _rows;

                FlowLayoutPanel.Height = formSize;
                FlowLayoutPanel.Width = imageSize * _columns;

                if (FlowLayoutPanel.Width > this.Width - 40)
                {
                    formSize = this.Width - 40;
                    imageSize = formSize / _columns;

                    FlowLayoutPanel.Width = formSize;
                    FlowLayoutPanel.Height = imageSize * _rows;
                }
            }

            foreach (PictureBox control in FlowLayoutPanel.Controls)
                control.Size = new Size(imageSize, imageSize);

            _flowLayoutPanelWidth = FlowLayoutPanel.Width;

            ChangeFlowLayoutPanelPosition();
        }

        private void ChangeFlowLayoutPanelPosition()
        {
            FlowLayoutPanel.Left = (this.Width - _flowLayoutPanelWidth) / 2;
        }
    }
}
