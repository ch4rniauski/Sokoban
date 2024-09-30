﻿namespace CourseWork3rdHalfYear.Forms
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            toolTip1 = new ToolTip(components);
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Box;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Ящик");
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.StoneBlock;
            pictureBox2.Location = new Point(59, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, "Стена");
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.RedCross;
            pictureBox3.Location = new Point(115, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            toolTip1.SetToolTip(pictureBox3, "Метка");
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.Person;
            pictureBox4.Location = new Point(171, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            toolTip1.SetToolTip(pictureBox4, "Персонаж");
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.GoBack;
            pictureBox5.Location = new Point(892, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            toolTip1.SetToolTip(pictureBox5, "Вернуться в меню");
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaption;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.Info;
            pictureBox6.Location = new Point(823, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            toolTip1.SetToolTip(pictureBox6, "Информация");
            pictureBox6.Click += pictureBox6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(939, 439);
            dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 53);
            panel1.TabIndex = 8;
            // 
            // LevelCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "LevelCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Creator";
            Load += LevelCreatorForm_Load;
            Resize += LevelCreatorForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ToolTip toolTip1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}