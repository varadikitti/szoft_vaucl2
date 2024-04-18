namespace mintaZh2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInSquareKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uriConverterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uriConverterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Megnyitás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Törlés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Szerkesztés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.areaInSquareKmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 276);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 150;
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            this.areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            this.areaInSquareKmDataGridViewTextBoxColumn.Width = 150;
            // 
            // countryDataBindingSource1
            // 
            this.countryDataBindingSource1.DataSource = typeof(mintaZh2.CountryData);
            // 
            // uriConverterBindingSource
            // 
            this.uriConverterBindingSource.DataSource = typeof(CsvHelper.TypeConversion.UriConverter);
            // 
            // countryDataBindingSource
            // 
            this.countryDataBindingSource.DataSource = typeof(mintaZh2.CountryData);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(371, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mentés";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Új";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uriConverterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource uriConverterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryDataBindingSource1;
        private System.Windows.Forms.BindingSource countryDataBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

