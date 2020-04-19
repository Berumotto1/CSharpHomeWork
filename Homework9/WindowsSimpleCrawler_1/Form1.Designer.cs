namespace WindowsSimpleCrawler_1
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
            this.Crawler_button = new System.Windows.Forms.Button();
            this.URLBox1 = new System.Windows.Forms.ComboBox();
            this.URLBox2 = new System.Windows.Forms.ComboBox();
            this.URLlistBox1 = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Crawler_button
            // 
            this.Crawler_button.Location = new System.Drawing.Point(526, 48);
            this.Crawler_button.Name = "Crawler_button";
            this.Crawler_button.Size = new System.Drawing.Size(102, 33);
            this.Crawler_button.TabIndex = 0;
            this.Crawler_button.Text = "爬取";
            this.Crawler_button.UseVisualStyleBackColor = true;
            this.Crawler_button.Click += new System.EventHandler(this.Crawler_button_Click);
            // 
            // URLBox1
            // 
            this.URLBox1.FormattingEnabled = true;
            this.URLBox1.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.URLBox1.Location = new System.Drawing.Point(119, 54);
            this.URLBox1.Name = "URLBox1";
            this.URLBox1.Size = new System.Drawing.Size(94, 23);
            this.URLBox1.TabIndex = 1;
            // 
            // URLBox2
            // 
            this.URLBox2.FormattingEnabled = true;
            this.URLBox2.Items.AddRange(new object[] {
            "www.baidu.com",
            "www.cnblogs.com/dstang2000/"});
            this.URLBox2.Location = new System.Drawing.Point(219, 54);
            this.URLBox2.Name = "URLBox2";
            this.URLBox2.Size = new System.Drawing.Size(281, 23);
            this.URLBox2.TabIndex = 2;
            // 
            // URLlistBox1
            // 
            this.URLlistBox1.DataSource = this.bindingSource1;
            this.URLlistBox1.FormattingEnabled = true;
            this.URLlistBox1.ItemHeight = 15;
            this.URLlistBox1.Location = new System.Drawing.Point(93, 116);
            this.URLlistBox1.Name = "URLlistBox1";
            this.URLlistBox1.Size = new System.Drawing.Size(583, 259);
            this.URLlistBox1.TabIndex = 3;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(SimpleCrawler2.SimpleCrawler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.URLlistBox1);
            this.Controls.Add(this.URLBox2);
            this.Controls.Add(this.URLBox1);
            this.Controls.Add(this.Crawler_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crawler_button;
        private System.Windows.Forms.ComboBox URLBox1;
        private System.Windows.Forms.ComboBox URLBox2;
        private System.Windows.Forms.ListBox URLlistBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

