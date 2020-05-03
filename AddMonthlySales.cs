using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Add_Monthly_Sales
{
    public partial class AddMonthlySales : Form
    {
        public AddMonthlySales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.coffeeDBDataSet.Product);
            // TODO: This line of code loads data into the 'coffeeDBDataSet.Product_Sold' table. You can move, or remove it, as needed.
            this.product_SoldTableAdapter.Fill(this.coffeeDBDataSet.Product_Sold);
            comboBoxYear.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-C9RSMTE;Initial Catalog=CoffeeDB;Integrated Security=True"; ;
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command;
            string sql;

            //try
           // {
                int selected_product_index = comboBoxProduct.SelectedIndex;

                int p_id = (int)comboBoxProduct.SelectedValue;
                string p_name = coffeeDBDataSet.Product.Rows[selected_product_index].ItemArray[1].ToString();
                string p_year = comboBoxYear.SelectedItem.ToString();
                string p_month = comboBoxMonth.SelectedItem.ToString();
                float p_amount = (float)numericUpDownAmount.Value;

                int price = (int)coffeeDBDataSet.Product.Rows[selected_product_index].ItemArray[3];
                float total_cost = p_amount * price;

                sql = "Insert Into Product_Sold(P_ID, P_Name, P_cost, Amount, Month, Year) " +
                      "Values(@p_id, @p_name, @P_cost, @p_amount, @p_month, @p_year)";

                connection.Open();
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@P_id", p_id);
                command.Parameters.AddWithValue("@P_Name", p_name);
                command.Parameters.AddWithValue("@P_cost", total_cost);
                command.Parameters.AddWithValue("@p_amount", p_amount);
                command.Parameters.AddWithValue("@p_month", p_month);
                command.Parameters.AddWithValue("@p_year", p_year);

                if (coffeeDBDataSet.Product_Sold.Rows.Count == 0)
                {
                    command.ExecuteNonQuery();
                    this.product_SoldTableAdapter.Fill(this.coffeeDBDataSet.Product_Sold);
                    MessageBox.Show("First row");
                }

                bool found = false;
                for (int i = 0; i < coffeeDBDataSet.Product_Sold.Rows.Count; i++)
                {
                    if (coffeeDBDataSet.Product_Sold.Rows[i].ItemArray[1].Equals(comboBoxProduct.SelectedValue)
                     && coffeeDBDataSet.Product_Sold.Rows[i].ItemArray[5].Equals(comboBoxMonth.SelectedItem)
                     && coffeeDBDataSet.Product_Sold.Rows[i].ItemArray[6].Equals(comboBoxYear.SelectedItem))
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    command.ExecuteNonQuery();
                    this.product_SoldTableAdapter.Fill(this.coffeeDBDataSet.Product_Sold);
                }
                else if (found)
                {
                    MessageBox.Show("Record of same product and date already exists.");
                }
                command.Dispose();
                connection.Close();
          //  }
         //   catch (Exception)
          //  {
          //    throw;
           // } 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            Close();
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ShowMonthlySales = new ShowMonthlySales();
            ShowMonthlySales.Show();
        }
    }
}
