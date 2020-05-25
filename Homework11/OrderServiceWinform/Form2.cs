using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServiceWinform
{
    public partial class Form2 : Form
    {
        public Order CurrentOrder { get; set; }
        public Form2()
        {
            InitializeComponent();
            //this.DialogResult = DialogResult.OK;
            this.timeLabel.DataBindings.Add("Text", OrderBindingSource, "OrderDate");
            this.CreateOrderID.DataBindings.Add("Text", OrderBindingSource, "OrderID");
            List<Customer> customers = CustomerService.GetAll();
            if (customers.Count == 0)
            {
                CustomerService.Add(new Customer("yang"));
                CustomerService.Add(new Customer("jiao"));
                CustomerService.Add(new Customer("wang"));
                customers = CustomerService.GetAll();
            }
            customerBindingSource.DataSource = customers;
            //CreateOrderID.DataBindings.Add("Text", this, "createOrderID");
            //CreateCustomerID.DataBindings.Add("Text", this, "createCustomerID");
            //CreateProductName.DataBindings.Add("Text", this, "createProductName");
            //CreateProductNum.DataBindings.Add("Text", this, "createProductNum");
        }


        public Form2(Order order, bool editMode = false) : this()
        {
            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            CurrentOrder = order;
            OrderBindingSource.DataSource = CurrentOrder;
            CreateOrderID.Enabled = !editMode;
            if (!editMode)
            {
                CurrentOrder.Customer = (Customer)customerBindingSource.Current;
            }
        }

       


        private void CreateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }


        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ItemEdit itemEdit = new ItemEdit(new OrderItem());
            try
            {
                if (itemEdit.ShowDialog() == DialogResult.OK)
                {
                    CurrentOrder.AddItem(itemEdit.OrderItem);
                    ItemBindingSource.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CurrentOrder.Customer = (Customer)customerBindingSource.Current;
            //TODO 加上订单合法性验证
            CurrentOrder.CustomerID = CurrentOrder.Customer.CustomerID;
            //Customer c=(Customer)customerBindingSource.Current;
                CurrentOrder.Customer = null;
                CurrentOrder.orderItems.ForEach(item => {
                    item.GoodsID = item.GoodsItem.GoodsID;
                    item.GoodsItem = null;
                    item.OrderId = CurrentOrder.OrderID;
                });
                this.Close();
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = ItemBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveItem(orderItem);
            ItemBindingSource.ResetBindings(false);
        }

        private void EditItem()
        {
            OrderItem orderItem = ItemBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            ItemEdit formItemEdit = new ItemEdit(orderItem);
            if (formItemEdit.ShowDialog() == DialogResult.OK)
            {
                ItemBindingSource.ResetBindings(false);
            }
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            EditItem();
        }
    }
}
