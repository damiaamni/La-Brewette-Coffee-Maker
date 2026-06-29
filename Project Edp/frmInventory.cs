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
    public partial class frmInventory : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );

        public frmInventory()
        {
            InitializeComponent();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }
        private void LoadInventoryData()
        {
            try
            {
                this.ingredientsTableAdapter.Fill(this.dataSet1.Ingredients);

                dgvInventory.DataSource = this.dataSet1.Ingredients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtIngredientID.Text = "";
            txtNameID.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
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

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct formProduct = new frmProduct();
            formProduct.ShowDialog();
            this.Close();
        }

        private void btnRecipe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRecipe formRecipe = new frmRecipe();
            formRecipe.ShowDialog();
            this.Close();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPaymentRecord formPaymentRecord = new frmPaymentRecord();
            formPaymentRecord.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }

        private void btnSearchInventory_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBxSearchInventory.Text))
                {
                    LoadInventoryData();
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [Ingredients] WHERE " +
                                  "name LIKE '%" + txtBxSearchInventory.Text + "%' OR " +
                                  "CAST(ingredientid AS VARCHAR) LIKE '%" + txtBxSearchInventory.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvInventory.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnClearInventory_Click(object sender, EventArgs e)
        {
            txtBxSearchInventory.Text = "";

            LoadInventoryData();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];

                txtIngredientID.Text = row.Cells["ingredientid"].Value.ToString();
                txtNameID.Text = row.Cells["name"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtUnit.Text = row.Cells["unit"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO [Ingredients] (ingredientid, name, quantity, unit) VALUES (" +
                                  txtIngredientID.Text + ", '" +
                                  txtNameID.Text + "', " +
                                  txtQuantity.Text + ", '" +
                                  txtUnit.Text + "')";

                cmd.ExecuteNonQuery();
                connection.Close();

                ClearTextBoxes();
                MessageBox.Show("Inventory record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIngredientID.Text))
                {
                    MessageBox.Show("Please select an item from the table first to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Ingredients] SET " +
                                  "name = '" + txtNameID.Text + "', " +
                                  "quantity = " + txtQuantity.Text + ", " +
                                  "unit = '" + txtUnit.Text + "' " +
                                  "WHERE ingredientid = " + txtIngredientID.Text;

                cmd.ExecuteNonQuery();
                connection.Close();

                ClearTextBoxes();
                MessageBox.Show("Inventory updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIngredientID.Text))
                {
                    MessageBox.Show("Please select an item from the table first to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this inventory record permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM [Ingredients] WHERE ingredientid = " + txtIngredientID.Text;

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    ClearTextBoxes();
                    MessageBox.Show("Inventory record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadInventoryData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }
}