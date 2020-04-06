namespace Add_Monthly_Sales
{
    partial class AddMonthlySales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSold = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDBDataSet = new Add_Monthly_Sales.CoffeeDBDataSet();
            this.product_SoldTableAdapter = new Add_Monthly_Sales.CoffeeDBDataSetTableAdapters.Product_SoldTableAdapter();
            this.LabelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.productTableAdapter = new Add_Monthly_Sales.CoffeeDBDataSetTableAdapters.ProductTableAdapter();
            this.fKProductSoldProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductSoldProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSold
            // 
            this.dataGridViewSold.AllowUserToAddRows = false;
            this.dataGridViewSold.AllowUserToDeleteRows = false;
            this.dataGridViewSold.AutoGenerateColumns = false;
            this.dataGridViewSold.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.pCostDataGridViewTextBoxColumn});
            this.dataGridViewSold.DataSource = this.productSoldBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSold.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewSold.Location = new System.Drawing.Point(72, 276);
            this.dataGridViewSold.Name = "dataGridViewSold";
            this.dataGridViewSold.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSold.RowHeadersWidth = 51;
            this.dataGridViewSold.RowTemplate.Height = 24;
            this.dataGridViewSold.Size = new System.Drawing.Size(992, 360);
            this.dataGridViewSold.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            this.pIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // pCostDataGridViewTextBoxColumn
            // 
            this.pCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pCostDataGridViewTextBoxColumn.DataPropertyName = "P_Cost";
            this.pCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.pCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pCostDataGridViewTextBoxColumn.Name = "pCostDataGridViewTextBoxColumn";
            // 
            // productSoldBindingSource
            // 
            this.productSoldBindingSource.DataMember = "Product_Sold";
            this.productSoldBindingSource.DataSource = this.coffeeDBDataSet;
            // 
            // coffeeDBDataSet
            // 
            this.coffeeDBDataSet.DataSetName = "CoffeeDBDataSet";
            this.coffeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_SoldTableAdapter
            // 
            this.product_SoldTableAdapter.ClearBeforeFill = true;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.IndianRed;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(410, 65);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(6, 3, 16, 4);
            this.LabelName.Size = new System.Drawing.Size(134, 25);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Product Name: ";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.IndianRed;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(410, 97);
            this.labelYear.Name = "labelYear";
            this.labelYear.Padding = new System.Windows.Forms.Padding(6, 3, 16, 4);
            this.labelYear.Size = new System.Drawing.Size(136, 25);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year sold:          ";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.IndianRed;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.ForeColor = System.Drawing.Color.White;
            this.labelMonth.Location = new System.Drawing.Point(410, 127);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Padding = new System.Windows.Forms.Padding(6, 3, 16, 4);
            this.labelMonth.Size = new System.Drawing.Size(136, 25);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "Month sold:       ";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.IndianRed;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(410, 156);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(6, 3, 16, 4);
            this.labelAmount.Size = new System.Drawing.Size(137, 25);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount sold:     ";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.coffeeDBDataSet;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.AllowDrop = true;
            this.comboBoxProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxProduct.DataSource = this.productBindingSource;
            this.comboBoxProduct.DisplayMember = "Name";
            this.comboBoxProduct.Location = new System.Drawing.Point(563, 66);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(186, 24);
            this.comboBoxProduct.TabIndex = 1;
            this.comboBoxProduct.ValueMember = "Product_ID";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.AllowDrop = true;
            this.comboBoxYear.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.comboBoxYear.Location = new System.Drawing.Point(563, 96);
            this.comboBoxYear.MaxDropDownItems = 5;
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(186, 24);
            this.comboBoxYear.TabIndex = 2;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.AllowDrop = true;
            this.comboBoxMonth.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Seb",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxMonth.Location = new System.Drawing.Point(563, 126);
            this.comboBoxMonth.MaxDropDownItems = 5;
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(186, 24);
            this.comboBoxMonth.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.Location = new System.Drawing.Point(413, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.Location = new System.Drawing.Point(650, 217);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 33);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // fKProductSoldProductBindingSource
            // 
            this.fKProductSoldProductBindingSource.DataMember = "FK_Product_Sold_Product";
            this.fKProductSoldProductBindingSource.DataSource = this.productBindingSource;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.AllowDrop = true;
            this.numericUpDownAmount.BackColor = System.Drawing.SystemColors.Menu;
            this.numericUpDownAmount.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productSoldBindingSource, "Amount", true));
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(564, 156);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(186, 22);
            this.numericUpDownAmount.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(958, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Monthly Sales >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "<< Back to Main";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AddMonthlySales
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CancelButton = this.buttonSave;
            this.ClientSize = new System.Drawing.Size(1144, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.dataGridViewSold);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "AddMonthlySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Monthly Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductSoldProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSold;
        private CoffeeDBDataSet coffeeDBDataSet;
        private System.Windows.Forms.BindingSource productSoldBindingSource;
        private CoffeeDBDataSetTableAdapters.Product_SoldTableAdapter product_SoldTableAdapter;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CoffeeDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource fKProductSoldProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

