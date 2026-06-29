using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Edp
{
    public partial class frmMenu : Form
    {
        double basePrice = 6.50;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            rdAmericano.Checked = true;

            lblSelectedDrink.Text = "Selected Drink : Americano";
            lblPrice.Text = "Price : RM6.50";
            lblTotal.Text = "Total : RM6.50";

            picDrink.Image = imageList1.Images[0];

        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            rdAmericano.Visible = true;
            rdLatte.Visible = true;
            rdCappuccino.Visible = true;
            rdAmericano.Text = "Americano RM6.50";
            rdLatte.Text = "Latte RM8.00";
            rdCappuccino.Text = "Cappuccino RM8.50";
            rdAmericano.Checked = true;
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            rdAmericano.Text = "Milk Tea RM7.00";

            rdLatte.Visible = false;
            rdCappuccino.Visible = false;
            rdAmericano.Checked = true;
            basePrice = 7.00;
            lblSelectedDrink.Text = "Selected Drink : Milk Tea";
            lblPrice.Text = "Price : RM7.00";
            picDrink.Image = imageList1.Images[3];

            CalculateTotal();
        }

        private void btnNonCoffee_Click(object sender, EventArgs e)
        {
            rdAmericano.Text = "Chocolate Drink RM7.50";
            rdLatte.Visible = false;
            rdCappuccino.Visible = false;
            rdAmericano.Checked = true;
            basePrice = 7.50;
            lblSelectedDrink.Text = "Selected Drink : Chocolate Drink";
            lblPrice.Text = "Price : RM7.50";
            picDrink.Image = imageList1.Images[4];

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double addOn = 0;

            if (cbExtraMilk.Checked)
                addOn += 1.50;

            if (cbChocSyrup.Checked)
                addOn += 2.00;

            if (cbCaramelSyrup.Checked)
                addOn += 2.00;

            if (cbWhippedCream.Checked)
                addOn += 1.80;

            if (cbExtraSugar.Checked)
                addOn += 0.50;

            if (cbExtraIce.Checked)
                addOn += 0.30;

            double total = (basePrice + addOn);

            lblTotal.Text = "Total : RM" + total.ToString("0.00");
        }

        private void rdAmericano_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmericano.Checked && rdAmericano.Text.Contains("Americano"))
            {
                basePrice = 6.50;
                lblSelectedDrink.Text = "Selected Drink : Americano";
                lblPrice.Text = "Price : RM6.50";
                lblTotal.Text = "Total : RM6.50";

                picDrink.Image = imageList1.Images[0];
                CalculateTotal();
            }

        }


        private void rdLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLatte.Checked)
            {
                basePrice = 8.00;
                lblSelectedDrink.Text = "Selected Drink : Latte";
                lblPrice.Text = "Price : RM8.00";
                lblTotal.Text = "Total : RM8.00";

                picDrink.Image = imageList1.Images[1];
                CalculateTotal();
            }
        }

        private void rdCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCappuccino.Checked)
            {
                basePrice = 8.50;
                lblSelectedDrink.Text = "Selected Drink : Cappuccino";
                lblPrice.Text = "Price : RM8.50";
                lblTotal.Text = "Total : RM8.50";

                picDrink.Image = imageList1.Images[2];
                CalculateTotal();
            }
        }

        private void gbAddOn_Enter(object sender, EventArgs e)
        {
            double addOn = 0;

            if (cbExtraMilk.Checked) addOn += 1.50;
            if (cbChocSyrup.Checked) addOn += 2.00;
            if (cbCaramelSyrup.Checked) addOn += 2.00;
            if (cbWhippedCream.Checked) addOn += 1.80;
            if (cbExtraSugar.Checked) addOn += 0.50;
            if (cbExtraIce.Checked) addOn += 0.30;

            double total = basePrice + addOn;
            lblTotal.Text = "Total : RM" + total.ToString("0.00");
        }

        private void cbExtraMilk_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cbChocSyrup_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cbCaramelSyrup_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cbWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cbExtraIce_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cbExtraSugar_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            rdAmericano.Checked = true;

            lblSelectedDrink.Text = "Selected Drink : Americano";
            lblPrice.Text = "Price : RM6.50";
            lblTotal.Text = "Total : RM6.50";

            picDrink.Image = imageList1.Images[0];
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            welcome.Show();

            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdAmericano.Checked = true;

            cbExtraMilk.Checked = false;
            cbChocSyrup.Checked = false;
            cbCaramelSyrup.Checked = false;
            cbWhippedCream.Checked = false;
            cbExtraSugar.Checked = false;
            cbExtraIce.Checked = false;
            lblSelectedDrink.Text = "Selected Drink : Americano";
            lblPrice.Text = "Price : RM6.50";
            basePrice = 6.50;
            picDrink.Image = imageList1.Images[0];

            CalculateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string drink = lblSelectedDrink.Text.Replace("Selected Drink : ", "");
            string price = lblPrice.Text.Replace("Price : ", "");
            string total = lblTotal.Text.Replace("Total : ", "");
            string addOn = GetSelectedAddOn();

            frmPayment payment = new frmPayment(drink, addOn, price, total);
            payment.Show();

            this.Hide();
        }

        private string GetSelectedAddOn()
        {
            string addOn = "";

            if (cbExtraMilk.Checked) addOn += "Extra Milk, ";
            if (cbChocSyrup.Checked) addOn += "Chocolate Syrup, ";
            if (cbCaramelSyrup.Checked) addOn += "Caramel Syrup, ";
            if (cbWhippedCream.Checked) addOn += "Whipped Cream, ";
            if (cbExtraSugar.Checked) addOn += "Extra Sugar, ";
            if (cbExtraIce.Checked) addOn += "Extra Ice, ";

            if (addOn == "")
                return "None";

            return addOn.TrimEnd(',', ' ');
        }
    }
}