namespace Project_Edp
{
    partial class frmPayment
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
            this.lblPaymentDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPaymentDetails = new System.Windows.Forms.GroupBox();
            this.rbQRPay = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblAddon = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.gbPaymentDetails.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPaymentDetails
            // 
            this.lblPaymentDetails.AutoSize = true;
            this.lblPaymentDetails.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPaymentDetails.Location = new System.Drawing.Point(465, 77);
            this.lblPaymentDetails.Name = "lblPaymentDetails";
            this.lblPaymentDetails.Size = new System.Drawing.Size(395, 32);
            this.lblPaymentDetails.TabIndex = 2;
            this.lblPaymentDetails.Text = "LA BREWETTE PAYMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Review and complete your payment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbPaymentDetails
            // 
            this.gbPaymentDetails.Controls.Add(this.rbQRPay);
            this.gbPaymentDetails.Controls.Add(this.rbCard);
            this.gbPaymentDetails.Controls.Add(this.rbCash);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.gbPaymentDetails.Controls.Add(this.lblAmountToPay);
            this.gbPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentDetails.Location = new System.Drawing.Point(670, 200);
            this.gbPaymentDetails.Name = "gbPaymentDetails";
            this.gbPaymentDetails.Size = new System.Drawing.Size(504, 268);
            this.gbPaymentDetails.TabIndex = 20;
            this.gbPaymentDetails.TabStop = false;
            this.gbPaymentDetails.Text = "Payment Details";
            // 
            // rbQRPay
            // 
            this.rbQRPay.AutoSize = true;
            this.rbQRPay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQRPay.Location = new System.Drawing.Point(35, 206);
            this.rbQRPay.Name = "rbQRPay";
            this.rbQRPay.Size = new System.Drawing.Size(90, 29);
            this.rbQRPay.TabIndex = 4;
            this.rbQRPay.TabStop = true;
            this.rbQRPay.Text = "QR Pay";
            this.rbQRPay.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.Location = new System.Drawing.Point(35, 177);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(70, 29);
            this.rbCard.TabIndex = 3;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(35, 148);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(71, 29);
            this.rbCash.TabIndex = 2;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(30, 117);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(171, 28);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "Payment Method :";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(30, 57);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(153, 28);
            this.lblAmountToPay.TabIndex = 0;
            this.lblAmountToPay.Text = "Amount to pay :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(388, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 53);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(754, 567);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(199, 53);
            this.btnConfirmPayment.TabIndex = 23;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblTotalAmount);
            this.gbOrderSummary.Controls.Add(this.lblBasePrice);
            this.gbOrderSummary.Controls.Add(this.lblAddon);
            this.gbOrderSummary.Controls.Add(this.lblDrink);
            this.gbOrderSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(106, 200);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(548, 268);
            this.gbOrderSummary.TabIndex = 24;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(19, 207);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(139, 28);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount :";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(19, 167);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(107, 28);
            this.lblBasePrice.TabIndex = 2;
            this.lblBasePrice.Text = "Base Price :";
            // 
            // lblAddon
            // 
            this.lblAddon.Location = new System.Drawing.Point(19, 84);
            this.lblAddon.Name = "lblAddon";
            this.lblAddon.Size = new System.Drawing.Size(508, 83);
            this.lblAddon.TabIndex = 1;
            this.lblAddon.Text = "Add-On :                                                                         " +
    "           \r\n\r\n\r\n";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(19, 44);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(68, 28);
            this.lblDrink.TabIndex = 0;
            this.lblDrink.Text = "Drink :";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbPaymentDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPaymentDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.gbPaymentDetails.ResumeLayout(false);
            this.gbPaymentDetails.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.RadioButton rbQRPay;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.GroupBox gbPaymentDetails;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblAddon;
        private System.Windows.Forms.Label lblDrink;
    }
}