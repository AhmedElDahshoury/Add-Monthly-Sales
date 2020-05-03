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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxYearFrom = new System.Windows.Forms.ListBox();
            this.listBoxMonthFrom = new System.Windows.Forms.ListBox();
            this.monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthDBDataSet = new Add_Monthly_Sales.MonthDBDataSet();
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
            this.monthTableAdapter = new Add_Monthly_Sales.MonthDBDataSetTableAdapters.MonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxYearFrom
            // 
            this.listBoxYearFrom.FormattingEnabled = true;
            this.listBoxYearFrom.ItemHeight = 24;
            this.listBoxYearFrom.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.listBoxYearFrom.Location = new System.Drawing.Point(314, 204);
            this.listBoxYearFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxYearFrom.Name = "listBoxYearFrom";
            this.listBoxYearFrom.Size = new System.Drawing.Size(164, 124);
            this.listBoxYearFrom.TabIndex = 0;
            // 
            // listBoxMonthFrom
            // 
            this.listBoxMonthFrom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.monthBindingSource, "Id", true));
            this.listBoxMonthFrom.DataSource = this.monthBindingSource;
            this.listBoxMonthFrom.DisplayMember = "name";
            this.listBoxMonthFrom.FormattingEnabled = true;
            this.listBoxMonthFrom.ItemHeight = 24;
            this.listBoxMonthFrom.Location = new System.Drawing.Point(487, 204);
            this.listBoxMonthFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxMonthFrom.Name = "listBoxMonthFrom";
            this.listBoxMonthFrom.Size = new System.Drawing.Size(164, 124);
            this.listBoxMonthFrom.TabIndex = 1;
            this.listBoxMonthFrom.ValueMember = "Id";
            // 
            // monthBindingSource
            // 
            this.monthBindingSource.DataMember = "Month";
            this.monthBindingSource.DataSource = this.monthDBDataSet;
            // 
            // monthDBDataSet
            // 
            this.monthDBDataSet.DataSetName = "MonthDBDataSet";
            this.monthDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelFrom.Location = new System.Drawing.Point(311, 170);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelFrom.Size = new System.Drawing.Size(318, 31);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:                                                   ";
            // 
            // listBoxMonthTo
            // 
            this.listBoxMonthTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.monthBindingSource, "Id", true));
            this.listBoxMonthTo.DataSource = this.monthBindingSource;
            this.listBoxMonthTo.DisplayMember = "name";
            this.listBoxMonthTo.FormattingEnabled = true;
            this.listBoxMonthTo.ItemHeight = 24;
            this.listBoxMonthTo.Location = new System.Drawing.Point(1006, 204);
            this.listBoxMonthTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxMonthTo.Name = "listBoxMonthTo";
            this.listBoxMonthTo.Size = new System.Drawing.Size(164, 124);
            this.listBoxMonthTo.TabIndex = 4;
            this.listBoxMonthTo.ValueMember = "Id";
            // 
            // listBoxYearTo
            // 
            this.listBoxYearTo.FormattingEnabled = true;
            this.listBoxYearTo.ItemHeight = 24;
            this.listBoxYearTo.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.listBoxYearTo.Location = new System.Drawing.Point(833, 204);
            this.listBoxYearTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxYearTo.Name = "listBoxYearTo";
            this.listBoxYearTo.Size = new System.Drawing.Size(164, 124);
            this.listBoxYearTo.TabIndex = 3;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Salmon;
            this.labelTo.Location = new System.Drawing.Point(835, 170);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labelTo.Size = new System.Drawing.Size(312, 31);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "To:                                                      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = ">>";
            // 
            // dataGridViewSold
            // 
            this.dataGridViewSold.AllowUserToAddRows = false;
            this.dataGridViewSold.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSold.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSold.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewSold.Location = new System.Drawing.Point(100, 493);
            this.dataGridViewSold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSold.Name = "dataGridViewSold";
            this.dataGridViewSold.ReadOnly = true;
            this.dataGridViewSold.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSold.RowHeadersWidth = 51;
            this.dataGridViewSold.RowTemplate.Height = 24;
            this.dataGridViewSold.Size = new System.Drawing.Size(1364, 514);
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
            this.button1.Location = new System.Drawing.Point(1317, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Monthly Sales >>";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(16, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 72);
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
            this.buttonShow.Location = new System.Drawing.Point(666, 374);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(136, 50);
            this.buttonShow.TabIndex = 11;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // monthTableAdapter
            // 
            this.monthTableAdapter.ClearBeforeFill = true;
            // 
            // ShowMonthlySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1573, 1020);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowMonthlySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Monthly Sales";
            this.Load += new System.EventHandler(this.ShowMonthlySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSold)).EndInit();
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