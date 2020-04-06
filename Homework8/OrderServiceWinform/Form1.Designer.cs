namespace OrderServiceWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.CustomerID_label = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.OrderID_label = new System.Windows.Forms.Label();
            this.QuaryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ItembindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateOrder,
            this.QueryOrder,
            this.ModifyOrder,
            this.DeleteOrder,
            this.ImportOrder,
            this.OutputOrder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(600, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateOrder
            // 
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(81, 26);
            this.CreateOrder.Text = "创建订单";
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // QueryOrder
            // 
            this.QueryOrder.Name = "QueryOrder";
            this.QueryOrder.Size = new System.Drawing.Size(81, 26);
            this.QueryOrder.Text = "查询订单";
            // 
            // ModifyOrder
            // 
            this.ModifyOrder.Name = "ModifyOrder";
            this.ModifyOrder.Size = new System.Drawing.Size(81, 26);
            this.ModifyOrder.Text = "修改订单";
            this.ModifyOrder.Click += new System.EventHandler(this.ModifyOrder_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(81, 26);
            this.DeleteOrder.Text = "删除订单";
            // 
            // ImportOrder
            // 
            this.ImportOrder.Name = "ImportOrder";
            this.ImportOrder.Size = new System.Drawing.Size(81, 26);
            this.ImportOrder.Text = "导入订单";
            this.ImportOrder.Click += new System.EventHandler(this.ImportOrder_Click);
            // 
            // OutputOrder
            // 
            this.OutputOrder.Name = "OutputOrder";
            this.OutputOrder.Size = new System.Drawing.Size(81, 26);
            this.OutputOrder.Text = "导出订单";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 300);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1103, 490);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(445, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(307, 10);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(100, 25);
            this.CustomerID.TabIndex = 4;
            // 
            // CustomerID_label
            // 
            this.CustomerID_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerID_label.AutoSize = true;
            this.CustomerID_label.Location = new System.Drawing.Point(240, 15);
            this.CustomerID_label.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.CustomerID_label.Name = "CustomerID_label";
            this.CustomerID_label.Size = new System.Drawing.Size(61, 15);
            this.CustomerID_label.TabIndex = 3;
            this.CustomerID_label.Text = "客户ID:";
            // 
            // OrderID
            // 
            this.OrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderID.Location = new System.Drawing.Point(87, 10);
            this.OrderID.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 25);
            this.OrderID.TabIndex = 2;
            // 
            // OrderID_label
            // 
            this.OrderID_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderID_label.AutoSize = true;
            this.OrderID_label.Location = new System.Drawing.Point(20, 16);
            this.OrderID_label.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.OrderID_label.Name = "OrderID_label";
            this.OrderID_label.Size = new System.Drawing.Size(61, 15);
            this.OrderID_label.TabIndex = 1;
            this.OrderID_label.Text = "订单ID:";
            this.OrderID_label.Click += new System.EventHandler(this.OrderID_label_Click);
            // 
            // QuaryButton
            // 
            this.QuaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuaryButton.Location = new System.Drawing.Point(467, 3);
            this.QuaryButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.QuaryButton.Name = "QuaryButton";
            this.QuaryButton.Size = new System.Drawing.Size(103, 41);
            this.QuaryButton.TabIndex = 0;
            this.QuaryButton.Text = "查询";
            this.QuaryButton.UseVisualStyleBackColor = true;
            this.QuaryButton.Click += new System.EventHandler(this.QuaryButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OrderID_label);
            this.flowLayoutPanel1.Controls.Add(this.OrderID);
            this.flowLayoutPanel1.Controls.Add(this.CustomerID_label);
            this.flowLayoutPanel1.Controls.Add(this.CustomerID);
            this.flowLayoutPanel1.Controls.Add(this.QuaryButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 50);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // orderAmountDataGridViewTextBoxColumn
            // 
            this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.HeaderText = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework5.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.productNumDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ItembindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(476, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(565, 283);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ItembindingSource1
            // 
            this.ItembindingSource1.DataMember = "orderItems";
            this.ItembindingSource1.DataSource = this.orderBindingSource;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 520);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "查询订单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateOrder;
        private System.Windows.Forms.ToolStripMenuItem QueryOrder;
        private System.Windows.Forms.ToolStripMenuItem ModifyOrder;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrder;
        private System.Windows.Forms.ToolStripMenuItem ImportOrder;
        private System.Windows.Forms.ToolStripMenuItem OutputOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QuaryButton;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label CustomerID_label;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label OrderID_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ItembindingSource1;
    }
}

