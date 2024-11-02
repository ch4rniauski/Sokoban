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
            panel1 = new Panel();
            pictureBoxRestart = new PictureBox();
            pictureBoxBackToMenuForm = new PictureBox();
            labelLevelAndBoxes = new Label();
            pictureBoxPrevLevel = new PictureBox();
            pictureBoxNextLevel = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRestart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMenuForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrevLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNextLevel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBoxRestart);
            panel1.Controls.Add(pictureBoxBackToMenuForm);
            panel1.Controls.Add(labelLevelAndBoxes);
            panel1.Controls.Add(pictureBoxPrevLevel);
            panel1.Controls.Add(pictureBoxNextLevel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 30);
            panel1.TabIndex = 0;
            panel1.Resize += panel1_Resize;
            // 
            // pictureBoxRestart
            // 
            pictureBoxRestart.BackColor = Color.Transparent;
            pictureBoxRestart.Cursor = Cursors.Hand;
            pictureBoxRestart.Image = Properties.Resources.Restart;
            pictureBoxRestart.Location = new Point(876, 1);
            pictureBoxRestart.Name = "pictureBoxRestart";
            pictureBoxRestart.Size = new Size(29, 27);
            pictureBoxRestart.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRestart.TabIndex = 4;
            pictureBoxRestart.TabStop = false;
            toolTip1.SetToolTip(pictureBoxRestart, "Начать уровень сначала");
            pictureBoxRestart.Click += pictureBoxRestart_Click;
            // 
            // pictureBoxBackToMenuForm
            // 
            pictureBoxBackToMenuForm.BackColor = Color.Transparent;
            pictureBoxBackToMenuForm.Cursor = Cursors.Hand;
            pictureBoxBackToMenuForm.Image = Properties.Resources.GoBack;
            pictureBoxBackToMenuForm.Location = new Point(912, 0);
            pictureBoxBackToMenuForm.Name = "pictureBoxBackToMenuForm";
            pictureBoxBackToMenuForm.Size = new Size(29, 28);
            pictureBoxBackToMenuForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackToMenuForm.TabIndex = 3;
            pictureBoxBackToMenuForm.TabStop = false;
            toolTip1.SetToolTip(pictureBoxBackToMenuForm, "Вернуться в главное меню");
            pictureBoxBackToMenuForm.Click += pictureBoxBackToMenuForm_Click;
            // 
            // labelLevelAndBoxes
            // 
            labelLevelAndBoxes.AutoSize = true;
            labelLevelAndBoxes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLevelAndBoxes.Location = new Point(71, 4);
            labelLevelAndBoxes.Name = "labelLevelAndBoxes";
            labelLevelAndBoxes.Size = new Size(84, 20);
            labelLevelAndBoxes.TabIndex = 2;
            labelLevelAndBoxes.Text = "| Уровень: ";
            // 
            // pictureBoxPrevLevel
            // 
            pictureBoxPrevLevel.BackColor = Color.Transparent;
            pictureBoxPrevLevel.Cursor = Cursors.Hand;
            pictureBoxPrevLevel.Image = Properties.Resources.ArrowLeft;
            pictureBoxPrevLevel.Location = new Point(3, 3);
            pictureBoxPrevLevel.Name = "pictureBoxPrevLevel";
            pictureBoxPrevLevel.Size = new Size(29, 24);
            pictureBoxPrevLevel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPrevLevel.TabIndex = 1;
            pictureBoxPrevLevel.TabStop = false;
            toolTip1.SetToolTip(pictureBoxPrevLevel, "Предыдущий уровень");
            pictureBoxPrevLevel.Click += pictureBoxPrevLevel_Click;
            // 
            // pictureBoxNextLevel
            // 
            pictureBoxNextLevel.BackColor = Color.Transparent;
            pictureBoxNextLevel.Cursor = Cursors.Hand;
            pictureBoxNextLevel.Image = Properties.Resources.ArrowRight;
            pictureBoxNextLevel.Location = new Point(38, 3);
            pictureBoxNextLevel.Name = "pictureBoxNextLevel";
            pictureBoxNextLevel.Size = new Size(29, 24);
            pictureBoxNextLevel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNextLevel.TabIndex = 0;
            pictureBoxNextLevel.TabStop = false;
            toolTip1.SetToolTip(pictureBoxNextLevel, "Следующий уровень");
            pictureBoxNextLevel.Click += pictureBoxNextLevel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(944, 471);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sokoban";
            Load += PlayForm_Load;
            KeyPress += PlayForm_KeyPress_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRestart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMenuForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrevLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNextLevel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxNextLevel;
        private PictureBox pictureBoxPrevLevel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelLevelAndBoxes;
        private ToolTip toolTip1;
        private PictureBox pictureBoxBackToMenuForm;
        private PictureBox pictureBoxRestart;
    }
}