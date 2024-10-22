namespace CourseWork3rdHalfYear.Forms
{
    public partial class PlayForm : Form
    {
        private int _levelNumber = 0;

        public PlayForm()
        {
            InitializeComponent();
            ChangeLevel(_levelNumber);
        }

        private void ChangeLevel(int levelNumber)
        {
            string pathMap = $@"..\..\..\Maps\map{levelNumber}.txt";
            string[] mapInLines = File.ReadAllLines(pathMap);

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
    }
}
