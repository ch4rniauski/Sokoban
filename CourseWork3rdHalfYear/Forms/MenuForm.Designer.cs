namespace CourseWork3rdHalfYear.Forms
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            buttonPlay = new Button();
            buttonLevelCreator = new Button();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPlay.AutoSize = true;
            buttonPlay.BackColor = Color.LightCoral;
            buttonPlay.Cursor = Cursors.Hand;
            buttonPlay.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlay.Location = new Point(422, 219);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(100, 47);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Играть";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonLevelCreator
            // 
            buttonLevelCreator.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLevelCreator.AutoSize = true;
            buttonLevelCreator.BackColor = Color.LightCoral;
            buttonLevelCreator.Cursor = Cursors.Hand;
            buttonLevelCreator.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLevelCreator.Location = new Point(393, 273);
            buttonLevelCreator.Name = "buttonLevelCreator";
            buttonLevelCreator.Size = new Size(159, 47);
            buttonLevelCreator.TabIndex = 1;
            buttonLevelCreator.Text = "Создание уровня";
            buttonLevelCreator.UseVisualStyleBackColor = false;
            buttonLevelCreator.Click += buttonLevelCreator_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 501);
            Controls.Add(buttonPlay);
            Controls.Add(buttonLevelCreator);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sokoban";
            Load += MenuForm_Load;
            Resize += MenuForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlay;
        private Button buttonLevelCreator;
    }
}
