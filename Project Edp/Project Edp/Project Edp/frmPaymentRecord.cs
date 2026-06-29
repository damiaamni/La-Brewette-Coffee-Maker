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
            frmOrder formOrder = new frmOrder();
            formOrder.ShowDialog();
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

            // TODO: This line of code loads data into the 'dataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.dataSet1.Payment);

        }

        private void LoadPayment()
        {
            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
            dgvPayment.DataSource = this.dataSet1.Payment;
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
    }
}
