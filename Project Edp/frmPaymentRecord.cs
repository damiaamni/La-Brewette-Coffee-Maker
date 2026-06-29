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

namespace Project_Edp
{
    public partial class frmPaymentRecord : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );
        public frmPaymentRecord()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard formDashboard = new frmDashboard();
            formDashboard.ShowDialog();
            this.Close();
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

        private void frmPaymentRecord_Load(object sender, EventArgs e)
        {
            LoadPayment();
            DisplayPaymentAnalytics();

            // this.paymentTableAdapter1.Fill(this.coffeeDatabaseDataSet2.Payment);
            // this.paymentTableAdapter.Fill(this.dataSet1.Payment);
        }

        private void LoadPayment()
        {
            try
            {
                this.paymentTableAdapter.Fill(this.dataSet1.Payment);
                dgvPayment.DataSource = this.dataSet1.Payment.DefaultView.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO [Payment] (paymentid, paymentmethod, amountpaid, paymentstatus, orderid) VALUES (" +
                              txtBxPaymentID.Text + ", '" +
                              txtBxPaymentMethod.Text + "', " +
                              txtBxAmountPaid.Text + ", '" +
                              txtBxPaymentStatus.Text + "', " +
                              txtBxOrderID.Text + ")";

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxPaymentID.Text = "";
            txtBxPaymentMethod.Text = "";
            txtBxAmountPaid.Text = "";
            txtBxPaymentStatus.Text = "";
            txtBxOrderID.Text = "";

            MessageBox.Show("Payment added successfully");

            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE [Payment] SET " +
                              "paymentmethod = '" + txtBxPaymentMethod.Text + "', " +
                              "amountpaid = " + txtBxAmountPaid.Text + ", " +
                              "paymentstatus = '" + txtBxPaymentStatus.Text + "', " +
                              "orderid = " + txtBxOrderID.Text + " " +
                              "WHERE paymentid = " + txtBxPaymentID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxPaymentID.Text = "";
            txtBxPaymentMethod.Text = "";
            txtBxAmountPaid.Text = "";
            txtBxPaymentStatus.Text = "";
            txtBxOrderID.Text = "";

            MessageBox.Show("Payment updated successfully");

            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
            DisplayPaymentAnalytics();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM [Payment] WHERE paymentid = " + txtBxPaymentID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxPaymentID.Text = "";
            txtBxPaymentMethod.Text = "";
            txtBxAmountPaid.Text = "";
            txtBxPaymentStatus.Text = "";
            txtBxOrderID.Text = "";

            MessageBox.Show("Payment deleted successfully");

            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
        }

        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM [Payment] WHERE " +
                              "CAST(paymentid AS VARCHAR) LIKE '%" + txtBxSearchPayment.Text + "%' OR " +
                              "paymentmethod LIKE '%" + txtBxSearchPayment.Text + "%' OR " +
                              "CAST(amountpaid AS VARCHAR) LIKE '%" + txtBxSearchPayment.Text + "%' OR " +
                              "paymentstatus LIKE '%" + txtBxSearchPayment.Text + "%' OR " +
                              "CAST(orderid AS VARCHAR) LIKE '%" + txtBxSearchPayment.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvPayment.DataSource = dt;

            connection.Close();
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            txtBxSearchPayment.Text = "";

            LoadPayment();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }

        private void DisplayPaymentAnalytics()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT paymentmethod, COUNT(*) AS TotalCount FROM [Payment] GROUP BY paymentmethod";

                SqlDataReader reader = cmd.ExecuteReader();

                int cashCount = 0;
                int cardCount = 0;
                int qrCount = 0;

                while (reader.Read())
                {
                    string method = reader["paymentmethod"].ToString().Trim().ToLower();
                    int count = Convert.ToInt32(reader["TotalCount"]);

                    if (method == "cash") cashCount = count;
                    else if (method == "card") cardCount = count;
                    else if (method.Contains("qr")) qrCount = count; 
                }
                reader.Close();
                connection.Close();
                lblPaymentSummary.Text = $"Summary Analysis = Cash: {cashCount} orders  |  Card: {cardCount} orders  |  QR Pay: {qrCount} orders";
            }
            catch (Exception ex)
            {
                lblPaymentSummary.Text = "Error loading payment analytics summary.";
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        bool isPaymentGroupDesc = true;
        private void btnGroupPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                string colName = "dataGridViewTextBoxColumn2";

                if (dgvPayment.Columns.Contains(colName))
                {

                    if (isPaymentGroupDesc)
                    {
                        dgvPayment.Sort(dgvPayment.Columns[colName], ListSortDirection.Ascending);
                        btnGroupPayment.Text = "Group: Payment Method (A-Z)";
                        isPaymentGroupDesc = false;
                    }
                    else
                    {
                        dgvPayment.Sort(dgvPayment.Columns[colName], ListSortDirection.Descending);
                        btnGroupPayment.Text = "Group: Payment Method (Z-A)";
                        isPaymentGroupDesc = true;
                    }
                }
                else
                {
                    MessageBox.Show("Payment Method column not found for grouping.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting data grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
