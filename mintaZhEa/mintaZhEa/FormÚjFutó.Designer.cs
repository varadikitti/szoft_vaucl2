namespace mintaZhEa
{
    partial class FormÚjFutó
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(676, 257);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(546, 257);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(34, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Futók);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox2.Location = new Point(34, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(34, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox4.Location = new Point(34, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox5.Location = new Point(34, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 75);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 3;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 130);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 3;
            label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 3;
            label4.Text = "Idő";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 232);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 3;
            label6.Text = "Kategória";
            // 
            // FormÚjFutó
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormÚjFutó";
            Text = "FormÚjFutó";
            Load += FormÚjFutó_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private BindingSource bindingSource1;
    }
}