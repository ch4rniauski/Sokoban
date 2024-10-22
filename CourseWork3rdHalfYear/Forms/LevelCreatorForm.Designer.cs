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
            pictureBoxBox = new PictureBox();
            pictureBoxWall = new PictureBox();
            pictureBoxMark = new PictureBox();
            pictureBoxPerson = new PictureBox();
            toolTip1 = new ToolTip(components);
            pictureBoxBackToMenuForm = new PictureBox();
            pictureBoxInformation = new PictureBox();
            buttonStartOrSave = new Button();
            labelMapDimension = new Label();
            textBoxRows = new TextBox();
            textBoxColums = new TextBox();
            labelColums = new Label();
            labelRows = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMenuForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInformation).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxBox
            // 
            pictureBoxBox.Cursor = Cursors.Hand;
            pictureBoxBox.Image = Properties.Resources.Box;
            pictureBoxBox.Location = new Point(0, 4);
            pictureBoxBox.Name = "pictureBoxBox";
            pictureBoxBox.Size = new Size(50, 50);
            pictureBoxBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBox.TabIndex = 0;
            pictureBoxBox.TabStop = false;
            toolTip1.SetToolTip(pictureBoxBox, "Ящик");
            pictureBoxBox.Click += pictureBoxBox_Click;
            // 
            // pictureBoxWall
            // 
            pictureBoxWall.Cursor = Cursors.Hand;
            pictureBoxWall.Image = Properties.Resources.StoneBlock;
            pictureBoxWall.Location = new Point(56, 4);
            pictureBoxWall.Name = "pictureBoxWall";
            pictureBoxWall.Size = new Size(50, 50);
            pictureBoxWall.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWall.TabIndex = 1;
            pictureBoxWall.TabStop = false;
            toolTip1.SetToolTip(pictureBoxWall, "Стена");
            pictureBoxWall.Click += pictureBoxWall_Click;
            // 
            // pictureBoxMark
            // 
            pictureBoxMark.BackColor = SystemColors.ActiveCaption;
            pictureBoxMark.Cursor = Cursors.Hand;
            pictureBoxMark.Image = Properties.Resources.RedCross;
            pictureBoxMark.Location = new Point(112, 4);
            pictureBoxMark.Name = "pictureBoxMark";
            pictureBoxMark.Size = new Size(50, 50);
            pictureBoxMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMark.TabIndex = 2;
            pictureBoxMark.TabStop = false;
            toolTip1.SetToolTip(pictureBoxMark, "Метка");
            pictureBoxMark.Click += pictureBoxMark_Click;
            // 
            // pictureBoxPerson
            // 
            pictureBoxPerson.BackColor = SystemColors.ActiveCaption;
            pictureBoxPerson.Cursor = Cursors.Hand;
            pictureBoxPerson.Image = Properties.Resources.Person;
            pictureBoxPerson.Location = new Point(168, 4);
            pictureBoxPerson.Name = "pictureBoxPerson";
            pictureBoxPerson.Size = new Size(50, 50);
            pictureBoxPerson.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerson.TabIndex = 4;
            pictureBoxPerson.TabStop = false;
            toolTip1.SetToolTip(pictureBoxPerson, "Персонаж");
            pictureBoxPerson.Click += pictureBoxPerson_Click;
            // 
            // pictureBoxBackToMenuForm
            // 
            pictureBoxBackToMenuForm.BackColor = SystemColors.ActiveCaption;
            pictureBoxBackToMenuForm.Cursor = Cursors.Hand;
            pictureBoxBackToMenuForm.Image = Properties.Resources.GoBack;
            pictureBoxBackToMenuForm.Location = new Point(889, 4);
            pictureBoxBackToMenuForm.Name = "pictureBoxBackToMenuForm";
            pictureBoxBackToMenuForm.Size = new Size(50, 50);
            pictureBoxBackToMenuForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackToMenuForm.TabIndex = 5;
            pictureBoxBackToMenuForm.TabStop = false;
            toolTip1.SetToolTip(pictureBoxBackToMenuForm, "Вернуться в главное меню");
            pictureBoxBackToMenuForm.Click += pictureBoxBackToMenuForm_Click;
            // 
            // pictureBoxInformation
            // 
            pictureBoxInformation.BackColor = SystemColors.ActiveCaption;
            pictureBoxInformation.Cursor = Cursors.Hand;
            pictureBoxInformation.Image = Properties.Resources.Info;
            pictureBoxInformation.Location = new Point(820, 4);
            pictureBoxInformation.Name = "pictureBoxInformation";
            pictureBoxInformation.Size = new Size(50, 50);
            pictureBoxInformation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInformation.TabIndex = 6;
            pictureBoxInformation.TabStop = false;
            toolTip1.SetToolTip(pictureBoxInformation, "Информация");
            pictureBoxInformation.Click += pictureBoxInformation_Click;
            // 
            // buttonStartOrSave
            // 
            buttonStartOrSave.Cursor = Cursors.Hand;
            buttonStartOrSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStartOrSave.Location = new Point(720, 8);
            buttonStartOrSave.Name = "buttonStartOrSave";
            buttonStartOrSave.Size = new Size(94, 41);
            buttonStartOrSave.TabIndex = 13;
            buttonStartOrSave.Text = "Начать";
            buttonStartOrSave.UseVisualStyleBackColor = true;
            buttonStartOrSave.Click += buttonStartOrSave_Click;
            // 
            // labelMapDimension
            // 
            labelMapDimension.AutoSize = true;
            labelMapDimension.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMapDimension.Location = new Point(440, 20);
            labelMapDimension.Name = "labelMapDimension";
            labelMapDimension.Size = new Size(147, 20);
            labelMapDimension.TabIndex = 2;
            labelMapDimension.Text = "Размерность карты:";
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(671, 20);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(35, 23);
            textBoxRows.TabIndex = 10;
            // 
            // textBoxColums
            // 
            textBoxColums.Location = new Point(603, 20);
            textBoxColums.Name = "textBoxColums";
            textBoxColums.Size = new Size(35, 23);
            textBoxColums.TabIndex = 9;
            // 
            // labelColums
            // 
            labelColums.AutoSize = true;
            labelColums.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelColums.Location = new Point(588, 0);
            labelColums.Name = "labelColums";
            labelColums.Size = new Size(66, 17);
            labelColums.TabIndex = 12;
            labelColums.Text = "Столбцов";
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRows.Location = new Point(666, 0);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(44, 17);
            labelRows.TabIndex = 11;
            labelRows.Text = "Рядов";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelRows);
            panel1.Controls.Add(pictureBoxInformation);
            panel1.Controls.Add(textBoxColums);
            panel1.Controls.Add(pictureBoxBackToMenuForm);
            panel1.Controls.Add(labelColums);
            panel1.Controls.Add(pictureBoxPerson);
            panel1.Controls.Add(pictureBoxMark);
            panel1.Controls.Add(pictureBoxWall);
            panel1.Controls.Add(labelMapDimension);
            panel1.Controls.Add(pictureBoxBox);
            panel1.Controls.Add(buttonStartOrSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 58);
            panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(944, 443);
            flowLayoutPanel1.TabIndex = 11;
            flowLayoutPanel1.Resize += flowLayoutPanel1_Resize;
            // 
            // LevelCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBoxRows);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "LevelCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Creator";
            Load += LevelCreatorForm_Load;
            Resize += LevelCreatorForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMark).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackToMenuForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInformation).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBox;
        private PictureBox pictureBoxWall;
        private PictureBox pictureBoxMark;
        private PictureBox pictureBoxPerson;
        private ToolTip toolTip1;
        private PictureBox pictureBoxBackToMenuForm;
        private PictureBox pictureBoxInformation;
        private Button buttonStartOrSave;
        private Label labelMapDimension;
        private TextBox textBoxRows;
        private TextBox textBoxColums;
        private Label labelColums;
        private Label labelRows;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}