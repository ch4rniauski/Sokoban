using System.Data;

namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private int _colums = 0;
        private int _rows = 0;
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
        }

        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in _objectsToResize)
                control.Location = new Point(control.Location.X + this.Width - _windowWidth, control.Location.Y);
            _windowWidth = this.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int colums) && Int32.TryParse(textBox2.Text, out int rows))
            {
                if (colums < 4 || rows < 4)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Количество рядов и столбцов не может быть меньше 4", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (colums > 25 || rows > 25)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Количество рядов и столбцов не может быть больше 25", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _colums = colums;
                    _rows = rows;

                    textBox1.Clear();
                    textBox2.Clear();
                    FillFlowLayoutPanel();
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Ввведите корректные числа", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillFlowLayoutPanel()
        {
            //string path = @"..\..\..\Resources";

            for (int i = 0; i < _colums * _rows; i++)
            {
                PictureBox picBox;
                picBox = new PictureBox();

                picBox.BorderStyle = BorderStyle.FixedSingle;
                picBox.BackColor = Color.White;
                picBox.Margin = new Padding(0);
                picBox.Size = new Size(flowLayoutPanel1.Width / _colums, flowLayoutPanel1.Height / _rows);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Cursor = Cursors.Hand;
                //picBox.Load(@"D:\university\CourseWork3rdHalfYear\CourseWork3rdHalfYear\Resources\Box.png");

                flowLayoutPanel1.Controls.Add(picBox);
            }
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                    control.Size = new Size(flowLayoutPanel1.Width / _colums, flowLayoutPanel1.Height / _rows);
            }
        }
    }
}
