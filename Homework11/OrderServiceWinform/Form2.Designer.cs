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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.ModifyItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateOrderID = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.CreateOrder = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.CreateOrder.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.DeleteItemButton);
            this.panel1.Controls.Add(this.ModifyItemButton);
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CreateOrderID);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 415);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 18;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(OrderServiceWinform.Customer);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(278, 344);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(85, 33);
            this.DeleteItemButton.TabIndex = 17;
            this.DeleteItemButton.Text = "删除明细";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // ModifyItemButton
            // 
            this.ModifyItemButton.Location = new System.Drawing.Point(182, 343);
            this.ModifyItemButton.Name = "ModifyItemButton";
            this.ModifyItemButton.Size = new System.Drawing.Size(87, 34);
            this.ModifyItemButton.TabIndex = 16;
            this.ModifyItemButton.Text = "修改明细";
            this.ModifyItemButton.UseVisualStyleBackColor = true;
            this.ModifyItemButton.Click += new System.EventHandler(this.ModifyItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(73, 343);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(93, 34);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "添加明细";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "订单明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIDDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.goodsNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // orderItemIDDataGridViewTextBoxColumn
            // 
            this.orderItemIDDataGridViewTextBoxColumn.DataPropertyName = "OrderItemID";
            this.orderItemIDDataGridViewTextBoxColumn.HeaderText = "订单项号";
            this.orderItemIDDataGridViewTextBoxColumn.Name = "orderItemIDDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            // 
            // goodsNumDataGridViewTextBoxColumn
            // 
            this.goodsNumDataGridViewTextBoxColumn.DataPropertyName = "GoodsNum";
            this.goodsNumDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.goodsNumDataGridViewTextBoxColumn.Name = "goodsNumDataGridViewTextBoxColumn";
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "orderItems";
            this.ItemBindingSource.DataSource = this.OrderBindingSource;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(OrderServiceWinform.Order);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(292, 106);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(71, 15);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "2020-5-1";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(549, 344);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(127, 31);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "创建";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "交易时间";
            // 
            // CreateOrderID
            // 
            this.CreateOrderID.Location = new System.Drawing.Point(295, 25);
            this.CreateOrderID.Name = "CreateOrderID";
            this.CreateOrderID.Size = new System.Drawing.Size(200, 25);
            this.CreateOrderID.TabIndex = 4;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(221, 28);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(52, 15);
            this.order.TabIndex = 2;
            this.order.Text = "订单号";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(232, 68);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(37, 15);
            this.customer.TabIndex = 1;
            this.customer.Text = "客户";
            // 
            // CreateOrder
            // 
            this.CreateOrder.Controls.Add(this.tabPage1);
            this.CreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateOrder.Location = new System.Drawing.Point(0, 0);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.SelectedIndex = 0;
            this.CreateOrder.Size = new System.Drawing.Size(800, 450);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.SelectedIndexChanged += new System.EventHandler(this.CreateOrder_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateOrder);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.CreateOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateOrderID;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.TabControl CreateOrder;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button ModifyItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNumDataGridViewTextBoxColumn;
    }
}