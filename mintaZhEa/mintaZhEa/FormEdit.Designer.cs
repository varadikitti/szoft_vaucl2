﻿namespace mintaZhEa
{
    partial class FormEdit
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(665, 402);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Sorszám";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(555, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Kérdés";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(555, 31);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 1;
            label3.Text = "1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(607, 31);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 1;
            label4.Text = "2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(607, 31);
            textBox4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 327);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 1;
            label5.Text = "3";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 327);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(607, 31);
            textBox5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 404);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 1;
            label6.Text = "Helyes válasz";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(134, 404);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(513, 31);
            textBox6.TabIndex = 2;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormEdit";
            Text = "FormEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
    }
}