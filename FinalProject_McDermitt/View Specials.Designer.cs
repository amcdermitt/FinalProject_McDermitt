namespace Specials
{
    partial class frmSpecials
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
            System.Windows.Forms.Label sale_PriceLabel;
            System.Windows.Forms.Label original_PriceLabel;
            System.Windows.Forms.Label store_NameLabel;
            System.Windows.Forms.Label expiration_DateLabel;
            this.lstProductName = new System.Windows.Forms.ListBox();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleItemsDataSet = new Specials.saleItemsDataSet();
            this.saleTableAdapter = new Specials.saleItemsDataSetTableAdapters.SaleTableAdapter();
            this.tableAdapterManager = new Specials.saleItemsDataSetTableAdapters.TableAdapterManager();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifySpecialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTax = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errProviderExpire = new System.Windows.Forms.ErrorProvider(this.components);
            sale_PriceLabel = new System.Windows.Forms.Label();
            original_PriceLabel = new System.Windows.Forms.Label();
            store_NameLabel = new System.Windows.Forms.Label();
            expiration_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpView.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpTax.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderExpire)).BeginInit();
            this.SuspendLayout();
            // 
            // sale_PriceLabel
            // 
            sale_PriceLabel.AutoSize = true;
            sale_PriceLabel.Location = new System.Drawing.Point(177, 54);
            sale_PriceLabel.Name = "sale_PriceLabel";
            sale_PriceLabel.Size = new System.Drawing.Size(58, 13);
            sale_PriceLabel.TabIndex = 1;
            sale_PriceLabel.Text = "Sale Price:";
            // 
            // original_PriceLabel
            // 
            original_PriceLabel.AutoSize = true;
            original_PriceLabel.Location = new System.Drawing.Point(165, 88);
            original_PriceLabel.Name = "original_PriceLabel";
            original_PriceLabel.Size = new System.Drawing.Size(72, 13);
            original_PriceLabel.TabIndex = 3;
            original_PriceLabel.Text = "Original Price:";
            // 
            // store_NameLabel
            // 
            store_NameLabel.AutoSize = true;
            store_NameLabel.Location = new System.Drawing.Point(171, 123);
            store_NameLabel.Name = "store_NameLabel";
            store_NameLabel.Size = new System.Drawing.Size(66, 13);
            store_NameLabel.TabIndex = 5;
            store_NameLabel.Text = "Store Name:";
            // 
            // expiration_DateLabel
            // 
            expiration_DateLabel.AutoSize = true;
            expiration_DateLabel.Location = new System.Drawing.Point(153, 157);
            expiration_DateLabel.Name = "expiration_DateLabel";
            expiration_DateLabel.Size = new System.Drawing.Size(82, 13);
            expiration_DateLabel.TabIndex = 7;
            expiration_DateLabel.Text = "Expiration Date:";
            // 
            // lstProductName
            // 
            this.lstProductName.DataSource = this.saleBindingSource;
            this.lstProductName.DisplayMember = "Product Name";
            this.lstProductName.FormattingEnabled = true;
            this.lstProductName.Location = new System.Drawing.Point(17, 46);
            this.lstProductName.Name = "lstProductName";
            this.lstProductName.Size = new System.Drawing.Size(130, 134);
            this.lstProductName.TabIndex = 0;
            this.lstProductName.SelectedIndexChanged += new System.EventHandler(this.lstProductName_SelectedIndexChanged);
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.saleItemsDataSet;
            // 
            // saleItemsDataSet
            // 
            this.saleItemsDataSet.DataSetName = "saleItemsDataSet";
            this.saleItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblSalePrice
            // 
            this.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Sale Price", true));
            this.lblSalePrice.Location = new System.Drawing.Point(243, 49);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(110, 23);
            this.lblSalePrice.TabIndex = 2;
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalePrice.Click += new System.EventHandler(this.lblSalePrice_Click);
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOriginalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Original Price", true));
            this.lblOriginalPrice.Location = new System.Drawing.Point(243, 83);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(110, 23);
            this.lblOriginalPrice.TabIndex = 4;
            this.lblOriginalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreName
            // 
            this.lblStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStoreName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Store Name", true));
            this.lblStoreName.Location = new System.Drawing.Point(243, 118);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(110, 23);
            this.lblStoreName.TabIndex = 6;
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpiration
            // 
            this.lblExpiration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpiration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Expiration Date", true));
            this.lblExpiration.Location = new System.Drawing.Point(243, 152);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(110, 23);
            this.lblExpiration.TabIndex = 8;
            this.lblExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(416, 289);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
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
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.modifySpecialsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // modifySpecialsToolStripMenuItem
            // 
            this.modifySpecialsToolStripMenuItem.Name = "modifySpecialsToolStripMenuItem";
            this.modifySpecialsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modifySpecialsToolStripMenuItem.Text = "Modify Specials";
            this.modifySpecialsToolStripMenuItem.Click += new System.EventHandler(this.modifySpecialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(563, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a product to view information.";
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.label1);
            this.grpView.Controls.Add(this.lstProductName);
            this.grpView.Controls.Add(this.lblSalePrice);
            this.grpView.Controls.Add(sale_PriceLabel);
            this.grpView.Controls.Add(expiration_DateLabel);
            this.grpView.Controls.Add(this.lblOriginalPrice);
            this.grpView.Controls.Add(this.lblExpiration);
            this.grpView.Controls.Add(original_PriceLabel);
            this.grpView.Controls.Add(store_NameLabel);
            this.grpView.Controls.Add(this.lblStoreName);
            this.grpView.Location = new System.Drawing.Point(12, 27);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(388, 217);
            this.grpView.TabIndex = 13;
            this.grpView.TabStop = false;
            this.grpView.Text = "View Specials";
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Location = new System.Drawing.Point(393, 15);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(91, 17);
            this.chkReport.TabIndex = 14;
            this.chkReport.Text = "Filter By Store";
            this.chkReport.UseVisualStyleBackColor = true;
            this.chkReport.CheckedChanged += new System.EventHandler(this.chkReport_CheckedChanged);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.label6);
            this.grpReport.Controls.Add(this.btnClear);
            this.grpReport.Controls.Add(this.btnTotal);
            this.grpReport.Controls.Add(this.grpFilter);
            this.grpReport.Controls.Add(this.btnReport);
            this.grpReport.Controls.Add(this.lblCost);
            this.grpReport.Controls.Add(this.chkReport);
            this.grpReport.Controls.Add(this.label4);
            this.grpReport.Controls.Add(this.grpTax);
            this.grpReport.Controls.Add(this.label3);
            this.grpReport.Controls.Add(this.label2);
            this.grpReport.Controls.Add(this.lstItems);
            this.grpReport.Location = new System.Drawing.Point(430, 27);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(549, 246);
            this.grpReport.TabIndex = 15;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Note: Expired items not displyed.";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(52, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(255, 217);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 16;
            this.btnTotal.Text = "View Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.lstFilter);
            this.grpFilter.Enabled = false;
            this.grpFilter.Location = new System.Drawing.Point(370, 38);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(159, 161);
            this.grpFilter.TabIndex = 15;
            this.grpFilter.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(39, 132);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select Stores to filter by:";
            // 
            // lstFilter
            // 
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.Location = new System.Drawing.Point(6, 32);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFilter.Size = new System.Drawing.Size(138, 95);
            this.lstFilter.TabIndex = 16;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(403, 217);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Create Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Location = new System.Drawing.Point(233, 147);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(113, 23);
            this.lblCost.TabIndex = 5;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost of Selected Items:";
            // 
            // grpTax
            // 
            this.grpTax.Controls.Add(this.radNo);
            this.grpTax.Controls.Add(this.radYes);
            this.grpTax.Location = new System.Drawing.Point(255, 36);
            this.grpTax.Name = "grpTax";
            this.grpTax.Size = new System.Drawing.Size(77, 75);
            this.grpTax.TabIndex = 3;
            this.grpTax.TabStop = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(19, 43);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Location = new System.Drawing.Point(19, 19);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Include Sales Tax of 7%:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select items you would like a report on.";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(20, 36);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstItems.Size = new System.Drawing.Size(138, 134);
            this.lstItems.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(991, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // errProviderExpire
            // 
            this.errProviderExpire.ContainerControl = this;
            // 
            // frmSpecials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSpecials";
            this.Text = "View Specials";
            this.Load += new System.EventHandler(this.View_Specials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemsDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpTax.ResumeLayout(false);
            this.grpTax.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderExpire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductName;
        private saleItemsDataSet saleItemsDataSet;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private saleItemsDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private saleItemsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifySpecialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpTax;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstFilter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errProviderExpire;
    }
}