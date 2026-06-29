using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Edp
{
    public partial class frmDashboard : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );

        public frmDashboard()
        {
            InitializeComponent();
            LoadTopSellingChart();
            LoadWorstSellingChart();
            LoadDashboardMetrics();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadTopSellingChart();
            LoadWorstSellingChart();
            LoadDashboardMetrics();
        }

        private void LoadTopSellingChart()
        {
            chartTopSelling.Series.Clear();
            chartTopSelling.ChartAreas.Clear();
            chartTopSelling.Titles.Clear();

            ChartArea chartArea = new ChartArea("ChartArea1");
            chartTopSelling.ChartAreas.Add(chartArea);

            Series series = new Series("Total Orders");
            series.ChartType = SeriesChartType.Bar;

            string query = @"
                SELECT TOP 5 
                    BaseProduct.productname,
                    COUNT([Order].orderid) AS TotalSold
                FROM [Order]
                INNER JOIN BaseProduct
                ON [Order].productid = BaseProduct.productid
                GROUP BY BaseProduct.productname
                ORDER BY TotalSold DESC";

            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["productname"].ToString(),
                    Convert.ToInt32(reader["TotalSold"])
                );
            }

            reader.Close();
            connection.Close();

            chartTopSelling.Series.Add(series);
        }

        private void LoadWorstSellingChart()
        {
            chartWorstSelling.Series.Clear();
            chartWorstSelling.ChartAreas.Clear();
            chartWorstSelling.Titles.Clear();

            ChartArea chartArea = new ChartArea("ChartArea1");
            chartWorstSelling.ChartAreas.Add(chartArea);

            Series series = new Series("Total Orders");
            series.ChartType = SeriesChartType.Bar;

            string query = @"
                SELECT TOP 5 
                    BaseProduct.productname,
                    COUNT([Order].orderid) AS TotalSold
                FROM [Order]
                INNER JOIN BaseProduct
                ON [Order].productid = BaseProduct.productid
                GROUP BY BaseProduct.productname
                ORDER BY TotalSold ASC";

            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["productname"].ToString(),
                    Convert.ToInt32(reader["TotalSold"])
                );
            }

            reader.Close();
            connection.Close();

            chartWorstSelling.Series.Add(series);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrders formOrders = new frmOrders();
            formOrders.ShowDialog();
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct formProduct = new frmProduct();
            formProduct.ShowDialog();
            this.Close();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct formProduct = new frmProduct();
            formProduct.ShowDialog();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory formInventory = new frmInventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipe formRecipe = new frmRecipe();
            formRecipe.ShowDialog();
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaymentRecord formPaymentRecord = new frmPaymentRecord();
            formPaymentRecord.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }

        private void LoadDashboardMetrics()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT (SELECT SUM(amountpaid) FROM [Payment] WHERE paymentstatus = 'Completed' OR paymentstatus = 'Paid') AS TotalRevenue, " +
                                  "(SELECT COUNT(orderid) FROM [Order]) AS TotalItems";

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTotalRevenue.Text = "Total Revenue: RM " + reader["TotalRevenue"].ToString();
                    lblTotalItemsSold.Text = "Quantity Of Drink Sold: " + reader["TotalItems"].ToString() + " Cups Sold";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

    }
}