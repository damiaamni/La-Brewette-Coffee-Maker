namespace Project_Edp
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnNonCoffee = new System.Windows.Forms.Button();
            this.gbSelectDrink = new System.Windows.Forms.GroupBox();
            this.rdCappuccino = new System.Windows.Forms.RadioButton();
            this.rdLatte = new System.Windows.Forms.RadioButton();
            this.rdAmericano = new System.Windows.Forms.RadioButton();
            this.picDrink = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbAddOn = new System.Windows.Forms.GroupBox();
            this.cbExtraIce = new System.Windows.Forms.CheckBox();
            this.cbExtraSugar = new System.Windows.Forms.CheckBox();
            this.cbWhippedCream = new System.Windows.Forms.CheckBox();
            this.cbCaramelSyrup = new System.Windows.Forms.CheckBox();
            this.cbChocSyrup = new System.Windows.Forms.CheckBox();
            this.cbExtraMilk = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSelectedDrink = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSelectDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrink)).BeginInit();
            this.gbAddOn.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(456, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LA BREWETTE MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCoffee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCoffee.Location = new System.Drawing.Point(28, 126);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(117, 35);
            this.btnCoffee.TabIndex = 2;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnTea
            // 
            this.btnTea.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTea.ForeColor = System.Drawing.Color.White;
            this.btnTea.Location = new System.Drawing.Point(163, 126);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(117, 35);
            this.btnTea.TabIndex = 3;
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = false;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnNonCoffee
            // 
            this.btnNonCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNonCoffee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonCoffee.ForeColor = System.Drawing.Color.White;
            this.btnNonCoffee.Location = new System.Drawing.Point(298, 126);
            this.btnNonCoffee.Name = "btnNonCoffee";
            this.btnNonCoffee.Size = new System.Drawing.Size(140, 35);
            this.btnNonCoffee.TabIndex = 4;
            this.btnNonCoffee.Text = "Non-Coffee";
            this.btnNonCoffee.UseVisualStyleBackColor = false;
            this.btnNonCoffee.Click += new System.EventHandler(this.btnNonCoffee_Click);
            // 
            // gbSelectDrink
            // 
            this.gbSelectDrink.Controls.Add(this.rdCappuccino);
            this.gbSelectDrink.Controls.Add(this.rdLatte);
            this.gbSelectDrink.Controls.Add(this.rdAmericano);
            this.gbSelectDrink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectDrink.Location = new System.Drawing.Point(397, 184);
            this.gbSelectDrink.Name = "gbSelectDrink";
            this.gbSelectDrink.Size = new System.Drawing.Size(315, 204);
            this.gbSelectDrink.TabIndex = 5;
            this.gbSelectDrink.TabStop = false;
            this.gbSelectDrink.Text = "Select Your Drink";
            // 
            // rdCappuccino
            // 
            this.rdCappuccino.AutoSize = true;
            this.rdCappuccino.Location = new System.Drawing.Point(25, 120);
            this.rdCappuccino.Name = "rdCappuccino";
            this.rdCappuccino.Size = new System.Drawing.Size(228, 32);
            this.rdCappuccino.TabIndex = 2;
            this.rdCappuccino.TabStop = true;
            this.rdCappuccino.Text = "Cappuccino     RM8.50";
            this.rdCappuccino.UseVisualStyleBackColor = true;
            this.rdCappuccino.CheckedChanged += new System.EventHandler(this.rdCappuccino_CheckedChanged);
            // 
            // rdLatte
            // 
            this.rdLatte.AutoSize = true;
            this.rdLatte.Location = new System.Drawing.Point(25, 82);
            this.rdLatte.Name = "rdLatte";
            this.rdLatte.Size = new System.Drawing.Size(233, 32);
            this.rdLatte.TabIndex = 1;
            this.rdLatte.TabStop = true;
            this.rdLatte.Text = "Latte                 RM8.00 ";
            this.rdLatte.UseVisualStyleBackColor = true;
            this.rdLatte.CheckedChanged += new System.EventHandler(this.rdLatte_CheckedChanged);
            // 
            // rdAmericano
            // 
            this.rdAmericano.AutoSize = true;
            this.rdAmericano.Location = new System.Drawing.Point(25, 44);
            this.rdAmericano.Name = "rdAmericano";
            this.rdAmericano.Size = new System.Drawing.Size(229, 32);
            this.rdAmericano.TabIndex = 0;
            this.rdAmericano.TabStop = true;
            this.rdAmericano.Text = "Americano       RM6.50\r\n";
            this.rdAmericano.UseVisualStyleBackColor = true;
            this.rdAmericano.CheckedChanged += new System.EventHandler(this.rdAmericano_CheckedChanged);
            // 
            // picDrink
            // 
            this.picDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrink.Location = new System.Drawing.Point(37, 184);
            this.picDrink.Name = "picDrink";
            this.picDrink.Size = new System.Drawing.Size(345, 279);
            this.picDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDrink.TabIndex = 6;
            this.picDrink.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Americano.png");
            this.imageList1.Images.SetKeyName(1, "Latte.png");
            this.imageList1.Images.SetKeyName(2, "Cappuccino.png");
            this.imageList1.Images.SetKeyName(3, "Milk Tea.png");
            this.imageList1.Images.SetKeyName(4, "Chocolate.png");
            // 
            // gbAddOn
            // 
            this.gbAddOn.Controls.Add(this.cbExtraIce);
            this.gbAddOn.Controls.Add(this.cbExtraSugar);
            this.gbAddOn.Controls.Add(this.cbWhippedCream);
            this.gbAddOn.Controls.Add(this.cbCaramelSyrup);
            this.gbAddOn.Controls.Add(this.cbChocSyrup);
            this.gbAddOn.Controls.Add(this.cbExtraMilk);
            this.gbAddOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddOn.Location = new System.Drawing.Point(728, 184);
            this.gbAddOn.Name = "gbAddOn";
            this.gbAddOn.Size = new System.Drawing.Size(346, 279);
            this.gbAddOn.TabIndex = 8;
            this.gbAddOn.TabStop = false;
            this.gbAddOn.Text = "Add-On";
            this.gbAddOn.Enter += new System.EventHandler(this.gbAddOn_Enter);
            // 
            // cbExtraIce
            // 
            this.cbExtraIce.AutoSize = true;
            this.cbExtraIce.Location = new System.Drawing.Point(31, 189);
            this.cbExtraIce.Name = "cbExtraIce";
            this.cbExtraIce.Size = new System.Drawing.Size(282, 32);
            this.cbExtraIce.TabIndex = 5;
            this.cbExtraIce.Text = "Extra Ice                   +RM0.30\r\n";
            this.cbExtraIce.UseVisualStyleBackColor = true;
            this.cbExtraIce.CheckedChanged += new System.EventHandler(this.cbExtraIce_CheckedChanged);
            // 
            // cbExtraSugar
            // 
            this.cbExtraSugar.AutoSize = true;
            this.cbExtraSugar.Location = new System.Drawing.Point(31, 160);
            this.cbExtraSugar.Name = "cbExtraSugar";
            this.cbExtraSugar.Size = new System.Drawing.Size(284, 32);
            this.cbExtraSugar.TabIndex = 4;
            this.cbExtraSugar.Text = "Extra Sugar              +RM0.50";
            this.cbExtraSugar.UseVisualStyleBackColor = true;
            this.cbExtraSugar.CheckedChanged += new System.EventHandler(this.cbExtraSugar_CheckedChanged);
            // 
            // cbWhippedCream
            // 
            this.cbWhippedCream.AutoSize = true;
            this.cbWhippedCream.Location = new System.Drawing.Point(31, 131);
            this.cbWhippedCream.Name = "cbWhippedCream";
            this.cbWhippedCream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbWhippedCream.Size = new System.Drawing.Size(282, 32);
            this.cbWhippedCream.TabIndex = 3;
            this.cbWhippedCream.Text = "Whipped Cream     +RM1.80\r\n";
            this.cbWhippedCream.UseVisualStyleBackColor = true;
            this.cbWhippedCream.CheckedChanged += new System.EventHandler(this.cbWhippedCream_CheckedChanged);
            // 
            // cbCaramelSyrup
            // 
            this.cbCaramelSyrup.AutoSize = true;
            this.cbCaramelSyrup.Location = new System.Drawing.Point(31, 102);
            this.cbCaramelSyrup.Name = "cbCaramelSyrup";
            this.cbCaramelSyrup.Size = new System.Drawing.Size(281, 32);
            this.cbCaramelSyrup.TabIndex = 2;
            this.cbCaramelSyrup.Text = "Caramel Syrup        +RM2.00\r\n";
            this.cbCaramelSyrup.UseVisualStyleBackColor = true;
            this.cbCaramelSyrup.CheckedChanged += new System.EventHandler(this.cbCaramelSyrup_CheckedChanged);
            // 
            // cbChocSyrup
            // 
            this.cbChocSyrup.AutoSize = true;
            this.cbChocSyrup.Location = new System.Drawing.Point(31, 74);
            this.cbChocSyrup.Name = "cbChocSyrup";
            this.cbChocSyrup.Size = new System.Drawing.Size(278, 32);
            this.cbChocSyrup.TabIndex = 1;
            this.cbChocSyrup.Text = "Chocolate Syrup    +RM2.00\r\n";
            this.cbChocSyrup.UseVisualStyleBackColor = true;
            this.cbChocSyrup.CheckedChanged += new System.EventHandler(this.cbChocSyrup_CheckedChanged);
            // 
            // cbExtraMilk
            // 
            this.cbExtraMilk.AutoSize = true;
            this.cbExtraMilk.Location = new System.Drawing.Point(31, 45);
            this.cbExtraMilk.Name = "cbExtraMilk";
            this.cbExtraMilk.Size = new System.Drawing.Size(276, 32);
            this.cbExtraMilk.TabIndex = 0;
            this.cbExtraMilk.Text = "Extra Milk               +RM1.50\r\n";
            this.cbExtraMilk.UseVisualStyleBackColor = true;
            this.cbExtraMilk.CheckedChanged += new System.EventHandler(this.cbExtraMilk_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(35, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total : RM0.00";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(757, 599);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(172, 53);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(349, 599);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(172, 53);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(557, 599);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 53);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(728, 473);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(258, 58);
            this.gbTotal.TabIndex = 15;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Order Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblSelectedDrink);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 96);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drink Information";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(124, 25);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price : RM6.50";
            // 
            // lblSelectedDrink
            // 
            this.lblSelectedDrink.AutoSize = true;
            this.lblSelectedDrink.Location = new System.Drawing.Point(6, 33);
            this.lblSelectedDrink.Name = "lblSelectedDrink";
            this.lblSelectedDrink.Size = new System.Drawing.Size(224, 25);
            this.lblSelectedDrink.TabIndex = 18;
            this.lblSelectedDrink.Text = "Selected Drink : Americano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose your drink and customize your order";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbAddOn);
            this.Controls.Add(this.picDrink);
            this.Controls.Add(this.gbSelectDrink);
            this.Controls.Add(this.btnNonCoffee);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.gbSelectDrink.ResumeLayout(false);
            this.gbSelectDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrink)).EndInit();
            this.gbAddOn.ResumeLayout(false);
            this.gbAddOn.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnNonCoffee;
        private System.Windows.Forms.GroupBox gbSelectDrink;
        private System.Windows.Forms.RadioButton rdCappuccino;
        private System.Windows.Forms.RadioButton rdLatte;
        private System.Windows.Forms.RadioButton rdAmericano;
        private System.Windows.Forms.PictureBox picDrink;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbAddOn;
        private System.Windows.Forms.CheckBox cbExtraIce;
        private System.Windows.Forms.CheckBox cbExtraSugar;
        private System.Windows.Forms.CheckBox cbWhippedCream;
        private System.Windows.Forms.CheckBox cbCaramelSyrup;
        private System.Windows.Forms.CheckBox cbChocSyrup;
        private System.Windows.Forms.CheckBox cbExtraMilk;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedDrink;
        private System.Windows.Forms.Label lblPrice;
    }
}