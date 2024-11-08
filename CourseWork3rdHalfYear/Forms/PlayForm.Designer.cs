namespace CourseWork3rdHalfYear.Forms
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            Panel = new Panel();
            RestartPictureBox = new PictureBox();
            BackToMenuFormPictureBox = new PictureBox();
            LevelAndBoxeLabel = new Label();
            PrevLevelPictureBox = new PictureBox();
            NextLevelPictureBox = new PictureBox();
            FlowLayoutPanel = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RestartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevLevelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextLevelPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveCaption;
            Panel.Controls.Add(RestartPictureBox);
            Panel.Controls.Add(BackToMenuFormPictureBox);
            Panel.Controls.Add(LevelAndBoxeLabel);
            Panel.Controls.Add(PrevLevelPictureBox);
            Panel.Controls.Add(NextLevelPictureBox);
            Panel.Dock = DockStyle.Top;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(944, 30);
            Panel.TabIndex = 0;
            // 
            // RestartPictureBox
            // 
            RestartPictureBox.BackColor = Color.Transparent;
            RestartPictureBox.Cursor = Cursors.Hand;
            RestartPictureBox.Image = Properties.Resources.Restart;
            RestartPictureBox.Location = new Point(876, 2);
            RestartPictureBox.Name = "RestartPictureBox";
            RestartPictureBox.Size = new Size(29, 27);
            RestartPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RestartPictureBox.TabIndex = 4;
            RestartPictureBox.TabStop = false;
            toolTip1.SetToolTip(RestartPictureBox, "Начать уровень сначала");
            RestartPictureBox.Click += RestartPictureBox_Click;
            // 
            // BackToMenuFormPictureBox
            // 
            BackToMenuFormPictureBox.BackColor = Color.Transparent;
            BackToMenuFormPictureBox.Cursor = Cursors.Hand;
            BackToMenuFormPictureBox.Image = Properties.Resources.GoBack;
            BackToMenuFormPictureBox.Location = new Point(912, 1);
            BackToMenuFormPictureBox.Name = "BackToMenuFormPictureBox";
            BackToMenuFormPictureBox.Size = new Size(29, 28);
            BackToMenuFormPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BackToMenuFormPictureBox.TabIndex = 3;
            BackToMenuFormPictureBox.TabStop = false;
            toolTip1.SetToolTip(BackToMenuFormPictureBox, "Вернуться в главное меню");
            BackToMenuFormPictureBox.Click += BackToMenuFormPictureBox_Click;
            // 
            // LevelAndBoxeLabel
            // 
            LevelAndBoxeLabel.AutoSize = true;
            LevelAndBoxeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevelAndBoxeLabel.Location = new Point(430, 5);
            LevelAndBoxeLabel.Name = "LevelAndBoxeLabel";
            LevelAndBoxeLabel.Size = new Size(84, 20);
            LevelAndBoxeLabel.TabIndex = 2;
            LevelAndBoxeLabel.Text = "| Уровень: ";
            // 
            // PrevLevelPictureBox
            // 
            PrevLevelPictureBox.BackColor = Color.Transparent;
            PrevLevelPictureBox.Cursor = Cursors.Hand;
            PrevLevelPictureBox.Image = Properties.Resources.ArrowLeft;
            PrevLevelPictureBox.Location = new Point(3, 3);
            PrevLevelPictureBox.Name = "PrevLevelPictureBox";
            PrevLevelPictureBox.Size = new Size(29, 24);
            PrevLevelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevLevelPictureBox.TabIndex = 1;
            PrevLevelPictureBox.TabStop = false;
            toolTip1.SetToolTip(PrevLevelPictureBox, "Предыдущий уровень");
            PrevLevelPictureBox.Click += PrevLevelPictureBox_Click;
            // 
            // NextLevelPictureBox
            // 
            NextLevelPictureBox.BackColor = Color.Transparent;
            NextLevelPictureBox.Cursor = Cursors.Hand;
            NextLevelPictureBox.Image = Properties.Resources.ArrowRight;
            NextLevelPictureBox.Location = new Point(38, 3);
            NextLevelPictureBox.Name = "NextLevelPictureBox";
            NextLevelPictureBox.Size = new Size(29, 24);
            NextLevelPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NextLevelPictureBox.TabIndex = 0;
            NextLevelPictureBox.TabStop = false;
            toolTip1.SetToolTip(NextLevelPictureBox, "Следующий уровень");
            NextLevelPictureBox.Click += NextLevelPictureBox_Click;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.Location = new Point(0, 30);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(944, 471);
            FlowLayoutPanel.TabIndex = 1;
            // 
            // PlayForm
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
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sokoban";
            KeyDown += PlayForm_KeyDown;
            Resize += PlayForm_Resize;
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RestartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackToMenuFormPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevLevelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextLevelPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private PictureBox NextLevelPictureBox;
        private PictureBox PrevLevelPictureBox;
        private FlowLayoutPanel FlowLayoutPanel;
        private Label LevelAndBoxeLabel;
        private ToolTip toolTip1;
        private PictureBox BackToMenuFormPictureBox;
        private PictureBox RestartPictureBox;
    }
}