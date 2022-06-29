namespace Capstone
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dropPanelPayment = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.dropBtnPayment = new System.Windows.Forms.Button();
            this.dropPanelProducts = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dropBtnProducts = new System.Windows.Forms.Button();
            this.dropPanelSales = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.dropBtnSales = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDrpBtnProducts = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnPayment = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnSales = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.dropPanelPayment.SuspendLayout();
            this.dropPanelProducts.SuspendLayout();
            this.dropPanelSales.SuspendLayout();
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
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 948);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.dropPanelPayment);
            this.panel3.Controls.Add(this.dropPanelProducts);
            this.panel3.Controls.Add(this.dropPanelSales);
            this.panel3.Location = new System.Drawing.Point(502, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 845);
            this.panel3.TabIndex = 5;
            // 
            // dropPanelPayment
            // 
            this.dropPanelPayment.BackColor = System.Drawing.Color.Transparent;
            this.dropPanelPayment.Controls.Add(this.button17);
            this.dropPanelPayment.Controls.Add(this.button18);
            this.dropPanelPayment.Controls.Add(this.dropBtnPayment);
            this.dropPanelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelPayment.Location = new System.Drawing.Point(0, 161);
            this.dropPanelPayment.MaximumSize = new System.Drawing.Size(366, 161);
            this.dropPanelPayment.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelPayment.Name = "dropPanelPayment";
            this.dropPanelPayment.Size = new System.Drawing.Size(366, 161);
            this.dropPanelPayment.TabIndex = 3;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Image = global::Capstone.Properties.Resources.orderStat;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(0, 104);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(366, 52);
            this.button17.TabIndex = 6;
            this.button17.Text = "Order Status     ";
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.Dock = System.Windows.Forms.DockStyle.Top;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = global::Capstone.Properties.Resources.payment;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(0, 52);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(366, 52);
            this.button18.TabIndex = 5;
            this.button18.Text = "Payment Status";
            this.button18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button18.UseVisualStyleBackColor = false;
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
            this.dropBtnPayment.TabIndex = 8;
            this.dropBtnPayment.Text = "Payment and Order Status";
            this.dropBtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnPayment.UseVisualStyleBackColor = false;
            this.dropBtnPayment.Click += new System.EventHandler(this.dropBtnPayment_Click);
            // 
            // dropPanelProducts
            // 
            this.dropPanelProducts.BackColor = System.Drawing.Color.Transparent;
            this.dropPanelProducts.Controls.Add(this.button14);
            this.dropPanelProducts.Controls.Add(this.button13);
            this.dropPanelProducts.Controls.Add(this.button12);
            this.dropPanelProducts.Controls.Add(this.dropBtnProducts);
            this.dropPanelProducts.Location = new System.Drawing.Point(37, 506);
            this.dropPanelProducts.MaximumSize = new System.Drawing.Size(366, 213);
            this.dropPanelProducts.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelProducts.Name = "dropPanelProducts";
            this.dropPanelProducts.Size = new System.Drawing.Size(366, 213);
            this.dropPanelProducts.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::Capstone.Properties.Resources.Service;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(0, 156);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(366, 52);
            this.button14.TabIndex = 7;
            this.button14.Text = "Services";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::Capstone.Properties.Resources.Items;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(0, 104);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(366, 52);
            this.button13.TabIndex = 6;
            this.button13.Text = "Items     ";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::Capstone.Properties.Resources.Products;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(0, 52);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(366, 52);
            this.button12.TabIndex = 5;
            this.button12.Text = "Products";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button12.UseVisualStyleBackColor = false;
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
            this.dropBtnProducts.TabIndex = 8;
            this.dropBtnProducts.Text = "Products, Items, and Services";
            this.dropBtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnProducts.UseVisualStyleBackColor = false;
            this.dropBtnProducts.Click += new System.EventHandler(this.dropBtnProducts_Click);
            // 
            // dropPanelSales
            // 
            this.dropPanelSales.BackColor = System.Drawing.Color.Transparent;
            this.dropPanelSales.Controls.Add(this.button16);
            this.dropPanelSales.Controls.Add(this.button20);
            this.dropPanelSales.Controls.Add(this.dropBtnSales);
            this.dropPanelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelSales.Location = new System.Drawing.Point(0, 0);
            this.dropPanelSales.MaximumSize = new System.Drawing.Size(366, 161);
            this.dropPanelSales.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelSales.Name = "dropPanelSales";
            this.dropPanelSales.Size = new System.Drawing.Size(366, 161);
            this.dropPanelSales.TabIndex = 4;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = global::Capstone.Properties.Resources.Inventory;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(0, 104);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(366, 52);
            this.button16.TabIndex = 6;
            this.button16.Text = "Inventory Report";
            this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.Dock = System.Windows.Forms.DockStyle.Top;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Image = global::Capstone.Properties.Resources.Sales;
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(0, 52);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(366, 52);
            this.button20.TabIndex = 5;
            this.button20.Text = "Sales Report       ";
            this.button20.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button20.UseVisualStyleBackColor = false;
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
            this.dropBtnSales.TabIndex = 8;
            this.dropBtnSales.Text = "Sales and Inventory Report";
            this.dropBtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnSales.UseVisualStyleBackColor = false;
            this.dropBtnSales.Click += new System.EventHandler(this.dropBtnSales_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::Capstone.Properties.Resources.Dashboard;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 322);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(502, 52);
            this.button9.TabIndex = 11;
            this.button9.Text = "Dashboard";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Capstone.Properties.Resources.Patient_s_Record;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Patient\'s Record";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::Capstone.Properties.Resources.Log_out;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(49, 884);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(366, 52);
            this.button10.TabIndex = 9;
            this.button10.Text = "Logout";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Capstone.Properties.Resources.Back_up;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(49, 771);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(366, 52);
            this.button5.TabIndex = 10;
            this.button5.Text = "Back-up and Archive";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Capstone.Properties.Resources.User_Settings;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(49, 829);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(366, 52);
            this.button11.TabIndex = 8;
            this.button11.Text = "User Settings";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Capstone.Properties.Resources.Stock_Delivery;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(49, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(366, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Stock delivery";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Capstone.Properties.Resources.inventoryMonitor;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(49, 634);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(366, 52);
            this.button7.TabIndex = 8;
            this.button7.Text = "Inventory";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Capstone.Properties.Resources.Transaction_History;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(49, 702);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(366, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "Transaction History";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.dropPanelPayment.ResumeLayout(false);
            this.dropPanelProducts.ResumeLayout(false);
            this.dropPanelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label lblName;
        private Button button5;
        private Button button4;
        private Button button10;
        private Button button11;
        private Button button7;
        private Button button8;
        private Button button9;
        private Panel dropPanelProducts;
        private Button button13;
        private Button button12;
        private Button button14;
        private Button dropBtnProducts;
        private Panel dropPanelPayment;
        private Button button17;
        private Button button18;
        private Button dropBtnPayment;
        private Panel dropPanelSales;
        private Button button16;
        private Button button20;
        private Button dropBtnSales;
        private System.Windows.Forms.Timer timerDrpBtnProducts;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerDrpBtnPayment;
        private System.Windows.Forms.Timer timerDrpBtnSales;
        private Panel panel3;
    }
}