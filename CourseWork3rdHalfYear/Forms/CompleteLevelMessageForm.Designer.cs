namespace CourseWork3rdHalfYear.Forms
{
    partial class CompleteLevelMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteLevelMessageForm));
            label1 = new Label();
            BackToMainMenuButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 114);
            label1.Name = "label1";
            label1.Size = new Size(372, 28);
            label1.TabIndex = 0;
            label1.Text = "Поздравляем! Вы прошли уровень";
            // 
            // BackToMainMenuButton
            // 
            BackToMainMenuButton.BackColor = Color.Cyan;
            BackToMainMenuButton.Cursor = Cursors.Hand;
            BackToMainMenuButton.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToMainMenuButton.Location = new Point(201, 396);
            BackToMainMenuButton.Name = "BackToMainMenuButton";
            BackToMainMenuButton.Size = new Size(122, 50);
            BackToMainMenuButton.TabIndex = 1;
            BackToMainMenuButton.Text = "Вернуться в главное меню";
            BackToMainMenuButton.UseVisualStyleBackColor = false;
            BackToMainMenuButton.Click += BackToMainMenuButton_Click;
            // 
            // CompleteLevelMessageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CompletedLevelBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(524, 501);
            Controls.Add(BackToMainMenuButton);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(540, 540);
            MinimumSize = new Size(540, 540);
            Name = "CompleteLevelMessageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Completed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackToMainMenuButton;
    }
}