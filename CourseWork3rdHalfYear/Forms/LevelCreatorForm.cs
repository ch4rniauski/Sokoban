using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Windows.Forms;

namespace CourseWork3rdHalfYear.Forms
{
    public partial class LevelCreatorForm : Form
    {
        private DataTable _table = new DataTable();
        private Panel _panel = new Panel();

        private Rectangle _panel1OriginalRectangle;

        private Rectangle _pictureBox1OriginalRectangle;
        private Rectangle _pictureBox2OriginalRectangle;
        private Rectangle _pictureBox3OriginalRectangle;
        private Rectangle _pictureBox4OriginalRectangle;
        private Rectangle _pictureBox5OriginalRectangle;
        private Rectangle _pictureBox6OriginalRectangle;

        private Rectangle _originalFormSize;

        private Rectangle _label1OriginalRectangle;
        private Rectangle _label2OriginalRectangle;
        private Rectangle _label3OriginalRectangle;

        private Rectangle _textBox1OriginalRectangle;
        private Rectangle _textBox2OriginalRectangle;

        private Rectangle _button1OriginalRectangle;

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
            for (int i = 0; i < 25; i++)
            {
                PictureBox picBox;
                picBox = new PictureBox();
                picBox.Size = new Size((flowLayoutPanel1.Width - 45) / 5, (flowLayoutPanel1.Height - 45) / 5);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Cursor = Cursors.Hand;
                picBox.Load(@"D:\university\CourseWork3rdHalfYear\CourseWork3rdHalfYear\Resources\Box.png");
                flowLayoutPanel1.Controls.Add(picBox);
            }
            //_panel1OriginalRectangle = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);

            //_pictureBox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            //_pictureBox2OriginalRectangle = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            //_pictureBox3OriginalRectangle = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height);
            //_pictureBox4OriginalRectangle = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Width, pictureBox4.Height);
            //_pictureBox5OriginalRectangle = new Rectangle(pictureBox5.Location.X, pictureBox5.Location.Y, pictureBox5.Width, pictureBox5.Height);
            //_pictureBox6OriginalRectangle = new Rectangle(pictureBox6.Location.X, pictureBox6.Location.Y, pictureBox6.Width, pictureBox6.Height);

            //_label1OriginalRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            //_label2OriginalRectangle = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            //_label3OriginalRectangle = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);

            //_textBox1OriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            //_textBox2OriginalRectangle = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);

            //_button1OriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);

            //_originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
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

        private void resizeControl1(Rectangle rectangle, Control control)
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

        private void LevelCreatorForm_Resize(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(889 + this.Width - 960, 4);
            pictureBox6.Location = new Point(820 + this.Width - 960, 4);

            button1.Location = new Point(720 + this.Width - 960, 8);

            label1.Location = new Point(441 + this.Width - 960, 20);
            label2.Location = new Point(666 + this.Width - 960, 0);
            label3.Location = new Point(588 + this.Width - 960, 0);

            textBox1.Location = new Point(603 + this.Width - 960, 20);
            textBox2.Location = new Point(671 + this.Width - 960, 20);
            /*resizeControl(_pictureBox1OriginalRectangle, pictureBox1);
            resizeControl(_pictureBox2OriginalRectangle, pictureBox2);
            resizeControl(_pictureBox3OriginalRectangle, pictureBox3);
            resizeControl(_pictureBox4OriginalRectangle, pictureBox4);
            resizeControl(_pictureBox5OriginalRectangle, pictureBox5);
            resizeControl(_pictureBox6OriginalRectangle, pictureBox6);

            resizeControl(_label1OriginalRectangle, label1);
            resizeControl(_label2OriginalRectangle, label2);
            resizeControl(_label3OriginalRectangle, label3);

            resizeControl1(_dataGridView1OriginalRectangle, dataGridView1);

            resizeControl(_panel1OriginalRectangle, panel1);*/
            //resizeControl(_panel2OriginalRectangle, panel2);
            /*resizeControl(_panel3OriginalRectangle, panel3);

            resizeControl(_textBox1OriginalRectangle, textBox1);
            resizeControl(_textBox2OriginalRectangle, textBox2);

            resizeControl(_button1OriginalRectangle, button1);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int colums) && Int32.TryParse(textBox2.Text, out int rows))
            {

            }
            else
            {

            }
        }
    }
}
