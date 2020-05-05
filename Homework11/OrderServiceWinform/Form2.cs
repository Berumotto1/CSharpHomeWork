using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem;

namespace OrderServiceWinform
{
    public partial class Form2 : Form
    {

        public string createOrderID { get; set; }
        public string createCustomerID { get; set; }
        public string createDate { get; set; }
        public string createProductName { get; set; }
        public string createProductNum { get; set; }

        public Order addOrder = new Order();
        public Random random = new Random(Guid.NewGuid().GetHashCode());

        public Form2()
        {
            InitializeComponent();

            CreateOrderID.DataBindings.Add("Text", this, "createOrderID");
            CreateCustomerID.DataBindings.Add("Text", this, "createCustomerID");
            CreateProductName.DataBindings.Add("Text", this, "createProductName");
            CreateProductNum.DataBindings.Add("Text", this, "createProductNum");
        }

        private void QueryOrder_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                addOrder.OrderID = Convert.ToInt32(createOrderID);
                addOrder.CustomerID = Convert.ToInt32(createCustomerID);
                addOrder.orderItems.Add(new OrderItem(Convert.ToInt32(createProductNum), 
                    random.Next(1, 200) * 10 + 1000, createProductName));
                //添加订单
                using (var db=new OrderContext())
                {
                    var order = new Order { OrderID = addOrder.OrderID,
                      CustomerID = addOrder.CustomerID };
                    order.OrderDate = DateTime.Now.ToString();
                    //var order = addOrder;
                    order.orderItems = new List<OrderItem>()
                    {
                        new OrderItem(Convert.ToInt32(createProductNum),
                            random.Next(1, 200) * 10 + 1000, createProductName){}
                    };
                    order.Calculate();
                    db.Orders.Add(order);
                    db.SaveChanges();
                    MessageBox.Show("添加成功！");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
