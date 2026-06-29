using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Project_Edp
{
    public partial class frmPayment : Form
    {
        //gotta change if other pc (too lazy to fix)
        // FIXED
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CoffeeDatabase.mdf;Integrated Security=True";

        private string selectedDrink = "None";
        private string selectedAddons = "None";
        private decimal basePriceAmt = 0.00m;
        private decimal totalAmt = 0.00m;


        public frmPayment(string drink, string addon, string price, string total)
        {
            InitializeComponent();

            this.selectedDrink = drink;
            this.selectedAddons = addon;

            // Convert price text into clean decimal numbers for the database
            decimal.TryParse(price.Replace("RM", "").Trim(), out basePriceAmt);
            decimal.TryParse(total.Replace("RM", "").Trim(), out totalAmt);

            lblDrink.Text = "Drink : " + drink;
            lblAddon.Text = "Add-On : " + addon;
            lblBasePrice.Text = "Base Price : " + price;
            lblTotalAmount.Text = "Total Amount : " + total;
            lblAmountToPay.Text = "Amount to pay : " + total;
        }

        public frmPayment(string total)
        {
            InitializeComponent();
            decimal.TryParse(total.Replace("RM", "").Trim(), out totalAmt);
            lblAmountToPay.Text = "Amount to pay : " + total;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu order = new frmMenu();
            order.Show();
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";

            if (rbCash.Checked)
                paymentMethod = "Cash";
            else if (rbCard.Checked)
                paymentMethod = "Card";
            else if (rbQRPay.Checked)
                paymentMethod = "QR Pay";
            else
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = GetProductIdByName(selectedDrink);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Start the Database Transaction
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert into [Order] (Database auto-generates orderid & timestamp)
                            int newOrderId = 0;
                            string insertOrderQuery = @"
                                INSERT INTO [Order] (status, totalamount, productid) 
                                OUTPUT INSERTED.orderid 
                                VALUES ('Completed', @total, @productid)";

                            using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@total", totalAmt);
                                cmd.Parameters.AddWithValue("@productid", productId);

                                // Capture the auto-generated identity ID
                                newOrderId = (int)cmd.ExecuteScalar();
                            }

                            // 2. Deduct Inventory based on Recipe formulas
                            string updateRecipeStockQuery = @"
                                UPDATE i 
                                SET i.quantity = i.quantity - r.amount
                                FROM Ingredients i
                                INNER JOIN Recipe r ON i.ingredientid = r.ingredientid
                                WHERE r.productid = @productid";

                            using (SqlCommand cmd = new SqlCommand(updateRecipeStockQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@productid", productId);
                                cmd.ExecuteNonQuery();
                            }

                            // 3. Handle Add-Ons (if chosen)
                            if (selectedAddons != "None" && !string.IsNullOrEmpty(selectedAddons))
                            {
                                string[] addonArray = selectedAddons.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string addonName in addonArray)
                                {
                                    int addonId = GetAddonIdByName(addonName);

                                    // Insert Custom Option record
                                    string insertCustomQuery = "INSERT INTO Custom (addonid, quantity, orderid) VALUES (@addonid, 1.00, @orderid)";
                                    using (SqlCommand cmd = new SqlCommand(insertCustomQuery, conn, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@addonid", addonId);
                                        cmd.Parameters.AddWithValue("@orderid", newOrderId);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Deduct stock for the specific add-on ingredient
                                    string updateAddonStockQuery = @"
                                        UPDATE i 
                                        SET i.quantity = i.quantity - 1.00 
                                        FROM Ingredients i
                                        INNER JOIN AddOn a ON i.ingredientid = a.ingredientid
                                        WHERE a.addonid = @addonid";

                                    using (SqlCommand cmd = new SqlCommand(updateAddonStockQuery, conn, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@addonid", addonId);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // 4. Insert into Payment table (paymentid is auto-generated)
                            string insertPaymentQuery = "INSERT INTO Payment (paymentmethod, amountpaid, paymentstatus, orderid) VALUES (@method, @amount, 'Paid', @oid)";
                            using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@method", paymentMethod);
                                cmd.Parameters.AddWithValue("@amount", totalAmt);
                                cmd.Parameters.AddWithValue("@oid", newOrderId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Roll back changes if an error occurred during checkout steps
                            transaction.Rollback();
                            throw new Exception("Transaction failed: " + ex.Message);
                        }
                    }
                }

                string amount = lblAmountToPay.Text.Replace("Amount to pay : ", "");
                frmThankYou thankYou = new frmThankYou(paymentMethod, amount);
                thankYou.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetProductIdByName(string name)
        {
            if (name.Contains("Americano"))
            {
                return 1;
            }
            else if (name.Contains("Latte"))
            {
                return 2;
            }
            else if (name.Contains("Cappuccino"))
            {
                return 3;
            }
            else if (name.Contains("Chocolate"))
            {
                return 4;
            }
            else if (name.Contains("Milk Tea"))
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }
        private int GetAddonIdByName(string name)
        {
            if (name.Contains("Milk"))
            {
                return 1;
            }
            else if (name.Contains("Chocolate Syrup"))
            {
                return 2;
            }
            else if (name.Contains("Caramel Syrup"))
            {
                return 3;
            }
            else if (name.Contains("Whipped Cream"))
            {
                return 4;
            }
            else if (name.Contains("Sugar"))
            {
                return 5;
            }
            else if (name.Contains("Ice"))
            {
                return 6;
            }
            else
            {
                return 1;
            }
        }
    }
}