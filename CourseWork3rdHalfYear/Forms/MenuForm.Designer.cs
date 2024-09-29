namespace CourseWork3rdHalfYear
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.LightCoral;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(422, 219);
            button1.Name = "button1";
            button1.Size = new Size(100, 47);
            button1.TabIndex = 0;
            button1.Text = "Играть";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.LightCoral;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(393, 273);
            button2.Name = "button2";
            button2.Size = new Size(159, 47);
            button2.TabIndex = 1;
            button2.Text = "Создание уровня";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 501);
            Controls.Add(button1);
            Controls.Add(button2);
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

        private Button button1;
        private Button button2;
    }
}
