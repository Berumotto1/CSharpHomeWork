namespace OrderServiceWinform
{
    partial class Form2
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
            this.CreateOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer = new System.Windows.Forms.Label();
            this.QueryOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModifyOrder = new System.Windows.Forms.TabPage();
            this.DeleteOrder = new System.Windows.Forms.TabPage();
            this.ImportOrder = new System.Windows.Forms.TabPage();
            this.OutputOrder = new System.Windows.Forms.TabPage();
            this.order = new System.Windows.Forms.Label();
            this.CreateProductName = new System.Windows.Forms.ComboBox();
            this.CreateOrderID = new System.Windows.Forms.TextBox();
            this.CreateCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateProductNum = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CreateOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.QueryOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateOrder
            // 
            this.CreateOrder.Controls.Add(this.tabPage1);
            this.CreateOrder.Controls.Add(this.QueryOrder);
            this.CreateOrder.Controls.Add(this.ModifyOrder);
            this.CreateOrder.Controls.Add(this.DeleteOrder);
            this.CreateOrder.Controls.Add(this.ImportOrder);
            this.CreateOrder.Controls.Add(this.OutputOrder);
            this.CreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateOrder.Location = new System.Drawing.Point(0, 0);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.SelectedIndex = 0;
            this.CreateOrder.Size = new System.Drawing.Size(800, 450);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.SelectedIndexChanged += new System.EventHandler(this.CreateOrder_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "创建订单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.CreateProductNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CreateDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CreateCustomerID);
            this.panel1.Controls.Add(this.CreateOrderID);
            this.panel1.Controls.Add(this.CreateProductName);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 415);
            this.panel1.TabIndex = 0;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(220, 94);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(53, 15);
            this.customer.TabIndex = 1;
            this.customer.Text = "客户ID";
            // 
            // QueryOrder
            // 
            this.QueryOrder.Controls.Add(this.dataGridView1);
            this.QueryOrder.Location = new System.Drawing.Point(4, 25);
            this.QueryOrder.Name = "QueryOrder";
            this.QueryOrder.Padding = new System.Windows.Forms.Padding(3);
            this.QueryOrder.Size = new System.Drawing.Size(792, 421);
            this.QueryOrder.TabIndex = 1;
            this.QueryOrder.Text = "查询订单";
            this.QueryOrder.UseVisualStyleBackColor = true;
            this.QueryOrder.Click += new System.EventHandler(this.QueryOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.productNumDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.OrderItembindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(627, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderItemIDDataGridViewTextBoxColumn
            // 
            this.orderItemIDDataGridViewTextBoxColumn.DataPropertyName = "OrderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.HeaderText = "OrderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.Name = "orderItemIDDataGridViewTextBoxColumn";
            // 
            // productNumDataGridViewTextBoxColumn
            // 
            this.productNumDataGridViewTextBoxColumn.DataPropertyName = "ProductNum";
            this.productNumDataGridViewTextBoxColumn.HeaderText = "ProductNum";
            this.productNumDataGridViewTextBoxColumn.Name = "productNumDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // OrderItembindingSource
            // 
            this.OrderItembindingSource.DataSource = typeof(Homework5.OrderItem);
            // 
            // ModifyOrder
            // 
            this.ModifyOrder.Location = new System.Drawing.Point(4, 25);
            this.ModifyOrder.Name = "ModifyOrder";
            this.ModifyOrder.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyOrder.Size = new System.Drawing.Size(792, 421);
            this.ModifyOrder.TabIndex = 2;
            this.ModifyOrder.Text = "修改订单";
            this.ModifyOrder.UseVisualStyleBackColor = true;
            this.ModifyOrder.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(4, 25);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteOrder.Size = new System.Drawing.Size(792, 421);
            this.DeleteOrder.TabIndex = 3;
            this.DeleteOrder.Text = "删除订单";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // ImportOrder
            // 
            this.ImportOrder.Location = new System.Drawing.Point(4, 25);
            this.ImportOrder.Name = "ImportOrder";
            this.ImportOrder.Padding = new System.Windows.Forms.Padding(3);
            this.ImportOrder.Size = new System.Drawing.Size(792, 421);
            this.ImportOrder.TabIndex = 4;
            this.ImportOrder.Text = "导入订单";
            this.ImportOrder.UseVisualStyleBackColor = true;
            // 
            // OutputOrder
            // 
            this.OutputOrder.Location = new System.Drawing.Point(4, 25);
            this.OutputOrder.Name = "OutputOrder";
            this.OutputOrder.Padding = new System.Windows.Forms.Padding(3);
            this.OutputOrder.Size = new System.Drawing.Size(792, 421);
            this.OutputOrder.TabIndex = 5;
            this.OutputOrder.Text = "导出订单";
            this.OutputOrder.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(220, 50);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(53, 15);
            this.order.TabIndex = 2;
            this.order.Text = "订单ID";
            // 
            // CreateProductName
            // 
            this.CreateProductName.FormattingEnabled = true;
            this.CreateProductName.Items.AddRange(new object[] {
            "iPhone11",
            "iPad pro 2020",
            "Lenove y7000"});
            this.CreateProductName.Location = new System.Drawing.Point(295, 200);
            this.CreateProductName.Name = "CreateProductName";
            this.CreateProductName.Size = new System.Drawing.Size(200, 23);
            this.CreateProductName.TabIndex = 3;
            // 
            // CreateOrderID
            // 
            this.CreateOrderID.Location = new System.Drawing.Point(295, 47);
            this.CreateOrderID.Name = "CreateOrderID";
            this.CreateOrderID.Size = new System.Drawing.Size(200, 25);
            this.CreateOrderID.TabIndex = 4;
            // 
            // CreateCustomerID
            // 
            this.CreateCustomerID.Location = new System.Drawing.Point(295, 94);
            this.CreateCustomerID.Name = "CreateCustomerID";
            this.CreateCustomerID.Size = new System.Drawing.Size(200, 25);
            this.CreateCustomerID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "交易时间";
            // 
            // CreateDate
            // 
            this.CreateDate.Location = new System.Drawing.Point(295, 140);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(200, 25);
            this.CreateDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "商品数量";
            // 
            // CreateProductNum
            // 
            this.CreateProductNum.FormattingEnabled = true;
            this.CreateProductNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CreateProductNum.Location = new System.Drawing.Point(295, 259);
            this.CreateProductNum.Name = "CreateProductNum";
            this.CreateProductNum.Size = new System.Drawing.Size(200, 23);
            this.CreateProductNum.TabIndex = 10;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(322, 330);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(127, 50);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "创建";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateOrder);
            this.Name = "Form2";
            this.Text = "Form2";
            this.CreateOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.QueryOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CreateOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage QueryOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource OrderItembindingSource;
        private System.Windows.Forms.TabPage ModifyOrder;
        private System.Windows.Forms.TabPage DeleteOrder;
        private System.Windows.Forms.TabPage ImportOrder;
        private System.Windows.Forms.TabPage OutputOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateCustomerID;
        private System.Windows.Forms.TextBox CreateOrderID;
        private System.Windows.Forms.ComboBox CreateProductName;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox CreateProductNum;
    }
}