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
    public partial class frmProduct : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True"
        );
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            LoadBaseProduct();
            LoadAddOnProduct();

            // TODO: This line of code loads data into the 'dataSet1.AddOn' table. You can move, or remove it, as needed.
            this.addOnTableAdapter.Fill(this.dataSet1.AddOn);
            // TODO: This line of code loads data into the 'dataSet1.BaseProduct' table. You can move, or remove it, as needed.
            this.baseProductTableAdapter.Fill(this.dataSet1.BaseProduct);

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

        private void LoadBaseProduct()
        {
            this.baseProductTableAdapter.Fill(this.dataSet1.BaseProduct);
            dgvBaseProduct.DataSource = this.dataSet1.BaseProduct;
        }

        private void LoadAddOnProduct()
        {
            this.addOnTableAdapter.Fill(this.dataSet1.AddOn);
            dgvAddOnProduct.DataSource = this.dataSet1.AddOn;
        }


        private void btnAddAddOn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO [AddOn] (addonid, name, price, type, ingredientid) VALUES (" +
                              txtBxAddOnID.Text + ", '" +
                              txtBxAddOnName.Text + "', " +
                              txtBxAddOnPrice.Text + ", '" +
                              txtBxType.Text + "', " +
                              txtBxIngredientID.Text + ")";

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxAddOnID.Text = "";
            txtBxAddOnName.Text = "";
            txtBxAddOnPrice.Text = "";
            txtBxType.Text = "";
            txtBxIngredientID.Text = "";

            MessageBox.Show("Add-On product inserted successfully");

            this.addOnTableAdapter.Fill(this.dataSet1.AddOn);
        }

        private void btnUpdateAddOn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE [AddOn] SET " +
                              "name = '" + txtBxAddOnName.Text + "', " +
                              "price = " + txtBxAddOnPrice.Text + ", " +
                              "type = '" + txtBxType.Text + "', " +
                              "ingredientid = " + txtBxIngredientID.Text + " " +
                              "WHERE addonid = " + txtBxAddOnID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxAddOnID.Text = "";
            txtBxAddOnName.Text = "";
            txtBxAddOnPrice.Text = "";
            txtBxType.Text = "";
            txtBxIngredientID.Text = "";

            MessageBox.Show("Add-On product updated successfully");

            this.addOnTableAdapter.Fill(this.dataSet1.AddOn);
        }

        private void btnDeleteAddOn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM [AddOn] WHERE addonid = " + txtBxAddOnID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxAddOnID.Text = "";
            txtBxAddOnName.Text = "";
            txtBxAddOnPrice.Text = "";
            txtBxType.Text = "";
            txtBxIngredientID.Text = "";

            MessageBox.Show("Add-On product deleted successfully");

            this.addOnTableAdapter.Fill(this.dataSet1.AddOn);
        }

        private void btnAddBase_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO [BaseProduct] (productid, productname, baseprice, category) VALUES (" +
                              txtBxProductID.Text + ", '" +
                              txtBxProductName.Text + "', " +
                              txtBxBasePrice.Text + ", '" +
                              txtBxCategory.Text + "')";

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxProductID.Text = "";
            txtBxProductName.Text = "";
            txtBxBasePrice.Text = "";
            txtBxCategory.Text = "";

            MessageBox.Show("Base Product is added successfully");

            this.baseProductTableAdapter.Fill(this.dataSet1.BaseProduct);
        }

        private void btnUpdateBase_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE [BaseProduct] SET " +
                                  "productname = '" + txtBxProductName.Text + "', " +
                                  "baseprice = " + txtBxBasePrice.Text + ", " +
                                  "category = '" + txtBxCategory.Text + "' " +
                                  "WHERE productid = " + txtBxProductID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxProductID.Text = "";
            txtBxProductName.Text = "";
            txtBxBasePrice.Text = "";
            txtBxCategory.Text = "";
            txtBxProductID.Text = "";

            MessageBox.Show("Base product updated successfully");

            this.baseProductTableAdapter.Fill(this.dataSet1.BaseProduct);
        }

        private void btnDeleteBase_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM [BaseProduct] WHERE productid = " + txtBxProductID.Text;

            cmd.ExecuteNonQuery();

            connection.Close();

            txtBxProductID.Text = "";
            txtBxProductName.Text = "";
            txtBxBasePrice.Text = "";
            txtBxCategory.Text = "";

            MessageBox.Show("Base product deleted successfully");

            this.baseProductTableAdapter.Fill(this.dataSet1.BaseProduct);
        }

        private void btnSearchBase_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM [BaseProduct] WHERE " +
                              "CAST(productid AS VARCHAR) LIKE '%" + txtBxSearchBase.Text + "%' OR " +
                              "productname LIKE '%" + txtBxSearchBase.Text + "%' OR " +
                              "CAST(baseprice AS VARCHAR) LIKE '%" + txtBxSearchBase.Text + "%' OR " +
                              "category LIKE '%" + txtBxSearchBase.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBaseProduct.DataSource = dt;

            connection.Close();
        }

        private void btnClearBase_Click(object sender, EventArgs e)
        {
            txtBxSearchBase.Text = "";

            LoadBaseProduct();
        }

        private void btnSearchAddOn_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM [AddOn] WHERE " +
                              "CAST(addonid AS VARCHAR) LIKE '%" + txtBxSearchAddOn.Text + "%' OR " +
                              "name LIKE '%" + txtBxSearchAddOn.Text + "%' OR " +
                              "CAST(price AS VARCHAR) LIKE '%" + txtBxSearchAddOn.Text + "%' OR " +
                              "type LIKE '%" + txtBxSearchAddOn.Text + "%' OR " +
                              "CAST(ingredientid AS VARCHAR) LIKE '%" + txtBxSearchAddOn.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAddOnProduct.DataSource = dt;

            connection.Close();
        }

        private void btnClearAddOn_Click(object sender, EventArgs e)
        {
            txtBxSearchAddOn.Text = "";

            LoadAddOnProduct();
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
