using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Edp
{
    public partial class frmOrders : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );

        public frmOrders()
        {
            InitializeComponent();
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDatabaseDataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.coffeeDatabaseDataSet1.Order);
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                this.orderTableAdapter.Fill(this.dataSet1.Order);

                dgvOrder.DataSource = this.dataSet1.Order;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearTextBoxes()
        {
            txtOrderID.Text = "";
            txtStatus.Text = "";
            txtTotalAmount.Text = "";
            txtProductID.Text = "";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard formDashboard = new frmDashboard();
            formDashboard.ShowDialog();
            this.Close();
        }


        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            txtBxSearchOrder.Text = "";

            LoadOrderData();
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaymentRecord formPaymentRecord = new frmPaymentRecord();
            formPaymentRecord.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Please select an order from the table first to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE [Order] SET " +
                                  "status = '" + txtStatus.Text + "', " + 
                                  "totalamount = " + txtTotalAmount.Text + ", " +
                                  "productID = " + txtProductID.Text + " " +
                                  "WHERE orderid = " + txtOrderID.Text;

                cmd.ExecuteNonQuery();
                connection.Close();

                ClearTextBoxes();
                MessageBox.Show("Order updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrderData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Please select an order from the table first to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this order record permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM [Order] WHERE orderid = " + txtOrderID.Text;

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    ClearTextBoxes();
                    MessageBox.Show("Order record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOrderData(); // Refresh jadual semula
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnSearchOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Jika kotak carian kosong, load semula semua data asal
                if (string.IsNullOrEmpty(txtBxSearchOrder.Text))
                {
                    LoadOrderData();
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Membuat carian terus merangkumi string status, ID pesanan, mahupun ID Produk
                cmd.CommandText = "SELECT * FROM [Order] WHERE " +
                                  "CAST(orderid AS VARCHAR) LIKE '%" + txtBxSearchOrder.Text + "%' OR " +
                                  "status LIKE '%" + txtBxSearchOrder.Text + "%' OR " +
                                  "CAST(productID AS VARCHAR) LIKE '%" + txtBxSearchOrder.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrder.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnClearOrder_Click_1(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtStatus.Text = "";
            txtTotalAmount.Text = "";
            txtProductID.Text = "";
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        bool isDescending = true;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string designerColumnName = "orderidDataGridViewTextBoxColumn";

                if (dgvOrder.Columns.Contains(designerColumnName))
                {
                    if (isDescending)
                    {
                        dgvOrder.Sort(dgvOrder.Columns[designerColumnName], ListSortDirection.Ascending);
                        button1.Text = "Sort Order ID: Oldest First";
                        isDescending = false; 
                    }
                    else
                    {
                        dgvOrder.Sort(dgvOrder.Columns[designerColumnName], ListSortDirection.Descending);
                        button1.Text = "Sort Order ID: Newest First";
                        isDescending = true; 
                    }
                }
                else
                {
                    MessageBox.Show("Order ID column not found for sorting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while sorting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}