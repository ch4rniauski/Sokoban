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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            panel1 = new Panel();
            labelLevelNumber = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxNextLevel = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNextLevel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(labelLevelNumber);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxNextLevel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 30);
            panel1.TabIndex = 0;
            // 
            // labelLevelNumber
            // 
            labelLevelNumber.AutoSize = true;
            labelLevelNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLevelNumber.Location = new Point(71, 4);
            labelLevelNumber.Name = "labelLevelNumber";
            labelLevelNumber.Size = new Size(84, 20);
            labelLevelNumber.TabIndex = 2;
            labelLevelNumber.Text = "| Уровень: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.ArrowLeft;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(944, 471);
            flowLayoutPanel1.TabIndex = 1;
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
            Text = "PlayForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNextLevel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxNextLevel;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelLevelNumber;
    }
}