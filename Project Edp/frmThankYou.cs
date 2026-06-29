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
    public partial class frmThankYou : Form
    {
        public frmThankYou()
        {
            InitializeComponent();
        }

        private void frmThankYou_Load(object sender, EventArgs e)
        {

        }

        private void gbPaymentSummary_Enter(object sender, EventArgs e)
        {

        }

        public frmThankYou(string method, string amount)
        {
            InitializeComponent();

            lblPaymentmethod.Text = "Payment Method : " + method;
            lblAmountpaid.Text = "Amount Paid : " + amount;

            StartDrinkPreparation();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            welcome.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void StartDrinkPreparation()
        {
            progressBarDrink.Value = 0;            
            lblStatus.Text = "Preparing your drink...";
            drinkTimer.Start();               
        }

        private void drinkTimer_Tick(object sender, EventArgs e)
        {
            if (progressBarDrink.Value < progressBarDrink.Maximum)
            {
                progressBarDrink.Value += 1;
            }
            else
            {
                drinkTimer.Stop();
                lblStatus.Text = "Your drink is ready! ☕🎉";
            }
        }
    }
}
