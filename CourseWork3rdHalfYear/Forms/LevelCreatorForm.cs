using System.Data;

namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private int _colums = 0;
        private int _rows = 0;

        private int _windowWidth = 0;
        private int _flowLayoutPanelWith = 0;
        private int _flowLayoutPanelHeight = 0;

        private List<Control> _objectsToResize = null!;

        private DataTable _table = new DataTable();
        private Panel _panel = new Panel();

        private bool _isBox = false;
        private bool _isWall = false;
        private bool _isPerson = false;
        private bool _isMark = false;

        public LevelCreatorForm()
        {
            InitializeComponent();
        }

        private void LevelCreatorForm_Load(object sender, EventArgs e)
        {
            _windowWidth = this.Width;
            _objectsToResize = new()
            {
                pictureBoxBackToMainForm, pictureBoxInformation, buttonStartOrSave, labelMapDimension, labelRows, labelColums, textBoxColums, textBoxRows
            };

            _flowLayoutPanelWith = flowLayoutPanel1.Width;
            _flowLayoutPanelHeight = flowLayoutPanel1.Height;
        }

        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);
            _windowWidth = this.Width;
        }

        private void FillFlowLayoutPanel()
        {
            for (int j = 1; j < _rows + 1; j++)
            {
                for (int k = 1; k < _colums + 1; k++)
                {
                    PictureBox picBox;
                    picBox = new PictureBox();

                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BackColor = Color.White;
                    picBox.Margin = new Padding(0);
                    picBox.Size = new Size(flowLayoutPanel1.Width / _colums, flowLayoutPanel1.Height / _rows);
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Cursor = Cursors.Hand;
                    picBox.Tag = $"{j} {k}";
                    picBox.Name = "Empty";

                    flowLayoutPanel1.Controls.Add(picBox);
                }
            }

            foreach (Control control in flowLayoutPanel1.Controls)
                control.Click += new EventHandler(PutPictureInPicBoxOnClick!);
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

        private void PutPictureInPicBoxOnClick(object sender, EventArgs e)
        {
            string path = @"..\..\..\Resources\";
            PictureBox control = (sender as PictureBox)!;

            if (_isBox)
            {
                control.Load(Path.Combine(path + "Box.png"));
                control.Name = "Box";
            }
            else if (_isMark)
            {
                control.Load(Path.Combine(path + "RedCross.png"));
                control.Name = "Mark";
            }
            else if (_isPerson)
            {
                control.Load(Path.Combine(path + "Person.png"));
                control.Name = "Person";
            }
            else if (_isWall)
            {
                control.Load(Path.Combine(path + "StoneBlock.jpg"));
                control.Name = "Wall";
            }
        }

        private void pictureBoxBox_Click(object sender, EventArgs e)
        {
            _isBox = true;

            _isWall = false;
            _isPerson = false;
            _isMark = false;
        }

        private void pictureBoxMark_Click(object sender, EventArgs e)
        {
            _isMark = true;

            _isBox = false;
            _isWall = false;
            _isPerson = false;
        }

        private void pictureBoxPerson_Click(object sender, EventArgs e)
        {
            _isPerson = true;

            _isBox = false;
            _isWall = false;
            _isMark = false;
        }

        private void pictureBoxWall_Click(object sender, EventArgs e)
        {
            _isWall = true;

            _isBox = false;
            _isPerson = false;
            _isMark = false;
        }

        private void pictureBoxBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();

            this.Close();
        }

        private void pictureBoxInformation_Click(object sender, EventArgs e)
        {
            LevelCreatorInformationForm levelCreatorInformationForm = new LevelCreatorInformationForm();
            levelCreatorInformationForm.ShowDialog();
        }

        private void buttonStartOrSave_Click(object sender, EventArgs e)
        {
            if (buttonStartOrSave.Text == "Начать")
            {
                buttonStartOrSave.Font = new Font("MV Boli", 11);

                if (Int32.TryParse(textBoxColums.Text, out int colums) && Int32.TryParse(textBoxRows.Text, out int rows))
                {
                    if (colums < 4 || rows < 4)
                    {
                        textBoxColums.Clear();
                        textBoxRows.Clear();
                        MessageBox.Show("Количество рядов и столбцов не может быть меньше 4", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (colums > 25 || rows > 25)
                    {
                        textBoxColums.Clear();
                        textBoxRows.Clear();
                        MessageBox.Show("Количество рядов и столбцов не может быть больше 25", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        buttonStartOrSave.Text = "Сохранить";

                        _colums = colums;
                        _rows = rows;

                        textBoxColums.Clear();
                        textBoxRows.Clear();
                        FillFlowLayoutPanel();
                    }
                }
                else
                {
                    textBoxColums.Clear();
                    textBoxRows.Clear();
                    MessageBox.Show("Ввведите корректные числа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (buttonStartOrSave.Text == "Сохранить")
            {
                buttonStartOrSave.Font = new Font("MV Boli", 12);

                string path = @"..\..\..\Maps\";

                for (int i = 0; ; i++)
                {
                    if (!File.Exists(Path.Combine(path + $"map{i}.txt")))
                    {
                        path = Path.Combine(Path.Combine(path + $"map{i}.txt"));
                        char[,] map = new char[_rows + 2, _colums + 2];

                        for (int j = 0; j < _colums + 2; j++)
                        {
                            map[0, j] = '#';
                            map[_rows + 1, j] = '#';
                        }

                        for (int j = 1; j < _rows + 2; j++)
                        {
                            map[j, 0] = '#';
                            map[j, _colums + 1] = '#';
                        }

                        for (int j = 1; j < _rows + 1; j++)
                        {
                            for (int k = 1; k < _colums + 1; k++)
                            {
                                map[j, k] = flowLayoutPanel1.Controls[(j - 1) * _colums + (k - 1)].Name switch
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
                                for (int k = 0; k < _colums + 2; k++)
                                {
                                    textWriter.Write(map[j, k]);
                                }
                                textWriter.Write('\n');
                            }
                        }

                        break;
                    }
                }
            }
        }
    }
}
