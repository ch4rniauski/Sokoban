namespace CourseWork3rdHalfYear.Forms
{
    partial class ChangeLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLevelForm));
            Panel = new Panel();
            DeleteLevelButton = new Button();
            LevelAndBoxeLabel = new Label();
            NextLevelPictureBox = new PictureBox();
            PrevLevelPictureBox = new PictureBox();
            BroomPictureBox = new PictureBox();
            InformationPictureBox = new PictureBox();
            BackToMenuFormPictureBox = new PictureBox();
            PersonPictureBox = new PictureBox();
            MarkPictureBox = new PictureBox();
            WallPictureBox = new PictureBox();
            BoxPictureBox = new PictureBox();
            SaveButton = new Button();
            FlowLayoutPanel = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NextLevelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevLevelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BroomPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InformationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WallPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoxPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveCaption;
            Panel.Controls.Add(DeleteLevelButton);
            Panel.Controls.Add(LevelAndBoxeLabel);
            Panel.Controls.Add(NextLevelPictureBox);
            Panel.Controls.Add(PrevLevelPictureBox);
            Panel.Controls.Add(BroomPictureBox);
            Panel.Controls.Add(InformationPictureBox);
            Panel.Controls.Add(BackToMenuFormPictureBox);
            Panel.Controls.Add(PersonPictureBox);
            Panel.Controls.Add(MarkPictureBox);
            Panel.Controls.Add(WallPictureBox);
            Panel.Controls.Add(BoxPictureBox);
            Panel.Controls.Add(SaveButton);
            Panel.Dock = DockStyle.Top;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(944, 58);
            Panel.TabIndex = 9;
            // 
            // DeleteLevelButton
            // 
            DeleteLevelButton.BackColor = Color.SkyBlue;
            DeleteLevelButton.Cursor = Cursors.Hand;
            DeleteLevelButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteLevelButton.Location = new Point(633, 8);
            DeleteLevelButton.Name = "DeleteLevelButton";
            DeleteLevelButton.Size = new Size(94, 41);
            DeleteLevelButton.TabIndex = 18;
            DeleteLevelButton.Text = "Удалить уровень";
            DeleteLevelButton.UseVisualStyleBackColor = false;
            DeleteLevelButton.Click += DeleteLevelButton_Click;
            // 
            // LevelAndBoxeLabel
            // 
            LevelAndBoxeLabel.AutoSize = true;
            LevelAndBoxeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevelAndBoxeLabel.Location = new Point(433, 19);
            LevelAndBoxeLabel.Name = "LevelAndBoxeLabel";
            LevelAndBoxeLabel.Size = new Size(84, 20);
            LevelAndBoxeLabel.TabIndex = 17;
            LevelAndBoxeLabel.Text = "| Уровень: ";
            // 
            // NextLevelPictureBox
            // 
            NextLevelPictureBox.BackColor = Color.Transparent;
            NextLevelPictureBox.Cursor = Cursors.Hand;
            NextLevelPictureBox.Image = Properties.Resources.ArrowRight;
            NextLevelPictureBox.Location = new Point(377, 4);
            NextLevelPictureBox.Name = "NextLevelPictureBox";
            NextLevelPictureBox.Size = new Size(50, 50);
            NextLevelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NextLevelPictureBox.TabIndex = 16;
            NextLevelPictureBox.TabStop = false;
            toolTip1.SetToolTip(NextLevelPictureBox, "Следующий уровень");
            NextLevelPictureBox.Click += NextLevelPictureBox_Click;
            // 
            // PrevLevelPictureBox
            // 
            PrevLevelPictureBox.BackColor = Color.Transparent;
            PrevLevelPictureBox.Cursor = Cursors.Hand;
            PrevLevelPictureBox.Image = Properties.Resources.ArrowLeft;
            PrevLevelPictureBox.Location = new Point(321, 4);
            PrevLevelPictureBox.Name = "PrevLevelPictureBox";
            PrevLevelPictureBox.Size = new Size(50, 50);
            PrevLevelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevLevelPictureBox.TabIndex = 15;
            PrevLevelPictureBox.TabStop = false;
            toolTip1.SetToolTip(PrevLevelPictureBox, "Предыдущий уровень");
            PrevLevelPictureBox.Click += PrevLevelPictureBox_Click;
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
            // InformationPictureBox
            // 
            InformationPictureBox.BackColor = Color.Transparent;
            InformationPictureBox.Cursor = Cursors.Hand;
            InformationPictureBox.Image = Properties.Resources.Info;
            InformationPictureBox.Location = new Point(833, 4);
            InformationPictureBox.Name = "InformationPictureBox";
            InformationPictureBox.Size = new Size(50, 50);
            InformationPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            InformationPictureBox.TabIndex = 6;
            InformationPictureBox.TabStop = false;
            toolTip1.SetToolTip(InformationPictureBox, "Информация");
            InformationPictureBox.Click += InformationPictureBox_Click;
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
            // SaveButton
            // 
            SaveButton.BackColor = Color.SkyBlue;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(733, 8);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 41);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = Color.SkyBlue;
            FlowLayoutPanel.Location = new Point(0, 58);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(944, 443);
            FlowLayoutPanel.TabIndex = 12;
            // 
            // ChangeLevelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(944, 501);
            Controls.Add(FlowLayoutPanel);
            Controls.Add(Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "ChangeLevelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sokoban";
            Resize += ChangeLevelForm_Resize;
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NextLevelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevLevelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BroomPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InformationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WallPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoxPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private PictureBox BroomPictureBox;
        private PictureBox InformationPictureBox;
        private PictureBox BackToMenuFormPictureBox;
        private PictureBox PersonPictureBox;
        private PictureBox MarkPictureBox;
        private PictureBox WallPictureBox;
        private PictureBox BoxPictureBox;
        private Button SaveButton;
        private FlowLayoutPanel FlowLayoutPanel;
        private PictureBox PrevLevelPictureBox;
        private PictureBox NextLevelPictureBox;
        private Label LevelAndBoxeLabel;
        private ToolTip toolTip1;
        private Button DeleteLevelButton;
    }
}