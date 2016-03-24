namespace Specials
{
    partial class frmModify
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
            System.Windows.Forms.Label saleIdLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label sale_PriceLabel;
            System.Windows.Forms.Label original_PriceLabel;
            System.Windows.Forms.Label store_NameLabel;
            System.Windows.Forms.Label expiration_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModify));
            this.saleItemsDataSet = new Specials.saleItemsDataSet();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new Specials.saleItemsDataSetTableAdapters.SaleTableAdapter();
            this.tableAdapterManager = new Specials.saleItemsDataSetTableAdapters.TableAdapterManager();
            this.saleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errProviderSale = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderOriginal = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderSaleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderStoreName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderExpire = new System.Windows.Forms.ErrorProvider(this.components);
            this.editNavigator = new System.Windows.Forms.ToolStripButton();
            saleIdLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            sale_PriceLabel = new System.Windows.Forms.Label();
            original_PriceLabel = new System.Windows.Forms.Label();
            store_NameLabel = new System.Windows.Forms.Label();
            expiration_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingNavigator)).BeginInit();
            this.saleBindingNavigator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderSaleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderStoreName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderExpire)).BeginInit();
            this.SuspendLayout();
            // 
            // saleIdLabel
            // 
            saleIdLabel.AutoSize = true;
            saleIdLabel.Location = new System.Drawing.Point(36, 137);
            saleIdLabel.Name = "saleIdLabel";
            saleIdLabel.Size = new System.Drawing.Size(43, 13);
            saleIdLabel.TabIndex = 1;
            saleIdLabel.Text = "Sale Id:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(36, 163);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 3;
            product_NameLabel.Text = "Product Name:";
            // 
            // sale_PriceLabel
            // 
            sale_PriceLabel.AutoSize = true;
            sale_PriceLabel.Location = new System.Drawing.Point(36, 189);
            sale_PriceLabel.Name = "sale_PriceLabel";
            sale_PriceLabel.Size = new System.Drawing.Size(58, 13);
            sale_PriceLabel.TabIndex = 5;
            sale_PriceLabel.Text = "Sale Price:";
            // 
            // original_PriceLabel
            // 
            original_PriceLabel.AutoSize = true;
            original_PriceLabel.Location = new System.Drawing.Point(36, 215);
            original_PriceLabel.Name = "original_PriceLabel";
            original_PriceLabel.Size = new System.Drawing.Size(72, 13);
            original_PriceLabel.TabIndex = 7;
            original_PriceLabel.Text = "Original Price:";
            // 
            // store_NameLabel
            // 
            store_NameLabel.AutoSize = true;
            store_NameLabel.Location = new System.Drawing.Point(36, 241);
            store_NameLabel.Name = "store_NameLabel";
            store_NameLabel.Size = new System.Drawing.Size(66, 13);
            store_NameLabel.TabIndex = 9;
            store_NameLabel.Text = "Store Name:";
            // 
            // expiration_DateLabel
            // 
            expiration_DateLabel.AutoSize = true;
            expiration_DateLabel.Location = new System.Drawing.Point(36, 268);
            expiration_DateLabel.Name = "expiration_DateLabel";
            expiration_DateLabel.Size = new System.Drawing.Size(82, 13);
            expiration_DateLabel.TabIndex = 11;
            expiration_DateLabel.Text = "Expiration Date:";
            // 
            // saleItemsDataSet
            // 
            this.saleItemsDataSet.DataSetName = "saleItemsDataSet";
            this.saleItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.saleItemsDataSet;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SaleTableAdapter = this.saleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Specials.saleItemsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saleBindingNavigator
            // 
            this.saleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.saleBindingNavigator.BindingSource = this.saleBindingSource;
            this.saleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.saleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.saleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saleBindingNavigatorSaveItem,
            this.editNavigator});
            this.saleBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.saleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.saleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.saleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.saleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.saleBindingNavigator.Name = "saleBindingNavigator";
            this.saleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.saleBindingNavigator.Size = new System.Drawing.Size(414, 25);
            this.saleBindingNavigator.TabIndex = 0;
            this.saleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.MouseEnter += new System.EventHandler(this.bindingNavigatorDeleteItem_MouseEnter);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saleBindingNavigatorSaveItem
            // 
            this.saleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("saleBindingNavigatorSaveItem.Image")));
            this.saleBindingNavigatorSaveItem.Name = "saleBindingNavigatorSaveItem";
            this.saleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.saleBindingNavigatorSaveItem.Text = "Save Data";
            this.saleBindingNavigatorSaveItem.Click += new System.EventHandler(this.saleBindingNavigatorSaveItem_Click);
            // 
            // txtSaleId
            // 
            this.txtSaleId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "SaleId", true));
            this.txtSaleId.Enabled = false;
            this.txtSaleId.Location = new System.Drawing.Point(124, 134);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(200, 20);
            this.txtSaleId.TabIndex = 2;
            this.txtSaleId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleId_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Product Name", true));
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(124, 160);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Sale Price", true));
            this.txtSalePrice.Enabled = false;
            this.txtSalePrice.Location = new System.Drawing.Point(124, 186);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Original Price", true));
            this.txtOriginalPrice.Enabled = false;
            this.txtOriginalPrice.Location = new System.Drawing.Point(124, 212);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtOriginalPrice.TabIndex = 8;
            this.txtOriginalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginalPrice_KeyPress);
            // 
            // txtStoreName
            // 
            this.txtStoreName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Store Name", true));
            this.txtStoreName.Enabled = false;
            this.txtStoreName.Location = new System.Drawing.Point(124, 238);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(200, 20);
            this.txtStoreName.TabIndex = 10;
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.saleBindingSource, "Expiration Date", true));
            this.dtpExpiration.Enabled = false;
            this.dtpExpiration.Location = new System.Drawing.Point(124, 264);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(200, 20);
            this.dtpExpiration.TabIndex = 12;
            this.dtpExpiration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpExpiration_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Arrow through the sales to remove or modify.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add sales by clicking the plus button.  Remove sales by clicking the X button.";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(68, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.viewSalesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewSalesToolStripMenuItem.Text = "View Specials";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Save when making changes.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // errProviderSale
            // 
            this.errProviderSale.ContainerControl = this;
            // 
            // errProviderOriginal
            // 
            this.errProviderOriginal.ContainerControl = this;
            // 
            // errProviderSaleID
            // 
            this.errProviderSaleID.ContainerControl = this;
            // 
            // errProviderProductName
            // 
            this.errProviderProductName.ContainerControl = this;
            // 
            // errProviderStoreName
            // 
            this.errProviderStoreName.ContainerControl = this;
            // 
            // errProviderExpire
            // 
            this.errProviderExpire.ContainerControl = this;
            // 
            // editNavigator
            // 
            this.editNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editNavigator.Image = global::Specials.Properties.Resources.sites_pencil_icon_small;
            this.editNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editNavigator.Name = "editNavigator";
            this.editNavigator.Size = new System.Drawing.Size(23, 22);
            this.editNavigator.Text = "Exit Data";
            this.editNavigator.Click += new System.EventHandler(this.editNavigator_Click);
            // 
            // frmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 395);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(saleIdLabel);
            this.Controls.Add(this.txtSaleId);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(sale_PriceLabel);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(original_PriceLabel);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(store_NameLabel);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(expiration_DateLabel);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.saleBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmModify";
            this.Text = "Modify Specials";
            this.Load += new System.EventHandler(this.frmModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingNavigator)).EndInit();
            this.saleBindingNavigator.ResumeLayout(false);
            this.saleBindingNavigator.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderSaleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderStoreName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderExpire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private saleItemsDataSet saleItemsDataSet;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private saleItemsDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private saleItemsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator saleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider errProviderSale;
        private System.Windows.Forms.ErrorProvider errProviderOriginal;
        private System.Windows.Forms.ErrorProvider errProviderSaleID;
        private System.Windows.Forms.ErrorProvider errProviderProductName;
        private System.Windows.Forms.ErrorProvider errProviderStoreName;
        private System.Windows.Forms.ErrorProvider errProviderExpire;
        private System.Windows.Forms.ToolStripButton editNavigator;
    }
}