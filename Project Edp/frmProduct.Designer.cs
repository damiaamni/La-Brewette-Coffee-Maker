namespace Project_Edp
{
    partial class frmProduct
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchBase = new System.Windows.Forms.Button();
            this.txtBxSearchBase = new System.Windows.Forms.TextBox();
            this.btnClearBase = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxCategory = new System.Windows.Forms.TextBox();
            this.txtBxBasePrice = new System.Windows.Forms.TextBox();
            this.txtBxProductID = new System.Windows.Forms.TextBox();
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteBase = new System.Windows.Forms.Button();
            this.btnUpdateBase = new System.Windows.Forms.Button();
            this.btnAddBase = new System.Windows.Forms.Button();
            this.dgvBaseProduct = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Project_Edp.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchAddOn = new System.Windows.Forms.Button();
            this.txtBxSearchAddOn = new System.Windows.Forms.TextBox();
            this.btnClearAddOn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearchAddOn = new System.Windows.Forms.Label();
            this.txtBxAddOnPrice = new System.Windows.Forms.TextBox();
            this.txtBxAddOnID = new System.Windows.Forms.TextBox();
            this.txtBxAddOnName = new System.Windows.Forms.TextBox();
            this.txtBxType = new System.Windows.Forms.TextBox();
            this.txtBxIngredientID = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblIngredientID = new System.Windows.Forms.Label();
            this.lblAddOnPrice = new System.Windows.Forms.Label();
            this.lblAddOnName = new System.Windows.Forms.Label();
            this.lblAddOnID = new System.Windows.Forms.Label();
            this.btnDeleteAddOn = new System.Windows.Forms.Button();
            this.btnUpdateAddOn = new System.Windows.Forms.Button();
            this.btnAddAddOn = new System.Windows.Forms.Button();
            this.dgvAddOnProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baseProductTableAdapter = new Project_Edp.DataSet1TableAdapters.BaseProductTableAdapter();
            this.tableAdapterManager = new Project_Edp.DataSet1TableAdapters.TableAdapterManager();
            this.addOnTableAdapter = new Project_Edp.DataSet1TableAdapters.AddOnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOnProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Location = new System.Drawing.Point(11, 89);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 90);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(11, 185);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 90);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Location = new System.Drawing.Point(11, 281);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 90);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventory.Location = new System.Drawing.Point(11, 377);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 90);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecipe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecipe.Location = new System.Drawing.Point(11, 473);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(200, 90);
            this.btnRecipe.TabIndex = 4;
            this.btnRecipe.Text = "RECIPE";
            this.btnRecipe.UseVisualStyleBackColor = false;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.Location = new System.Drawing.Point(11, 569);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(200, 90);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Tan;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 591);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.btnSearchBase);
            this.tabPage1.Controls.Add(this.txtBxSearchBase);
            this.tabPage1.Controls.Add(this.btnClearBase);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtBxCategory);
            this.tabPage1.Controls.Add(this.txtBxBasePrice);
            this.tabPage1.Controls.Add(this.txtBxProductID);
            this.tabPage1.Controls.Add(this.txtBxProductName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnDeleteBase);
            this.tabPage1.Controls.Add(this.btnUpdateBase);
            this.tabPage1.Controls.Add(this.btnAddBase);
            this.tabPage1.Controls.Add(this.dgvBaseProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BASE PRODUCT";
            // 
            // btnSearchBase
            // 
            this.btnSearchBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchBase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchBase.Location = new System.Drawing.Point(418, 32);
            this.btnSearchBase.Name = "btnSearchBase";
            this.btnSearchBase.Size = new System.Drawing.Size(90, 35);
            this.btnSearchBase.TabIndex = 28;
            this.btnSearchBase.Text = "Search";
            this.btnSearchBase.UseVisualStyleBackColor = false;
            this.btnSearchBase.Click += new System.EventHandler(this.btnSearchBase_Click);
            // 
            // txtBxSearchBase
            // 
            this.txtBxSearchBase.Location = new System.Drawing.Point(212, 34);
            this.txtBxSearchBase.Name = "txtBxSearchBase";
            this.txtBxSearchBase.Size = new System.Drawing.Size(200, 30);
            this.txtBxSearchBase.TabIndex = 27;
            // 
            // btnClearBase
            // 
            this.btnClearBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearBase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearBase.Location = new System.Drawing.Point(514, 32);
            this.btnClearBase.Name = "btnClearBase";
            this.btnClearBase.Size = new System.Drawing.Size(90, 35);
            this.btnClearBase.TabIndex = 26;
            this.btnClearBase.Text = "Clear";
            this.btnClearBase.UseVisualStyleBackColor = false;
            this.btnClearBase.Click += new System.EventHandler(this.btnClearBase_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search Product:";
            // 
            // txtBxCategory
            // 
            this.txtBxCategory.Location = new System.Drawing.Point(753, 402);
            this.txtBxCategory.Name = "txtBxCategory";
            this.txtBxCategory.Size = new System.Drawing.Size(200, 30);
            this.txtBxCategory.TabIndex = 18;
            // 
            // txtBxBasePrice
            // 
            this.txtBxBasePrice.Location = new System.Drawing.Point(753, 338);
            this.txtBxBasePrice.Name = "txtBxBasePrice";
            this.txtBxBasePrice.Size = new System.Drawing.Size(200, 30);
            this.txtBxBasePrice.TabIndex = 17;
            // 
            // txtBxProductID
            // 
            this.txtBxProductID.Location = new System.Drawing.Point(380, 338);
            this.txtBxProductID.Name = "txtBxProductID";
            this.txtBxProductID.Size = new System.Drawing.Size(200, 30);
            this.txtBxProductID.TabIndex = 16;
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(380, 400);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(200, 30);
            this.txtBxProductName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Base Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product ID:";
            // 
            // btnDeleteBase
            // 
            this.btnDeleteBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteBase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteBase.Location = new System.Drawing.Point(58, 452);
            this.btnDeleteBase.Name = "btnDeleteBase";
            this.btnDeleteBase.Size = new System.Drawing.Size(130, 58);
            this.btnDeleteBase.TabIndex = 3;
            this.btnDeleteBase.Text = "DELETE";
            this.btnDeleteBase.UseVisualStyleBackColor = false;
            this.btnDeleteBase.Click += new System.EventHandler(this.btnDeleteBase_Click);
            // 
            // btnUpdateBase
            // 
            this.btnUpdateBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateBase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateBase.Location = new System.Drawing.Point(58, 388);
            this.btnUpdateBase.Name = "btnUpdateBase";
            this.btnUpdateBase.Size = new System.Drawing.Size(130, 58);
            this.btnUpdateBase.TabIndex = 2;
            this.btnUpdateBase.Text = "UPDATE";
            this.btnUpdateBase.UseVisualStyleBackColor = false;
            this.btnUpdateBase.Click += new System.EventHandler(this.btnUpdateBase_Click);
            // 
            // btnAddBase
            // 
            this.btnAddBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddBase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddBase.Location = new System.Drawing.Point(58, 324);
            this.btnAddBase.Name = "btnAddBase";
            this.btnAddBase.Size = new System.Drawing.Size(130, 58);
            this.btnAddBase.TabIndex = 1;
            this.btnAddBase.Text = "ADD";
            this.btnAddBase.UseVisualStyleBackColor = false;
            this.btnAddBase.Click += new System.EventHandler(this.btnAddBase_Click);
            // 
            // dgvBaseProduct
            // 
            this.dgvBaseProduct.AutoGenerateColumns = false;
            this.dgvBaseProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaseProduct.ColumnHeadersHeight = 40;
            this.dgvBaseProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.basepriceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dgvBaseProduct.DataSource = this.baseProductBindingSource;
            this.dgvBaseProduct.Location = new System.Drawing.Point(58, 97);
            this.dgvBaseProduct.Name = "dgvBaseProduct";
            this.dgvBaseProduct.RowHeadersWidth = 51;
            this.dgvBaseProduct.RowTemplate.Height = 24;
            this.dgvBaseProduct.Size = new System.Drawing.Size(900, 200);
            this.dgvBaseProduct.TabIndex = 0;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // basepriceDataGridViewTextBoxColumn
            // 
            this.basepriceDataGridViewTextBoxColumn.DataPropertyName = "baseprice";
            this.basepriceDataGridViewTextBoxColumn.HeaderText = "baseprice";
            this.basepriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basepriceDataGridViewTextBoxColumn.Name = "basepriceDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // baseProductBindingSource
            // 
            this.baseProductBindingSource.DataMember = "BaseProduct";
            this.baseProductBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.btnSearchAddOn);
            this.tabPage2.Controls.Add(this.txtBxSearchAddOn);
            this.tabPage2.Controls.Add(this.btnClearAddOn);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.lblSearchAddOn);
            this.tabPage2.Controls.Add(this.txtBxAddOnPrice);
            this.tabPage2.Controls.Add(this.txtBxAddOnID);
            this.tabPage2.Controls.Add(this.txtBxAddOnName);
            this.tabPage2.Controls.Add(this.txtBxType);
            this.tabPage2.Controls.Add(this.txtBxIngredientID);
            this.tabPage2.Controls.Add(this.lblType);
            this.tabPage2.Controls.Add(this.lblIngredientID);
            this.tabPage2.Controls.Add(this.lblAddOnPrice);
            this.tabPage2.Controls.Add(this.lblAddOnName);
            this.tabPage2.Controls.Add(this.lblAddOnID);
            this.tabPage2.Controls.Add(this.btnDeleteAddOn);
            this.tabPage2.Controls.Add(this.btnUpdateAddOn);
            this.tabPage2.Controls.Add(this.btnAddAddOn);
            this.tabPage2.Controls.Add(this.dgvAddOnProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD-ON PRODUCT";
            // 
            // btnSearchAddOn
            // 
            this.btnSearchAddOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchAddOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchAddOn.Location = new System.Drawing.Point(418, 32);
            this.btnSearchAddOn.Name = "btnSearchAddOn";
            this.btnSearchAddOn.Size = new System.Drawing.Size(90, 35);
            this.btnSearchAddOn.TabIndex = 30;
            this.btnSearchAddOn.Text = "Search";
            this.btnSearchAddOn.UseVisualStyleBackColor = false;
            this.btnSearchAddOn.Click += new System.EventHandler(this.btnSearchAddOn_Click);
            // 
            // txtBxSearchAddOn
            // 
            this.txtBxSearchAddOn.Location = new System.Drawing.Point(212, 34);
            this.txtBxSearchAddOn.Name = "txtBxSearchAddOn";
            this.txtBxSearchAddOn.Size = new System.Drawing.Size(200, 30);
            this.txtBxSearchAddOn.TabIndex = 24;
            // 
            // btnClearAddOn
            // 
            this.btnClearAddOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAddOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearAddOn.Location = new System.Drawing.Point(514, 32);
            this.btnClearAddOn.Name = "btnClearAddOn";
            this.btnClearAddOn.Size = new System.Drawing.Size(90, 35);
            this.btnClearAddOn.TabIndex = 29;
            this.btnClearAddOn.Text = "Clear";
            this.btnClearAddOn.UseVisualStyleBackColor = false;
            this.btnClearAddOn.Click += new System.EventHandler(this.btnClearAddOn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(0, 0);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblSearchAddOn
            // 
            this.lblSearchAddOn.AutoSize = true;
            this.lblSearchAddOn.Location = new System.Drawing.Point(53, 37);
            this.lblSearchAddOn.Name = "lblSearchAddOn";
            this.lblSearchAddOn.Size = new System.Drawing.Size(156, 25);
            this.lblSearchAddOn.TabIndex = 22;
            this.lblSearchAddOn.Text = "Search Add-On:";
            // 
            // txtBxAddOnPrice
            // 
            this.txtBxAddOnPrice.Location = new System.Drawing.Point(384, 466);
            this.txtBxAddOnPrice.Name = "txtBxAddOnPrice";
            this.txtBxAddOnPrice.Size = new System.Drawing.Size(200, 30);
            this.txtBxAddOnPrice.TabIndex = 21;
            // 
            // txtBxAddOnID
            // 
            this.txtBxAddOnID.Location = new System.Drawing.Point(384, 338);
            this.txtBxAddOnID.Name = "txtBxAddOnID";
            this.txtBxAddOnID.Size = new System.Drawing.Size(200, 30);
            this.txtBxAddOnID.TabIndex = 20;
            // 
            // txtBxAddOnName
            // 
            this.txtBxAddOnName.Location = new System.Drawing.Point(384, 400);
            this.txtBxAddOnName.Name = "txtBxAddOnName";
            this.txtBxAddOnName.Size = new System.Drawing.Size(200, 30);
            this.txtBxAddOnName.TabIndex = 19;
            // 
            // txtBxType
            // 
            this.txtBxType.Location = new System.Drawing.Point(758, 338);
            this.txtBxType.Name = "txtBxType";
            this.txtBxType.Size = new System.Drawing.Size(200, 30);
            this.txtBxType.TabIndex = 18;
            // 
            // txtBxIngredientID
            // 
            this.txtBxIngredientID.Location = new System.Drawing.Point(758, 400);
            this.txtBxIngredientID.Name = "txtBxIngredientID";
            this.txtBxIngredientID.Size = new System.Drawing.Size(200, 30);
            this.txtBxIngredientID.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(626, 341);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 25);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblIngredientID
            // 
            this.lblIngredientID.AutoSize = true;
            this.lblIngredientID.Location = new System.Drawing.Point(626, 405);
            this.lblIngredientID.Name = "lblIngredientID";
            this.lblIngredientID.Size = new System.Drawing.Size(128, 25);
            this.lblIngredientID.TabIndex = 10;
            this.lblIngredientID.Text = "Ingredient ID:";
            // 
            // lblAddOnPrice
            // 
            this.lblAddOnPrice.AutoSize = true;
            this.lblAddOnPrice.Location = new System.Drawing.Point(236, 469);
            this.lblAddOnPrice.Name = "lblAddOnPrice";
            this.lblAddOnPrice.Size = new System.Drawing.Size(137, 25);
            this.lblAddOnPrice.TabIndex = 9;
            this.lblAddOnPrice.Text = "Add-On Price:";
            // 
            // lblAddOnName
            // 
            this.lblAddOnName.AutoSize = true;
            this.lblAddOnName.Location = new System.Drawing.Point(236, 405);
            this.lblAddOnName.Name = "lblAddOnName";
            this.lblAddOnName.Size = new System.Drawing.Size(145, 25);
            this.lblAddOnName.TabIndex = 8;
            this.lblAddOnName.Text = "Add-On Name:";
            // 
            // lblAddOnID
            // 
            this.lblAddOnID.AutoSize = true;
            this.lblAddOnID.Location = new System.Drawing.Point(236, 341);
            this.lblAddOnID.Name = "lblAddOnID";
            this.lblAddOnID.Size = new System.Drawing.Size(112, 25);
            this.lblAddOnID.TabIndex = 7;
            this.lblAddOnID.Text = "Add-On ID:";
            // 
            // btnDeleteAddOn
            // 
            this.btnDeleteAddOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteAddOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAddOn.Location = new System.Drawing.Point(58, 452);
            this.btnDeleteAddOn.Name = "btnDeleteAddOn";
            this.btnDeleteAddOn.Size = new System.Drawing.Size(130, 58);
            this.btnDeleteAddOn.TabIndex = 6;
            this.btnDeleteAddOn.Text = "DELETE";
            this.btnDeleteAddOn.UseVisualStyleBackColor = false;
            this.btnDeleteAddOn.Click += new System.EventHandler(this.btnDeleteAddOn_Click);
            // 
            // btnUpdateAddOn
            // 
            this.btnUpdateAddOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateAddOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAddOn.Location = new System.Drawing.Point(58, 388);
            this.btnUpdateAddOn.Name = "btnUpdateAddOn";
            this.btnUpdateAddOn.Size = new System.Drawing.Size(130, 58);
            this.btnUpdateAddOn.TabIndex = 5;
            this.btnUpdateAddOn.Text = "UPDATE";
            this.btnUpdateAddOn.UseVisualStyleBackColor = false;
            this.btnUpdateAddOn.Click += new System.EventHandler(this.btnUpdateAddOn_Click);
            // 
            // btnAddAddOn
            // 
            this.btnAddAddOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddAddOn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAddOn.Location = new System.Drawing.Point(58, 324);
            this.btnAddAddOn.Name = "btnAddAddOn";
            this.btnAddAddOn.Size = new System.Drawing.Size(130, 58);
            this.btnAddAddOn.TabIndex = 4;
            this.btnAddAddOn.Text = "ADD";
            this.btnAddAddOn.UseVisualStyleBackColor = false;
            this.btnAddAddOn.Click += new System.EventHandler(this.btnAddAddOn_Click);
            // 
            // dgvAddOnProduct
            // 
            this.dgvAddOnProduct.AutoGenerateColumns = false;
            this.dgvAddOnProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddOnProduct.ColumnHeadersHeight = 40;
            this.dgvAddOnProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvAddOnProduct.DataSource = this.addOnBindingSource;
            this.dgvAddOnProduct.Location = new System.Drawing.Point(58, 97);
            this.dgvAddOnProduct.Name = "dgvAddOnProduct";
            this.dgvAddOnProduct.RowHeadersWidth = 51;
            this.dgvAddOnProduct.RowTemplate.Height = 24;
            this.dgvAddOnProduct.Size = new System.Drawing.Size(900, 200);
            this.dgvAddOnProduct.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "addonid";
            this.dataGridViewTextBoxColumn5.HeaderText = "addonid";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn7.HeaderText = "price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn8.HeaderText = "type";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ingredientid";
            this.dataGridViewTextBoxColumn9.HeaderText = "ingredientid";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // addOnBindingSource
            // 
            this.addOnBindingSource.DataMember = "AddOn";
            this.addOnBindingSource.DataSource = this.dataSet1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
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
            this.splitContainer2.TabIndex = 7;
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
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCT MANAGEMENT";
            // 
            // baseProductTableAdapter
            // 
            this.baseProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddOnTableAdapter = this.addOnTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseProductTableAdapter = this.baseProductTableAdapter;
            this.tableAdapterManager.CustomTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.RecipeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Edp.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addOnTableAdapter
            // 
            this.addOnTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduct
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
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOnProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOnBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource baseProductBindingSource;
        private DataSet1TableAdapters.BaseProductTableAdapter baseProductTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvBaseProduct;
        private DataSet1TableAdapters.AddOnTableAdapter addOnTableAdapter;
        private System.Windows.Forms.BindingSource addOnBindingSource;
        private System.Windows.Forms.DataGridView dgvAddOnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnDeleteBase;
        private System.Windows.Forms.Button btnUpdateBase;
        private System.Windows.Forms.Button btnAddBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIngredientID;
        private System.Windows.Forms.Label lblAddOnPrice;
        private System.Windows.Forms.Label lblAddOnName;
        private System.Windows.Forms.Label lblAddOnID;
        private System.Windows.Forms.Button btnDeleteAddOn;
        private System.Windows.Forms.Button btnUpdateAddOn;
        private System.Windows.Forms.Button btnAddAddOn;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBxCategory;
        private System.Windows.Forms.TextBox txtBxBasePrice;
        private System.Windows.Forms.TextBox txtBxProductID;
        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.TextBox txtBxType;
        private System.Windows.Forms.TextBox txtBxIngredientID;
        private System.Windows.Forms.TextBox txtBxAddOnPrice;
        private System.Windows.Forms.TextBox txtBxAddOnID;
        private System.Windows.Forms.TextBox txtBxAddOnName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearchAddOn;
        private System.Windows.Forms.TextBox txtBxSearchAddOn;
        private System.Windows.Forms.TextBox txtBxSearchBase;
        private System.Windows.Forms.Button btnClearBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearchBase;
        private System.Windows.Forms.Button btnSearchAddOn;
        private System.Windows.Forms.Button btnClearAddOn;
    }
}