using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServiceWinform;

namespace OrderServiceWinform
{
    public partial class Form1 : Form
    {
        public string createOrderID { get; set; }
        public string createCustomerID { get; set; }
        public string createDate { get; set; }
        public string createProductName { get; set; }
        public string createProductNum { get; set; }
        
        public List<Order> orderList = new List<Order>();
        public string queryContent { get; set; }
        public string customerid { get; set; }
        OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();
            orderBindingSource.DataSource = OrderService.TrackAllOrders();
            //绑定查询条件
            QueryBox.DataBindings.Add("Text", this, "queryContent");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(new Order());
            if (form2.ShowDialog() == DialogResult.OK)
            {
                OrderService.AddOrder(form2.CurrentOrder);
                QueryAll();
            }
        }

        private void QuaryButton_Click(object sender, EventArgs e)
        {
            switch (ItemBox.Text)
            {
                case "全部订单":
                    orderBindingSource.DataSource = OrderService.TrackAllOrders();
                    break;
                case "客户":
                    orderBindingSource.DataSource = OrderService.TrackOrderByCustomerName(queryContent);
                    break;
                case "交易总额":
                    float.TryParse(queryContent, out float totalPrice);
                    orderBindingSource.DataSource =
                           OrderService.TrackOrderByTotalAmount(totalPrice);
                    break;
                case "商品":
                    orderBindingSource.DataSource = OrderService.TrackOrderByGoodsName(queryContent);
                    break;

            }

            //当不存在order满足时，会出现bug!!!!   
            //加上toList()  已解决

        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyOrder_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            order = OrderService.TrackOrder(order.OrderID); //查询出最新的订单信息
            Form2 form2 = new Form2(order, true);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                OrderService.UpdateOrder(form2.CurrentOrder);
                QueryAll();
            }
            //this.orderBindingSource.ResetBindings(false);
            //this.ItembindingSource1.ResetBindings(false);
        }

        private void ImportOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                OrderService.Import(fileName);
                QueryAll();
            }
            /*openFileDialog1.InitialDirectory = "G:\\VS\\repos\\Homework5" +
                "\\Homework5\\bin\\Debug";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                os.Import(openFileDialog1.FileName);
                this.orderBindingSource.ResetBindings(false);
                using (var db = new OrderContext())
                {
                    foreach(Order order in os.orderList)
                    {
                        db.Orders.Add(order);
                    }
                    db.SaveChanges();

                }
            }*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OutputOrder_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveFileDialog1.InitialDirectory = "G:\\VS\\repos\\" +
                    "Homework5\\Homework5\\bin\\Debug";
                OrderService.Export(saveFileDialog1.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //int oid = (int)dataGridView1.SelectedRows[0].Cells[0].Value; //获取当前选中行的 订单id
            //MessageBox.Show(""+a);
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            OrderService.DeleteOrder(order.OrderID);
            QueryAll();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = new List<Order>();
            this.orderBindingSource.ResetBindings(false);
        }
        
       
        private void QueryAll()
        {
            orderBindingSource.DataSource = OrderService.TrackAllOrders();
            orderBindingSource.ResetBindings(false);
        }
    }
}
