namespace HajosTeszt
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
            dataGridView1.Location = new Point(0, 500);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1143, 250);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // válaszGomb1
            // 
            válaszGomb1.BackColor = Color.Gray;
            válaszGomb1.BorderStyle = BorderStyle.None;
            válaszGomb1.Location = new Point(20, 53);
            válaszGomb1.Margin = new Padding(4, 5, 4, 5);
            válaszGomb1.Multiline = true;
            válaszGomb1.Name = "válaszGomb1";
            válaszGomb1.ReadOnly = true;
            válaszGomb1.Size = new Size(260, 127);
            válaszGomb1.TabIndex = 2;
            válaszGomb1.Click += válaszGomb1_Click;
            // 
            // válaszGomb2
            // 
            válaszGomb2.BackColor = Color.Gray;
            válaszGomb2.BorderStyle = BorderStyle.None;
            válaszGomb2.Location = new Point(20, 190);
            válaszGomb2.Margin = new Padding(4, 5, 4, 5);
            válaszGomb2.Multiline = true;
            válaszGomb2.Name = "válaszGomb2";
            válaszGomb2.ReadOnly = true;
            válaszGomb2.Size = new Size(260, 127);
            válaszGomb2.TabIndex = 3;
            válaszGomb2.Click += válaszGomb2_Click;
            // 
            // válaszGomb3
            // 
            válaszGomb3.BackColor = Color.Gray;
            válaszGomb3.BorderStyle = BorderStyle.None;
            válaszGomb3.Location = new Point(20, 327);
            válaszGomb3.Margin = new Padding(4, 5, 4, 5);
            válaszGomb3.Multiline = true;
            válaszGomb3.Name = "válaszGomb3";
            válaszGomb3.ReadOnly = true;
            válaszGomb3.Size = new Size(260, 127);
            válaszGomb3.TabIndex = 4;
            válaszGomb3.Click += válaszGomb3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(364, 53);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 400);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // következő1
            // 
            következő1.BackColor = Color.Yellow;
            következő1.Location = new Point(949, 190);
            következő1.Margin = new Padding(4, 5, 4, 5);
            következő1.Name = "következő1";
            következő1.Size = new Size(143, 127);
            következő1.TabIndex = 6;
            következő1.Text = "következő1";
            következő1.UseVisualStyleBackColor = false;
            következő1.Click += következő1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(következő1);
            Controls.Add(pictureBox1);
            Controls.Add(válaszGomb3);
            Controls.Add(válaszGomb2);
            Controls.Add(válaszGomb1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
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