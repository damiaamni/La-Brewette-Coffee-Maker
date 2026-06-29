namespace Project_Edp
{
    partial class frmPaymentRecord
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGroupPayment = new System.Windows.Forms.Button();
            this.lblPaymentSummary = new System.Windows.Forms.Label();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            this.btnClearPayment = new System.Windows.Forms.Button();
            this.txtBxAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDatabaseDataSet2 = new Project_Edp.CoffeeDatabaseDataSet2();
            this.txtBxSearchPayment = new System.Windows.Forms.TextBox();
            this.lblSearchPayment = new System.Windows.Forms.Label();
            this.txtBxOrderID = new System.Windows.Forms.TextBox();
            this.txtBxPaymentStatus = new System.Windows.Forms.TextBox();
            this.txtBxPaymentID = new System.Windows.Forms.TextBox();
            this.txtBxPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.paymentTableAdapter1 = new Project_Edp.CoffeeDatabaseDataSet2TableAdapters.PaymentTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Project_Edp.DataSet1();
            this.paymentTableAdapter = new Project_Edp.DataSet1TableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new Project_Edp.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Panel2.Controls.Add(this.btnLogout);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(1257, 73);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN AS STAFF";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "PAYMENT MANAGEMENT";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.Location = new System.Drawing.Point(11, 570);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(200, 90);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecipe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecipe.Location = new System.Drawing.Point(11, 474);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(200, 90);
            this.btnRecipe.TabIndex = 12;
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
            this.btnInventory.TabIndex = 11;
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
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(11, 186);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 90);
            this.btnOrder.TabIndex = 9;
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
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.btnGroupPayment);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaymentSummary);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchPayment);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearPayment);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxAmountPaid);
            this.splitContainer1.Panel2.Controls.Add(this.lblAmountPaid);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPayment);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxSearchPayment);
            this.splitContainer1.Panel2.Controls.Add(this.lblSearchPayment);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxOrderID);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxPaymentStatus);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxPaymentID);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxPaymentMethod);
            this.splitContainer1.Panel2.Controls.Add(this.lblOrderID);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaymentStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaymentMethod);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaymentID);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 591);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 14;
            // 
            // btnGroupPayment
            // 
            this.btnGroupPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGroupPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGroupPayment.Location = new System.Drawing.Point(628, 82);
            this.btnGroupPayment.Name = "btnGroupPayment";
            this.btnGroupPayment.Size = new System.Drawing.Size(307, 35);
            this.btnGroupPayment.TabIndex = 51;
            this.btnGroupPayment.Text = "Group: Payment Method (A-Z)";
            this.btnGroupPayment.UseVisualStyleBackColor = false;
            this.btnGroupPayment.Click += new System.EventHandler(this.btnGroupPayment_Click_1);
            // 
            // lblPaymentSummary
            // 
            this.lblPaymentSummary.AutoSize = true;
            this.lblPaymentSummary.Location = new System.Drawing.Point(65, 28);
            this.lblPaymentSummary.Name = "lblPaymentSummary";
            this.lblPaymentSummary.Size = new System.Drawing.Size(178, 25);
            this.lblPaymentSummary.TabIndex = 49;
            this.lblPaymentSummary.Text = "Loading analytics...";
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchPayment.Location = new System.Drawing.Point(436, 82);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(90, 35);
            this.btnSearchPayment.TabIndex = 48;
            this.btnSearchPayment.Text = "Search";
            this.btnSearchPayment.UseVisualStyleBackColor = false;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // btnClearPayment
            // 
            this.btnClearPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearPayment.Location = new System.Drawing.Point(532, 82);
            this.btnClearPayment.Name = "btnClearPayment";
            this.btnClearPayment.Size = new System.Drawing.Size(90, 35);
            this.btnClearPayment.TabIndex = 47;
            this.btnClearPayment.Text = "Clear";
            this.btnClearPayment.UseVisualStyleBackColor = false;
            this.btnClearPayment.Click += new System.EventHandler(this.btnClearPayment_Click);
            // 
            // txtBxAmountPaid
            // 
            this.txtBxAmountPaid.Location = new System.Drawing.Point(770, 386);
            this.txtBxAmountPaid.Name = "txtBxAmountPaid";
            this.txtBxAmountPaid.Size = new System.Drawing.Size(200, 30);
            this.txtBxAmountPaid.TabIndex = 46;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(634, 389);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(130, 25);
            this.lblAmountPaid.TabIndex = 45;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeight = 40;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPayment.DataSource = this.paymentBindingSource1;
            this.dgvPayment.Location = new System.Drawing.Point(70, 147);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(900, 200);
            this.dgvPayment.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "paymentid";
            this.dataGridViewTextBoxColumn1.HeaderText = "paymentid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "paymentmethod";
            this.dataGridViewTextBoxColumn2.HeaderText = "paymentmethod";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amountpaid";
            this.dataGridViewTextBoxColumn3.HeaderText = "amountpaid";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "paymentstatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "paymentstatus";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "orderid";
            this.dataGridViewTextBoxColumn5.HeaderText = "orderid";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.coffeeDatabaseDataSet2;
            // 
            // coffeeDatabaseDataSet2
            // 
            this.coffeeDatabaseDataSet2.DataSetName = "CoffeeDatabaseDataSet2";
            this.coffeeDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBxSearchPayment
            // 
            this.txtBxSearchPayment.Location = new System.Drawing.Point(230, 84);
            this.txtBxSearchPayment.Name = "txtBxSearchPayment";
            this.txtBxSearchPayment.Size = new System.Drawing.Size(200, 30);
            this.txtBxSearchPayment.TabIndex = 43;
            // 
            // lblSearchPayment
            // 
            this.lblSearchPayment.AutoSize = true;
            this.lblSearchPayment.Location = new System.Drawing.Point(65, 87);
            this.lblSearchPayment.Name = "lblSearchPayment";
            this.lblSearchPayment.Size = new System.Drawing.Size(163, 25);
            this.lblSearchPayment.TabIndex = 41;
            this.lblSearchPayment.Text = "Search Payment:";
            // 
            // txtBxOrderID
            // 
            this.txtBxOrderID.Location = new System.Drawing.Point(770, 448);
            this.txtBxOrderID.Name = "txtBxOrderID";
            this.txtBxOrderID.Size = new System.Drawing.Size(200, 30);
            this.txtBxOrderID.TabIndex = 40;
            // 
            // txtBxPaymentStatus
            // 
            this.txtBxPaymentStatus.Location = new System.Drawing.Point(397, 516);
            this.txtBxPaymentStatus.Name = "txtBxPaymentStatus";
            this.txtBxPaymentStatus.Size = new System.Drawing.Size(200, 30);
            this.txtBxPaymentStatus.TabIndex = 39;
            // 
            // txtBxPaymentID
            // 
            this.txtBxPaymentID.Location = new System.Drawing.Point(397, 386);
            this.txtBxPaymentID.Name = "txtBxPaymentID";
            this.txtBxPaymentID.Size = new System.Drawing.Size(200, 30);
            this.txtBxPaymentID.TabIndex = 38;
            // 
            // txtBxPaymentMethod
            // 
            this.txtBxPaymentMethod.Location = new System.Drawing.Point(397, 450);
            this.txtBxPaymentMethod.Name = "txtBxPaymentMethod";
            this.txtBxPaymentMethod.Size = new System.Drawing.Size(200, 30);
            this.txtBxPaymentMethod.TabIndex = 37;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(634, 451);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(92, 25);
            this.lblOrderID.TabIndex = 36;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(225, 519);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(156, 25);
            this.lblPaymentStatus.TabIndex = 35;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(225, 453);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(166, 25);
            this.lblPaymentMethod.TabIndex = 34;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Location = new System.Drawing.Point(225, 389);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(119, 25);
            this.lblPaymentID.TabIndex = 33;
            this.lblPaymentID.Text = "Payment ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(70, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 58);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(70, 438);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(70, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 58);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddOnTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseProductTableAdapter = null;
            this.tableAdapterManager.CustomTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.RecipeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Edp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPaymentRecord
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
            this.Name = "frmPaymentRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentRecord";
            this.Load += new System.EventHandler(this.frmPaymentRecord_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private DataSet1TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtBxAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.TextBox txtBxSearchPayment;
        private System.Windows.Forms.Label lblSearchPayment;
        private System.Windows.Forms.TextBox txtBxOrderID;
        private System.Windows.Forms.TextBox txtBxPaymentStatus;
        private System.Windows.Forms.TextBox txtBxPaymentID;
        private System.Windows.Forms.TextBox txtBxPaymentMethod;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.Button btnClearPayment;
        private System.Windows.Forms.Label lblPaymentSummary;
        private System.Windows.Forms.Button btnGroupPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CoffeeDatabaseDataSet2 coffeeDatabaseDataSet2;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private CoffeeDatabaseDataSet2TableAdapters.PaymentTableAdapter paymentTableAdapter1;
    }
}