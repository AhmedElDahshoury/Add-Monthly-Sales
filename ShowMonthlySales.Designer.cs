namespace Add_Monthly_Sales
{
    partial class ShowMonthlySales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxYearFrom = new System.Windows.Forms.ListBox();
            this.listBoxMonthFrom = new System.Windows.Forms.ListBox();
            this.productSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDBDataSet = new Add_Monthly_Sales.CoffeeDBDataSet();
            this.labelFrom = new System.Windows.Forms.Label();
            this.listBoxMonthTo = new System.Windows.Forms.ListBox();
            this.listBoxYearTo = new System.Windows.Forms.ListBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSold = new System.Windows.Forms.DataGridView();
            this.product_SoldTableAdapter = new Add_Monthly_Sales.CoffeeDBDataSetTableAdapters.Product_SoldTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.monthDBDataSet = new Add_Monthly_Sales.MonthDBDataSet();
            this.monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthTableAdapter = new Add_Monthly_Sales.MonthDBDataSetTableAdapters.MonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxYearFrom
            // 
            this.listBoxYearFrom.FormattingEnabled = true;
            this.listBoxYearFrom.ItemHeight = 16;
            this.listBoxYearFrom.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.listBoxYearFrom.Location = new System.Drawing.Point(228, 136);
            this.listBoxYearFrom.Name = "listBoxYearFrom";
            this.listBoxYearFrom.Size = new System.Drawing.Size(120, 84);
            this.listBoxYearFrom.TabIndex = 0;
            // 
            // listBoxMonthFrom
            // 
            this.listBoxMonthFrom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.monthBindingSource, "Id", true));
            this.listBoxMonthFrom.DataSource = this.monthBindingSource;
            this.listBoxMonthFrom.DisplayMember = "name";
            this.listBoxMonthFrom.FormattingEnabled = true;
            this.listBoxMonthFrom.ItemHeight = 16;
            this.listBoxMonthFrom.Location = new System.Drawing.Point(354, 136);
            this.listBoxMonthFrom.Name = "listBoxMonthFrom";
            this.listBoxMonthFrom.Size = new System.Drawing.Size(120, 84);
            this.listBoxMonthFrom.TabIndex = 1;
            this.listBoxMonthFrom.ValueMember = "Id";
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
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Salmon;
            this.labelFrom.Location = new System.Drawing.Point(226, 113);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.labelFrom.Size = new System.Drawing.Size(248, 21);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:                                                   ";
            // 
            // listBoxMonthTo
            // 
            this.listBoxMonthTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.monthBindingSource, "Id", true));
            this.listBoxMonthTo.DataSource = this.monthBindingSource;
            this.listBoxMonthTo.DisplayMember = "name";
            this.listBoxMonthTo.FormattingEnabled = true;
            this.listBoxMonthTo.ItemHeight = 16;
            this.listBoxMonthTo.Location = new System.Drawing.Point(732, 136);
            this.listBoxMonthTo.Name = "listBoxMonthTo";
            this.listBoxMonthTo.Size = new System.Drawing.Size(120, 84);
            this.listBoxMonthTo.TabIndex = 4;
            this.listBoxMonthTo.ValueMember = "Id";
            // 
            // listBoxYearTo
            // 
            this.listBoxYearTo.FormattingEnabled = true;
            this.listBoxYearTo.ItemHeight = 16;
            this.listBoxYearTo.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.listBoxYearTo.Location = new System.Drawing.Point(606, 136);
            this.listBoxYearTo.Name = "listBoxYearTo";
            this.listBoxYearTo.Size = new System.Drawing.Size(120, 84);
            this.listBoxYearTo.TabIndex = 3;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Salmon;
            this.labelTo.Location = new System.Drawing.Point(607, 113);
            this.labelTo.Name = "labelTo";
            this.labelTo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.labelTo.Size = new System.Drawing.Size(245, 21);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To:                                                      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = ">>";
            // 
            // dataGridViewSold
            // 
            this.dataGridViewSold.AllowUserToAddRows = false;
            this.dataGridViewSold.AllowUserToDeleteRows = false;
            this.dataGridViewSold.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewSold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSold.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewSold.Location = new System.Drawing.Point(59, 308);
            this.dataGridViewSold.Name = "dataGridViewSold";
            this.dataGridViewSold.ReadOnly = true;
            this.dataGridViewSold.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSold.RowHeadersWidth = 51;
            this.dataGridViewSold.RowTemplate.Height = 24;
            this.dataGridViewSold.Size = new System.Drawing.Size(992, 360);
            this.dataGridViewSold.TabIndex = 8;
            // 
            // product_SoldTableAdapter
            // 
            this.product_SoldTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(958, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Monthly Sales >>";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "<< Back to Main";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.Location = new System.Drawing.Point(483, 281);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(99, 33);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // monthDBDataSet
            // 
            this.monthDBDataSet.DataSetName = "MonthDBDataSet";
            this.monthDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthBindingSource
            // 
            this.monthBindingSource.DataMember = "Month";
            this.monthBindingSource.DataSource = this.monthDBDataSet;
            // 
            // monthTableAdapter
            // 
            this.monthTableAdapter.ClearBeforeFill = true;
            // 
            // ShowMonthlySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1144, 680);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.listBoxMonthTo);
            this.Controls.Add(this.listBoxYearTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.listBoxMonthFrom);
            this.Controls.Add(this.listBoxYearFrom);
            this.Name = "ShowMonthlySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Monthly Sales";
            this.Load += new System.EventHandler(this.ShowMonthlySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYearFrom;
        private System.Windows.Forms.ListBox listBoxMonthFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ListBox listBoxMonthTo;
        private System.Windows.Forms.ListBox listBoxYearTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label2;
        private CoffeeDBDataSet coffeeDBDataSet;
        private System.Windows.Forms.DataGridView dataGridViewSold;
        private System.Windows.Forms.BindingSource productSoldBindingSource;
        private CoffeeDBDataSetTableAdapters.Product_SoldTableAdapter product_SoldTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonShow;
        private MonthDBDataSet monthDBDataSet;
        private System.Windows.Forms.BindingSource monthBindingSource;
        private MonthDBDataSetTableAdapters.MonthTableAdapter monthTableAdapter;
    }
}