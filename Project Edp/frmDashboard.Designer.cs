namespace Project_Edp
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTotalItemsSold = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.chartWorstSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblWorstSelling = new System.Windows.Forms.Label();
            this.lblTopSelling = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWorstSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(3, 1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Panel1.Controls.Add(this.lblStaff);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Panel2.Controls.Add(this.btnLogout);
            this.splitContainer2.Panel2.Controls.Add(this.lblDashboardTitle);
            this.splitContainer2.Size = new System.Drawing.Size(1257, 73);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 23;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(21, 24);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(176, 25);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "LOGIN AS STAFF";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(898, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 58);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Location = new System.Drawing.Point(27, 24);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(138, 25);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "DASHBOARD";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.Location = new System.Drawing.Point(11, 570);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(200, 90);
            this.btnPayment.TabIndex = 21;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecipe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecipe.Location = new System.Drawing.Point(11, 474);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(200, 90);
            this.btnRecipe.TabIndex = 20;
            this.btnRecipe.Text = "RECIPE";
            this.btnRecipe.UseVisualStyleBackColor = false;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventory.Location = new System.Drawing.Point(11, 378);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 90);
            this.btnInventory.TabIndex = 19;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Location = new System.Drawing.Point(11, 282);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 90);
            this.btnProduct.TabIndex = 18;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(11, 186);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 90);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Location = new System.Drawing.Point(11, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 90);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Tan;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Tan;
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalItemsSold);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalRevenue);
            this.splitContainer1.Panel2.Controls.Add(this.chartWorstSelling);
            this.splitContainer1.Panel2.Controls.Add(this.chartTopSelling);
            this.splitContainer1.Panel2.Controls.Add(this.lblWorstSelling);
            this.splitContainer1.Panel2.Controls.Add(this.lblTopSelling);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 591);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 22;
            // 
            // lblTotalItemsSold
            // 
            this.lblTotalItemsSold.AutoSize = true;
            this.lblTotalItemsSold.Location = new System.Drawing.Point(87, 79);
            this.lblTotalItemsSold.Name = "lblTotalItemsSold";
            this.lblTotalItemsSold.Size = new System.Drawing.Size(107, 25);
            this.lblTotalItemsSold.TabIndex = 5;
            this.lblTotalItemsSold.Text = "Loading ....";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(87, 34);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(102, 25);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Loading ...";
            // 
            // chartWorstSelling
            // 
            chartArea3.Name = "ChartArea1";
            this.chartWorstSelling.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartWorstSelling.Legends.Add(legend3);
            this.chartWorstSelling.Location = new System.Drawing.Point(629, 174);
            this.chartWorstSelling.Name = "chartWorstSelling";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartWorstSelling.Series.Add(series3);
            this.chartWorstSelling.Size = new System.Drawing.Size(338, 369);
            this.chartWorstSelling.TabIndex = 3;
            this.chartWorstSelling.Text = "chart2";
            // 
            // chartTopSelling
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTopSelling.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTopSelling.Legends.Add(legend4);
            this.chartTopSelling.Location = new System.Drawing.Point(96, 174);
            this.chartTopSelling.Name = "chartTopSelling";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTopSelling.Series.Add(series4);
            this.chartTopSelling.Size = new System.Drawing.Size(338, 369);
            this.chartTopSelling.TabIndex = 2;
            this.chartTopSelling.Text = "chart1";
            // 
            // lblWorstSelling
            // 
            this.lblWorstSelling.AutoSize = true;
            this.lblWorstSelling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorstSelling.Location = new System.Drawing.Point(625, 138);
            this.lblWorstSelling.Name = "lblWorstSelling";
            this.lblWorstSelling.Size = new System.Drawing.Size(285, 28);
            this.lblWorstSelling.TabIndex = 1;
            this.lblWorstSelling.Text = "Top 5 Worst Selling Products";
            // 
            // lblTopSelling
            // 
            this.lblTopSelling.AutoSize = true;
            this.lblTopSelling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSelling.Location = new System.Drawing.Point(92, 138);
            this.lblTopSelling.Name = "lblTopSelling";
            this.lblTopSelling.Size = new System.Drawing.Size(223, 28);
            this.lblTopSelling.TabIndex = 0;
            this.lblTopSelling.Text = "Top 5 Selling Products";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWorstSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSelling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTopSelling;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWorstSelling;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSelling;
        private System.Windows.Forms.Label lblWorstSelling;
        private System.Windows.Forms.Label lblTotalItemsSold;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}