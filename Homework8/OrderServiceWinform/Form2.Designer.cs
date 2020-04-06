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
            this.QueryOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyOrder = new System.Windows.Forms.TabPage();
            this.DeleteOrder = new System.Windows.Forms.TabPage();
            this.ImportOrder = new System.Windows.Forms.TabPage();
            this.OutputOrder = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddOrderID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddCustomerID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddItemName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.QueryOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            // OrderItembindingSource
            // 
            this.OrderItembindingSource.DataSource = typeof(Homework5.OrderItem);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.AddItemName);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.AddCustomerID);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.AddOrderID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 415);
            this.panel1.TabIndex = 0;
            // 
            // AddOrderID
            // 
            this.AddOrderID.AutoSize = true;
            this.AddOrderID.Location = new System.Drawing.Point(45, 62);
            this.AddOrderID.Name = "AddOrderID";
            this.AddOrderID.Size = new System.Drawing.Size(53, 15);
            this.AddOrderID.TabIndex = 0;
            this.AddOrderID.Text = "订单ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // AddCustomerID
            // 
            this.AddCustomerID.AutoSize = true;
            this.AddCustomerID.Location = new System.Drawing.Point(253, 62);
            this.AddCustomerID.Name = "AddCustomerID";
            this.AddCustomerID.Size = new System.Drawing.Size(55, 15);
            this.AddCustomerID.TabIndex = 2;
            this.AddCustomerID.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // AddItemName
            // 
            this.AddItemName.AutoSize = true;
            this.AddItemName.Location = new System.Drawing.Point(31, 119);
            this.AddItemName.Name = "AddItemName";
            this.AddItemName.Size = new System.Drawing.Size(67, 15);
            this.AddItemName.TabIndex = 4;
            this.AddItemName.Text = "商品名字";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
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
            this.QueryOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label AddItemName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label AddCustomerID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AddOrderID;
    }
}