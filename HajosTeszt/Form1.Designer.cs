﻿namespace HajosTeszt
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            válaszGomb1 = new VálaszGomb();
            válaszGomb2 = new VálaszGomb();
            válaszGomb3 = new VálaszGomb();
            pictureBox1 = new PictureBox();
            következő1 = new Következő();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // válaszGomb1
            // 
            válaszGomb1.BackColor = Color.Gray;
            válaszGomb1.BorderStyle = BorderStyle.None;
            válaszGomb1.Location = new Point(14, 32);
            válaszGomb1.Multiline = true;
            válaszGomb1.Name = "válaszGomb1";
            válaszGomb1.ReadOnly = true;
            válaszGomb1.Size = new Size(182, 76);
            válaszGomb1.TabIndex = 2;
            // 
            // válaszGomb2
            // 
            válaszGomb2.BackColor = Color.Gray;
            válaszGomb2.BorderStyle = BorderStyle.None;
            válaszGomb2.Location = new Point(14, 114);
            válaszGomb2.Multiline = true;
            válaszGomb2.Name = "válaszGomb2";
            válaszGomb2.ReadOnly = true;
            válaszGomb2.Size = new Size(182, 76);
            válaszGomb2.TabIndex = 3;
            // 
            // válaszGomb3
            // 
            válaszGomb3.BackColor = Color.Gray;
            válaszGomb3.BorderStyle = BorderStyle.None;
            válaszGomb3.Location = new Point(14, 196);
            válaszGomb3.Multiline = true;
            válaszGomb3.Name = "válaszGomb3";
            válaszGomb3.ReadOnly = true;
            válaszGomb3.Size = new Size(182, 76);
            válaszGomb3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(255, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 240);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // következő1
            // 
            következő1.BackColor = Color.Yellow;
            következő1.Location = new Point(664, 114);
            következő1.Name = "következő1";
            következő1.Size = new Size(100, 76);
            következő1.TabIndex = 6;
            következő1.Text = "következő1";
            következő1.UseVisualStyleBackColor = false;
            következő1.Click += következő1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(következő1);
            Controls.Add(pictureBox1);
            Controls.Add(válaszGomb3);
            Controls.Add(válaszGomb2);
            Controls.Add(válaszGomb1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private VálaszGomb válaszGomb1;
        private VálaszGomb válaszGomb2;
        private VálaszGomb válaszGomb3;
        private PictureBox pictureBox1;
        private Következő következő1;
    }
}