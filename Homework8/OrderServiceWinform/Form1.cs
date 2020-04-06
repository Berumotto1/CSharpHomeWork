using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework5;

namespace OrderServiceWinform
{
    public partial class Form1 : Form
    {
        public List<Order> orderList = new List<Order>();
        public string orderid { get; set; }
        public string customerid { get; set; }
        OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();

            //
            
            //先添加一些订单
            String[] names = { "iPad air3", "iPad pro", "Huawei P30", "iPhone", "Computer" };
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 1; i < 5; i++)
            {
                int id = rnd.Next(1, 30);
                int cid = rnd.Next(1, 100);
                Order ord = new Order(id, cid);
                for (int j = 0; j < 2; j++)
                {
                    int pn = rnd.Next(1, 5); //产品数量
                    int pp = rnd.Next(1, 200) * 10 + 1000; //产品价格
                    int pna = rnd.Next(1, 5);
                    string name = names[pna];

                    OrderItem ot = new OrderItem(pn, pp, name);

                    if (!ord.orderItems.Contains(ot)) //避免订单明细重复
                    {
                        ord.orderItems.Add(ot);
                    }
                }
                if (os.TrackOrder(ord.CustomerID) == null)
                {
                    os.AddOrder(ord);
                }
            }
            os.CalAmount();
            orderBindingSource.DataSource = os.orderList;
            //
            //绑定查询条件
            OrderID.DataBindings.Add("Text", this, "orderid");
            CustomerID.DataBindings.Add("Text", this, "customerid");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void QuaryButton_Click(object sender, EventArgs e)
        {
            if((orderid==null||orderid=="")) //&& (customerid==null||customerid==""))
            {
                orderBindingSource.DataSource = os.orderList;
            }
            else
            {
                
                orderBindingSource.DataSource = os.orderList.Where(
                    order => order.OrderID.ToString() == orderid
                    );
                //当不存在order满足时，会出现bug!!!!
                
                //orderBindingSource.DataSource = os.orderList;
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderID_label_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyOrder_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.ResetBindings(false);
            this.ItembindingSource1.ResetBindings(false);
        }

        private void ImportOrder_Click(object sender, EventArgs e)
        {
            //orderBindingSource.DataSource=
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
