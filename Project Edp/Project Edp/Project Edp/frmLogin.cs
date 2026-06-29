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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard formDashboard = new frmDashboard();
            formDashboard.ShowDialog();
            this.Close();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.ShowDialog();
            this.Close();
        }
    }
}
