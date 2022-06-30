﻿namespace Capstone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnBackupArch = new System.Windows.Forms.Button();
            this.dropPanelSales = new System.Windows.Forms.Panel();
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.dropBtnSales = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStockDel = new System.Windows.Forms.Button();
            this.dropPanelProducts = new System.Windows.Forms.Panel();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.dropBtnProducts = new System.Windows.Forms.Button();
            this.btnTranscHist = new System.Windows.Forms.Button();
            this.dropPanelPayment = new System.Windows.Forms.Panel();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnPayStatus = new System.Windows.Forms.Button();
            this.dropBtnPayment = new System.Windows.Forms.Button();
            this.btnPatientR = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDrpBtnProducts = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnPayment = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnSales = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.dropPanelSales.SuspendLayout();
            this.dropPanelProducts.SuspendLayout();
            this.dropPanelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1798, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 948);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Controls.Add(this.btnUserSettings);
            this.panel4.Controls.Add(this.btnBackupArch);
            this.panel4.Controls.Add(this.dropPanelSales);
            this.panel4.Controls.Add(this.btnInventory);
            this.panel4.Controls.Add(this.btnStockDel);
            this.panel4.Controls.Add(this.dropPanelProducts);
            this.panel4.Controls.Add(this.btnTranscHist);
            this.panel4.Controls.Add(this.dropPanelPayment);
            this.panel4.Controls.Add(this.btnPatientR);
            this.panel4.Controls.Add(this.btnDashboard);
            this.panel4.Location = new System.Drawing.Point(31, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 912);
            this.panel4.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Capstone.Properties.Resources.Log_out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 881);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(366, 52);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::Capstone.Properties.Resources.User_Settings;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.Location = new System.Drawing.Point(0, 829);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(366, 52);
            this.btnUserSettings.TabIndex = 16;
            this.btnUserSettings.Text = "UserSettings";
            this.btnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSettings.UseVisualStyleBackColor = false;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnBackupArch
            // 
            this.btnBackupArch.BackColor = System.Drawing.Color.Transparent;
            this.btnBackupArch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackupArch.FlatAppearance.BorderSize = 0;
            this.btnBackupArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupArch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackupArch.ForeColor = System.Drawing.Color.White;
            this.btnBackupArch.Image = global::Capstone.Properties.Resources.Back_up;
            this.btnBackupArch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupArch.Location = new System.Drawing.Point(0, 777);
            this.btnBackupArch.Name = "btnBackupArch";
            this.btnBackupArch.Size = new System.Drawing.Size(366, 52);
            this.btnBackupArch.TabIndex = 15;
            this.btnBackupArch.Text = "Backup and Archive";
            this.btnBackupArch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackupArch.UseVisualStyleBackColor = false;
            this.btnBackupArch.Click += new System.EventHandler(this.btnBackupArch_Click);
            // 
            // dropPanelSales
            // 
            this.dropPanelSales.Controls.Add(this.btnInventoryReport);
            this.dropPanelSales.Controls.Add(this.btnSalesReport);
            this.dropPanelSales.Controls.Add(this.dropBtnSales);
            this.dropPanelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelSales.Location = new System.Drawing.Point(0, 622);
            this.dropPanelSales.MaximumSize = new System.Drawing.Size(366, 155);
            this.dropPanelSales.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelSales.Name = "dropPanelSales";
            this.dropPanelSales.Size = new System.Drawing.Size(366, 155);
            this.dropPanelSales.TabIndex = 14;
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.BackColor = System.Drawing.Color.Transparent;
            this.btnInventoryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryReport.FlatAppearance.BorderSize = 0;
            this.btnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryReport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventoryReport.ForeColor = System.Drawing.Color.White;
            this.btnInventoryReport.Image = global::Capstone.Properties.Resources.Inventory;
            this.btnInventoryReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryReport.Location = new System.Drawing.Point(0, 104);
            this.btnInventoryReport.Name = "btnInventoryReport";
            this.btnInventoryReport.Size = new System.Drawing.Size(366, 52);
            this.btnInventoryReport.TabIndex = 2;
            this.btnInventoryReport.Text = "Inventory Report";
            this.btnInventoryReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventoryReport.UseVisualStyleBackColor = false;
            this.btnInventoryReport.Click += new System.EventHandler(this.btnInventoryReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.Image = global::Capstone.Properties.Resources.Sales;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 52);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(366, 52);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.button32_Click);
            // 
            // dropBtnSales
            // 
            this.dropBtnSales.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnSales.FlatAppearance.BorderSize = 0;
            this.dropBtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnSales.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnSales.ForeColor = System.Drawing.Color.White;
            this.dropBtnSales.Image = global::Capstone.Properties.Resources.Sales_Report;
            this.dropBtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnSales.Location = new System.Drawing.Point(0, 0);
            this.dropBtnSales.Name = "dropBtnSales";
            this.dropBtnSales.Size = new System.Drawing.Size(366, 52);
            this.dropBtnSales.TabIndex = 0;
            this.dropBtnSales.Text = "Sales and Inventory Report";
            this.dropBtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnSales.UseVisualStyleBackColor = false;
            this.dropBtnSales.Click += new System.EventHandler(this.dropBtnSales_Click_1);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::Capstone.Properties.Resources.inventoryMonitor;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 570);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(366, 52);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnStockDel
            // 
            this.btnStockDel.BackColor = System.Drawing.Color.Transparent;
            this.btnStockDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockDel.FlatAppearance.BorderSize = 0;
            this.btnStockDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockDel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStockDel.ForeColor = System.Drawing.Color.White;
            this.btnStockDel.Image = global::Capstone.Properties.Resources.Stock_Delivery;
            this.btnStockDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockDel.Location = new System.Drawing.Point(0, 518);
            this.btnStockDel.Name = "btnStockDel";
            this.btnStockDel.Size = new System.Drawing.Size(366, 52);
            this.btnStockDel.TabIndex = 12;
            this.btnStockDel.Text = "Stock Delivery";
            this.btnStockDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockDel.UseVisualStyleBackColor = false;
            this.btnStockDel.Click += new System.EventHandler(this.btnStockDel_Click);
            // 
            // dropPanelProducts
            // 
            this.dropPanelProducts.Controls.Add(this.btnServices);
            this.dropPanelProducts.Controls.Add(this.btnItems);
            this.dropPanelProducts.Controls.Add(this.btnProd);
            this.dropPanelProducts.Controls.Add(this.dropBtnProducts);
            this.dropPanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelProducts.Location = new System.Drawing.Point(0, 311);
            this.dropPanelProducts.MaximumSize = new System.Drawing.Size(366, 207);
            this.dropPanelProducts.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelProducts.Name = "dropPanelProducts";
            this.dropPanelProducts.Size = new System.Drawing.Size(366, 207);
            this.dropPanelProducts.TabIndex = 10;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Image = global::Capstone.Properties.Resources.Service;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(0, 156);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(366, 52);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Transparent;
            this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Image = global::Capstone.Properties.Resources.Items;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(0, 104);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(366, 52);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Items";
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.Transparent;
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.Image = global::Capstone.Properties.Resources.Products;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(0, 52);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(366, 52);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Products";
            this.btnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // dropBtnProducts
            // 
            this.dropBtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnProducts.FlatAppearance.BorderSize = 0;
            this.dropBtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnProducts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnProducts.ForeColor = System.Drawing.Color.White;
            this.dropBtnProducts.Image = global::Capstone.Properties.Resources.ProdItemServ;
            this.dropBtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnProducts.Location = new System.Drawing.Point(0, 0);
            this.dropBtnProducts.Name = "dropBtnProducts";
            this.dropBtnProducts.Size = new System.Drawing.Size(366, 52);
            this.dropBtnProducts.TabIndex = 0;
            this.dropBtnProducts.Text = "Product, Items, and Services";
            this.dropBtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnProducts.UseVisualStyleBackColor = false;
            this.dropBtnProducts.Click += new System.EventHandler(this.dropBtnProducts_Click_1);
            // 
            // btnTranscHist
            // 
            this.btnTranscHist.BackColor = System.Drawing.Color.Transparent;
            this.btnTranscHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTranscHist.FlatAppearance.BorderSize = 0;
            this.btnTranscHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranscHist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTranscHist.ForeColor = System.Drawing.Color.White;
            this.btnTranscHist.Image = global::Capstone.Properties.Resources.Transaction_History;
            this.btnTranscHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranscHist.Location = new System.Drawing.Point(0, 259);
            this.btnTranscHist.Name = "btnTranscHist";
            this.btnTranscHist.Size = new System.Drawing.Size(366, 52);
            this.btnTranscHist.TabIndex = 8;
            this.btnTranscHist.Text = "Transaction History";
            this.btnTranscHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTranscHist.UseVisualStyleBackColor = false;
            this.btnTranscHist.Click += new System.EventHandler(this.btnTranscHist_Click);
            // 
            // dropPanelPayment
            // 
            this.dropPanelPayment.Controls.Add(this.btnOrderStatus);
            this.dropPanelPayment.Controls.Add(this.btnPayStatus);
            this.dropPanelPayment.Controls.Add(this.dropBtnPayment);
            this.dropPanelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelPayment.Location = new System.Drawing.Point(0, 104);
            this.dropPanelPayment.MaximumSize = new System.Drawing.Size(366, 155);
            this.dropPanelPayment.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelPayment.Name = "dropPanelPayment";
            this.dropPanelPayment.Size = new System.Drawing.Size(366, 155);
            this.dropPanelPayment.TabIndex = 7;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderStatus.ForeColor = System.Drawing.Color.White;
            this.btnOrderStatus.Image = global::Capstone.Properties.Resources.orderStat;
            this.btnOrderStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderStatus.Location = new System.Drawing.Point(0, 104);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(366, 52);
            this.btnOrderStatus.TabIndex = 2;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderStatus.UseVisualStyleBackColor = false;
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
            // 
            // btnPayStatus
            // 
            this.btnPayStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnPayStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayStatus.FlatAppearance.BorderSize = 0;
            this.btnPayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayStatus.ForeColor = System.Drawing.Color.White;
            this.btnPayStatus.Image = global::Capstone.Properties.Resources.payStat;
            this.btnPayStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayStatus.Location = new System.Drawing.Point(0, 52);
            this.btnPayStatus.Name = "btnPayStatus";
            this.btnPayStatus.Size = new System.Drawing.Size(366, 52);
            this.btnPayStatus.TabIndex = 1;
            this.btnPayStatus.Text = "Payment Status";
            this.btnPayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayStatus.UseVisualStyleBackColor = false;
            this.btnPayStatus.Click += new System.EventHandler(this.button25_Click);
            // 
            // dropBtnPayment
            // 
            this.dropBtnPayment.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnPayment.FlatAppearance.BorderSize = 0;
            this.dropBtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnPayment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnPayment.ForeColor = System.Drawing.Color.White;
            this.dropBtnPayment.Image = global::Capstone.Properties.Resources.payment;
            this.dropBtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnPayment.Location = new System.Drawing.Point(0, 0);
            this.dropBtnPayment.Name = "dropBtnPayment";
            this.dropBtnPayment.Size = new System.Drawing.Size(366, 52);
            this.dropBtnPayment.TabIndex = 0;
            this.dropBtnPayment.Text = "Payment and Order Status";
            this.dropBtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnPayment.UseVisualStyleBackColor = false;
            this.dropBtnPayment.Click += new System.EventHandler(this.dropBtnPayment_Click_1);
            // 
            // btnPatientR
            // 
            this.btnPatientR.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientR.FlatAppearance.BorderSize = 0;
            this.btnPatientR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientR.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatientR.ForeColor = System.Drawing.Color.White;
            this.btnPatientR.Image = global::Capstone.Properties.Resources.Patient_s_Record;
            this.btnPatientR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientR.Location = new System.Drawing.Point(0, 52);
            this.btnPatientR.Name = "btnPatientR";
            this.btnPatientR.Size = new System.Drawing.Size(366, 52);
            this.btnPatientR.TabIndex = 0;
            this.btnPatientR.Text = "Patient\'s Record";
            this.btnPatientR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientR.UseVisualStyleBackColor = false;
            this.btnPatientR.Click += new System.EventHandler(this.btnPatientR_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Capstone.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(366, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Aqua;
            this.lblName.Location = new System.Drawing.Point(0, 152);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(425, 51);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capstone.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(140, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerDrpBtnProducts
            // 
            this.timerDrpBtnProducts.Interval = 15;
            this.timerDrpBtnProducts.Tick += new System.EventHandler(this.timerDrpBtnProducts_Tick);
            // 
            // timerDrpBtnPayment
            // 
            this.timerDrpBtnPayment.Interval = 15;
            this.timerDrpBtnPayment.Tick += new System.EventHandler(this.timerDrpBtnPayment_Tick);
            // 
            // timerDrpBtnSales
            // 
            this.timerDrpBtnSales.Interval = 15;
            this.timerDrpBtnSales.Tick += new System.EventHandler(this.timerDrpBtnSales_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 998);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.dropPanelSales.ResumeLayout(false);
            this.dropPanelProducts.ResumeLayout(false);
            this.dropPanelPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblName;
        private System.Windows.Forms.Timer timerDrpBtnProducts;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerDrpBtnPayment;
        private System.Windows.Forms.Timer timerDrpBtnSales;
        private Panel panel4;
        private Button btnLogout;
        private Button btnUserSettings;
        private Button btnBackupArch;
        private Panel dropPanelSales;
        private Button btnInventory;
        private Button btnStockDel;
        private Panel dropPanelProducts;
        private Button btnTranscHist;
        private Panel dropPanelPayment;
        private Button btnPatientR;
        private Button btnDashboard;
        private Button btnSalesReport;
        private Button dropBtnSales;
        private Button btnItems;
        private Button btnProd;
        private Button dropBtnProducts;
        private Button btnOrderStatus;
        private Button btnPayStatus;
        private Button dropBtnPayment;
        private Button btnServices;
        private Button btnInventoryReport;
    }
}