using Add_Monthly_Sales.CoffeeDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Monthly_Sales
{
    public partial class ShowMonthlySales : Form
    {
        public ShowMonthlySales()
        {
            InitializeComponent();
        }


        private void ShowMonthlySales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monthDBDataSet.Month' table. You can move, or remove it, as needed.
            this.monthTableAdapter.Fill(this.monthDBDataSet.Month);

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source = DESKTOP-C9RSMTE; Initial Catalog = CoffeeDB; Integrated Security = True";
            MessageBox.Show(listBoxMonthFrom.SelectedValue.ToString());
            //int year_from = (int)listBoxYearFrom.SelectedItem;
            //int month_from = (int)listBoxMonthFrom.SelectedValue;
            //int year_to = (int)listBoxYearTo.SelectedItem;
            //int month_to = (int)listBoxMonthTo.SelectedValue;
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select P_Name, P_cost, Amount, Month, Year From Product_Sold " +
                                               "Where id >= " + 0 + "  AND Year >= " + 0 + "" +
                                               "AND   id <= " + 12 + "  AND Year <= " + 2020 + "", sqlConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlConnection.Open();

            try
            {


            DataTable table = new DataTable
            {
                Locale = System.Globalization.CultureInfo.InvariantCulture
            };

            sqlDataAdapter.Fill(table);

            productSoldBindingSource.DataSource = table;


            dataGridViewSold.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            dataGridViewSold.DataSource = productSoldBindingSource;
            }
                catch (Exception)
            {
                throw;
            }

            sqlConnection.Close();

        }
    }
}
