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
            PlayButton = new Button();
            LevelCreatorButton = new Button();
            LevelChangerButton = new Button();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PlayButton.AutoSize = true;
            PlayButton.BackColor = Color.LightCoral;
            PlayButton.Cursor = Cursors.Hand;
            PlayButton.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlayButton.Location = new Point(320, 228);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(100, 47);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Играть";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // LevelCreatorButton
            // 
            LevelCreatorButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LevelCreatorButton.AutoSize = true;
            LevelCreatorButton.BackColor = Color.LightCoral;
            LevelCreatorButton.Cursor = Cursors.Hand;
            LevelCreatorButton.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevelCreatorButton.Location = new Point(463, 228);
            LevelCreatorButton.Name = "LevelCreatorButton";
            LevelCreatorButton.Size = new Size(159, 47);
            LevelCreatorButton.TabIndex = 1;
            LevelCreatorButton.Text = "Создание уровня";
            LevelCreatorButton.UseVisualStyleBackColor = false;
            LevelCreatorButton.Click += LevelCreatorButton_Click;
            // 
            // LevelChangerButton
            // 
            LevelChangerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LevelChangerButton.AutoSize = true;
            LevelChangerButton.BackColor = Color.LightCoral;
            LevelChangerButton.Cursor = Cursors.Hand;
            LevelChangerButton.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LevelChangerButton.Location = new Point(320, 278);
            LevelChangerButton.Name = "LevelChangerButton";
            LevelChangerButton.Size = new Size(302, 47);
            LevelChangerButton.TabIndex = 2;
            LevelChangerButton.Text = "Редактирование имеющегося уровня";
            LevelChangerButton.UseVisualStyleBackColor = false;
            LevelChangerButton.Click += LevelChangerButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 501);
            Controls.Add(LevelChangerButton);
            Controls.Add(PlayButton);
            Controls.Add(LevelCreatorButton);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sokoban";
            Resize += MenuForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayButton;
        private Button LevelCreatorButton;
        private Button LevelChangerButton;
    }
}
