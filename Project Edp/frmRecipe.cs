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
    public partial class frmRecipe : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );

        public frmRecipe()
        {
            InitializeComponent();
        }
        private void frmRecipe_Load(object sender, EventArgs e)
        {
            LoadRecipeData();
        }

        private void LoadRecipeData()
        {
            try
            {
                this.recipeTableAdapter.Fill(this.dataSet1.Recipe);

                dgvRecipe.DataSource = this.dataSet1.Recipe;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recipe records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtProductID.Text = "";
            txtIngredientID.Text = "";
            txtAmountID.Text = "";
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrders formOrders = new frmOrders();
            formOrders.ShowDialog();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard formDashboard = new frmDashboard();
            formDashboard.ShowDialog();
            this.Close();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct formProduct = new frmProduct();
            formProduct.ShowDialog();
            this.Close();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory formInventory = new frmInventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaymentRecord formPaymentRecord = new frmPaymentRecord();
            formPaymentRecord.ShowDialog();
            this.Close();
        }

        private void btnSearchRecipe_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBxSearchRecipe.Text))
                {
                    LoadRecipeData();
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [Recipe] WHERE " +
                                  "CAST(productid AS VARCHAR) LIKE '%" + txtBxSearchRecipe.Text + "%' OR " +
                                  "CAST(ingredientid AS VARCHAR) LIKE '%" + txtBxSearchRecipe.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecipe.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnClearRecipe_Click(object sender, EventArgs e)
        {
            txtBxSearchRecipe.Text = "";

            LoadRecipeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO [Recipe] (productid, ingredientid, amount) VALUES (" +
                                  txtProductID.Text + ", " +
                                  txtIngredientID.Text + ", " +
                                  txtAmountID.Text + ")";

                cmd.ExecuteNonQuery();
                connection.Close();

                ClearTextBoxes();
                MessageBox.Show("Recipe record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRecipeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductID.Text) || string.IsNullOrEmpty(txtIngredientID.Text))
                {
                    MessageBox.Show("Please select a recipe from the table first to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE [Recipe] SET " +
                                  "amount = " + txtAmountID.Text + " " +
                                  "WHERE productid = " + txtProductID.Text + " AND ingredientid = " + txtIngredientID.Text;

                cmd.ExecuteNonQuery();
                connection.Close();

                ClearTextBoxes();
                MessageBox.Show("Recipe updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRecipeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductID.Text) || string.IsNullOrEmpty(txtIngredientID.Text))
                {
                    MessageBox.Show("Please select a recipe from the table first to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this recipe record permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "DELETE FROM [Recipe] WHERE productid = " + txtProductID.Text + " AND ingredientid = " + txtIngredientID.Text;

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    ClearTextBoxes();
                    MessageBox.Show("Recipe record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadRecipeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        private void dgvRecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvRecipe.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["productid"].Value.ToString();
                txtIngredientID.Text = row.Cells["ingredientid"].Value.ToString();
                txtAmountID.Text = row.Cells["amount"].Value.ToString();
            }
        }
    }
}