namespace CourseWork3rdHalfYear.Forms
{
    partial class LevelCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelCreatorForm));
            BoxPictureBox = new PictureBox();
            WallPictureBox = new PictureBox();
            MarkPictureBox = new PictureBox();
            PersonPictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            BackToMenuFormPictureBox = new PictureBox();
            InformationPictureBox = new PictureBox();
            BroomPictureBox = new PictureBox();
            StartOrSaveButton = new Button();
            MapDimensionLabel = new Label();
            RowsTextBox = new TextBox();
            ColumsTextBox = new TextBox();
            ColumsLabel = new Label();
            RowsLabel = new Label();
            Panel = new Panel();
            FlowLayoutPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)BoxPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WallPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InformationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BroomPictureBox).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // BoxPictureBox
            // 
            BoxPictureBox.Cursor = Cursors.Hand;
            BoxPictureBox.Image = Properties.Resources.Box;
            BoxPictureBox.Location = new Point(0, 4);
            BoxPictureBox.Name = "BoxPictureBox";
            BoxPictureBox.Size = new Size(50, 50);
            BoxPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BoxPictureBox.TabIndex = 0;
            BoxPictureBox.TabStop = false;
            toolTip1.SetToolTip(BoxPictureBox, "Ящик");
            BoxPictureBox.Click += BoxPictureBox_Click;
            // 
            // WallPictureBox
            // 
            WallPictureBox.Cursor = Cursors.Hand;
            WallPictureBox.Image = Properties.Resources.StoneBlock;
            WallPictureBox.Location = new Point(56, 4);
            WallPictureBox.Name = "WallPictureBox";
            WallPictureBox.Size = new Size(50, 50);
            WallPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            WallPictureBox.TabIndex = 1;
            WallPictureBox.TabStop = false;
            toolTip1.SetToolTip(WallPictureBox, "Стена");
            WallPictureBox.Click += WallPictureBox_Click;
            // 
            // MarkPictureBox
            // 
            MarkPictureBox.BackColor = Color.Transparent;
            MarkPictureBox.Cursor = Cursors.Hand;
            MarkPictureBox.Image = Properties.Resources.RedCross;
            MarkPictureBox.Location = new Point(112, 4);
            MarkPictureBox.Name = "MarkPictureBox";
            MarkPictureBox.Size = new Size(50, 50);
            MarkPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MarkPictureBox.TabIndex = 2;
            MarkPictureBox.TabStop = false;
            toolTip1.SetToolTip(MarkPictureBox, "Метка");
            MarkPictureBox.Click += MarkPictureBox_Click;
            // 
            // PersonPictureBox
            // 
            PersonPictureBox.BackColor = Color.Transparent;
            PersonPictureBox.Cursor = Cursors.Hand;
            PersonPictureBox.Image = Properties.Resources.Person;
            PersonPictureBox.Location = new Point(168, 4);
            PersonPictureBox.Name = "PersonPictureBox";
            PersonPictureBox.Size = new Size(50, 50);
            PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonPictureBox.TabIndex = 4;
            PersonPictureBox.TabStop = false;
            toolTip1.SetToolTip(PersonPictureBox, "Персонаж");
            PersonPictureBox.Click += PersonPictureBox_Click;
            // 
            // BackToMenuFormPictureBox
            // 
            BackToMenuFormPictureBox.BackColor = Color.Transparent;
            BackToMenuFormPictureBox.Cursor = Cursors.Hand;
            BackToMenuFormPictureBox.Image = Properties.Resources.GoBack;
            BackToMenuFormPictureBox.Location = new Point(889, 4);
            BackToMenuFormPictureBox.Name = "BackToMenuFormPictureBox";
            BackToMenuFormPictureBox.Size = new Size(50, 50);
            BackToMenuFormPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BackToMenuFormPictureBox.TabIndex = 5;
            BackToMenuFormPictureBox.TabStop = false;
            toolTip1.SetToolTip(BackToMenuFormPictureBox, "Вернуться в главное меню");
            BackToMenuFormPictureBox.Click += BackToMenuFormPictureBox_Click;
            // 
            // InformationPictureBox
            // 
            InformationPictureBox.BackColor = Color.Transparent;
            InformationPictureBox.Cursor = Cursors.Hand;
            InformationPictureBox.Image = Properties.Resources.Info;
            InformationPictureBox.Location = new Point(820, 4);
            InformationPictureBox.Name = "InformationPictureBox";
            InformationPictureBox.Size = new Size(50, 50);
            InformationPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            InformationPictureBox.TabIndex = 6;
            InformationPictureBox.TabStop = false;
            toolTip1.SetToolTip(InformationPictureBox, "Информация");
            InformationPictureBox.Click += InformationPictureBox_Click;
            // 
            // BroomPictureBox
            // 
            BroomPictureBox.BackColor = Color.Transparent;
            BroomPictureBox.Cursor = Cursors.Hand;
            BroomPictureBox.Image = Properties.Resources.Broom;
            BroomPictureBox.Location = new Point(224, 4);
            BroomPictureBox.Name = "BroomPictureBox";
            BroomPictureBox.Size = new Size(50, 50);
            BroomPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BroomPictureBox.TabIndex = 14;
            BroomPictureBox.TabStop = false;
            toolTip1.SetToolTip(BroomPictureBox, "Очистка ячейки");
            BroomPictureBox.Click += BroomPictureBox_Click;
            // 
            // StartOrSaveButton
            // 
            StartOrSaveButton.Cursor = Cursors.Hand;
            StartOrSaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartOrSaveButton.Location = new Point(720, 8);
            StartOrSaveButton.Name = "StartOrSaveButton";
            StartOrSaveButton.Size = new Size(94, 41);
            StartOrSaveButton.TabIndex = 13;
            StartOrSaveButton.Text = "Начать";
            StartOrSaveButton.UseVisualStyleBackColor = true;
            StartOrSaveButton.Click += StartOrSaveButton_Click;
            // 
            // MapDimensionLabel
            // 
            MapDimensionLabel.AutoSize = true;
            MapDimensionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MapDimensionLabel.Location = new Point(440, 20);
            MapDimensionLabel.Name = "MapDimensionLabel";
            MapDimensionLabel.Size = new Size(147, 20);
            MapDimensionLabel.TabIndex = 2;
            MapDimensionLabel.Text = "Размерность карты:";
            // 
            // RowsTextBox
            // 
            RowsTextBox.Location = new Point(671, 20);
            RowsTextBox.Name = "RowsTextBox";
            RowsTextBox.Size = new Size(35, 23);
            RowsTextBox.TabIndex = 10;
            // 
            // ColumsTextBox
            // 
            ColumsTextBox.Location = new Point(603, 20);
            ColumsTextBox.Name = "ColumsTextBox";
            ColumsTextBox.Size = new Size(35, 23);
            ColumsTextBox.TabIndex = 9;
            // 
            // ColumsLabel
            // 
            ColumsLabel.AutoSize = true;
            ColumsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColumsLabel.Location = new Point(588, 0);
            ColumsLabel.Name = "ColumsLabel";
            ColumsLabel.Size = new Size(66, 17);
            ColumsLabel.TabIndex = 12;
            ColumsLabel.Text = "Столбцов";
            // 
            // RowsLabel
            // 
            RowsLabel.AutoSize = true;
            RowsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RowsLabel.Location = new Point(666, 0);
            RowsLabel.Name = "RowsLabel";
            RowsLabel.Size = new Size(44, 17);
            RowsLabel.TabIndex = 11;
            RowsLabel.Text = "Рядов";
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveCaption;
            Panel.Controls.Add(BroomPictureBox);
            Panel.Controls.Add(RowsLabel);
            Panel.Controls.Add(InformationPictureBox);
            Panel.Controls.Add(ColumsTextBox);
            Panel.Controls.Add(BackToMenuFormPictureBox);
            Panel.Controls.Add(ColumsLabel);
            Panel.Controls.Add(PersonPictureBox);
            Panel.Controls.Add(MarkPictureBox);
            Panel.Controls.Add(WallPictureBox);
            Panel.Controls.Add(MapDimensionLabel);
            Panel.Controls.Add(BoxPictureBox);
            Panel.Controls.Add(StartOrSaveButton);
            Panel.Dock = DockStyle.Top;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(944, 58);
            Panel.TabIndex = 8;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = SystemColors.AppWorkspace;
            FlowLayoutPanel.Dock = DockStyle.Fill;
            FlowLayoutPanel.Location = new Point(0, 58);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(944, 443);
            FlowLayoutPanel.TabIndex = 11;
            FlowLayoutPanel.Resize += FlowLayoutPanel_Resize;
            // 
            // LevelCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(FlowLayoutPanel);
            Controls.Add(RowsTextBox);
            Controls.Add(Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "LevelCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Creator";
            Resize += LevelCreatorForm_Resize;
            ((System.ComponentModel.ISupportInitialize)BoxPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WallPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InformationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BroomPictureBox).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoxPictureBox;
        private PictureBox WallPictureBox;
        private PictureBox MarkPictureBox;
        private PictureBox PersonPictureBox;
        private ToolTip toolTip1;
        private PictureBox BackToMenuFormPictureBox;
        private PictureBox InformationPictureBox;
        private Button StartOrSaveButton;
        private Label MapDimensionLabel;
        private TextBox RowsTextBox;
        private TextBox ColumsTextBox;
        private Label ColumsLabel;
        private Label RowsLabel;
        private Panel Panel;
        private FlowLayoutPanel FlowLayoutPanel;
        private PictureBox BroomPictureBox;
    }
}