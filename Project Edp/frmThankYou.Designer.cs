namespace Project_Edp
{
    partial class frmThankYou
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPaymentSummary = new System.Windows.Forms.GroupBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblAmountpaid = new System.Windows.Forms.Label();
            this.lblPaymentmethod = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.progressBarDrink = new System.Windows.Forms.ProgressBar();
            this.drinkTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbPaymentSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(517, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "LA BREWETTE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(581, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "THANK YOU!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(473, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your order has been placed successfully.";
            // 
            // gbPaymentSummary
            // 
            this.gbPaymentSummary.Controls.Add(this.lblmessage);
            this.gbPaymentSummary.Controls.Add(this.lblAmountpaid);
            this.gbPaymentSummary.Controls.Add(this.lblPaymentmethod);
            this.gbPaymentSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentSummary.Location = new System.Drawing.Point(469, 303);
            this.gbPaymentSummary.Name = "gbPaymentSummary";
            this.gbPaymentSummary.Size = new System.Drawing.Size(365, 233);
            this.gbPaymentSummary.TabIndex = 4;
            this.gbPaymentSummary.TabStop = false;
            this.gbPaymentSummary.Text = "Payment Summary";
            this.gbPaymentSummary.Enter += new System.EventHandler(this.gbPaymentSummary_Enter);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(98, 169);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(172, 28);
            this.lblmessage.TabIndex = 2;
            this.lblmessage.Text = "Enjoy your drink !!";
            // 
            // lblAmountpaid
            // 
            this.lblAmountpaid.AutoSize = true;
            this.lblAmountpaid.Location = new System.Drawing.Point(21, 103);
            this.lblAmountpaid.Name = "lblAmountpaid";
            this.lblAmountpaid.Size = new System.Drawing.Size(134, 28);
            this.lblAmountpaid.TabIndex = 1;
            this.lblAmountpaid.Text = "Amount Paid :";
            // 
            // lblPaymentmethod
            // 
            this.lblPaymentmethod.AutoSize = true;
            this.lblPaymentmethod.Location = new System.Drawing.Point(21, 64);
            this.lblPaymentmethod.Name = "lblPaymentmethod";
            this.lblPaymentmethod.Size = new System.Drawing.Size(171, 28);
            this.lblPaymentmethod.TabIndex = 0;
            this.lblPaymentmethod.Text = "Payment Method :";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBackToHome.ForeColor = System.Drawing.Color.White;
            this.btnBackToHome.Location = new System.Drawing.Point(560, 567);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(188, 54);
            this.btnBackToHome.TabIndex = 5;
            this.btnBackToHome.Text = "Back to Home";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // progressBarDrink
            // 
            this.progressBarDrink.ForeColor = System.Drawing.Color.ForestGreen;
            this.progressBarDrink.Location = new System.Drawing.Point(469, 183);
            this.progressBarDrink.Name = "progressBarDrink";
            this.progressBarDrink.Size = new System.Drawing.Size(365, 23);
            this.progressBarDrink.TabIndex = 6;
            // 
            // drinkTimer
            // 
            this.drinkTimer.Interval = 10;
            this.drinkTimer.Tick += new System.EventHandler(this.drinkTimer_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(555, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(214, 28);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Preparing Your Drink ...";
            this.lblStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmThankYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarDrink);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.gbPaymentSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThankYou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThankYou";
            this.Load += new System.EventHandler(this.frmThankYou_Load);
            this.gbPaymentSummary.ResumeLayout(false);
            this.gbPaymentSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPaymentSummary;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lblAmountpaid;
        private System.Windows.Forms.Label lblPaymentmethod;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.ProgressBar progressBarDrink;
        private System.Windows.Forms.Timer drinkTimer;
        private System.Windows.Forms.Label lblStatus;
    }
}