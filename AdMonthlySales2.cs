using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Monthly_Sales
{
    public partial class AdMonthlySales2 : Form
    {
        public AdMonthlySales2()
        {
            InitializeComponent();
        }

        private void product_SoldBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_SoldBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDBDataSet);

        }

        private void product_SoldBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.product_SoldBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDBDataSet);

        }

        private void product_SoldBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.product_SoldBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDBDataSet);

        }

        private void AdMonthlySales2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDBDataSet.Product_Sold' table. You can move, or remove it, as needed.
            this.product_SoldTableAdapter.Fill(this.coffeeDBDataSet.Product_Sold);

        }
    }
}
