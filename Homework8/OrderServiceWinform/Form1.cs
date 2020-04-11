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
        public string createOrderID { get; set; }
        public string createCustomerID { get; set; }
        public string createDate { get; set; }
        public string createProductName { get; set; }
        public string createProductNum { get; set; }
        


        public List<Order> orderList = new List<Order>();
        public string queryid { get; set; }
        public string customerid { get; set; }
        OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();

            //
            
            //先添加一些订单
            /*
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
            */

            os.CalAmount();
            orderBindingSource.DataSource = os.orderList;
            
            //绑定查询条件
            QueryBox.DataBindings.Add("Text", this, "queryid");
            //CustomerID.DataBindings.Add("Text", this, "customerid");

            //创建订单数据绑定

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void QuaryButton_Click(object sender, EventArgs e)
        {
            if((ItemBox.Text==null ||ItemBox.Text==""|| queryid == null|| queryid == "")) //&& (customerid==null||customerid==""))
            {
                orderBindingSource.DataSource = os.orderList.ToList();
            }
            else
            {
                if(ItemBox.Text=="订单ID")
                {
                    orderBindingSource.DataSource = os.orderList.Where(
                    order => order.OrderID.ToString() == queryid
                    ).ToList();
                }
                else
                {
                   orderBindingSource.DataSource = os.orderList.Where(
                   order => order.CustomerID.ToString() == queryid
                   ).ToList();
                }
                 
                //当不存在order满足时，会出现bug!!!!   
                //加上toList()  已解决
                
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
            openFileDialog1.InitialDirectory = "G:\\VS\\repos\\Homework5" +
                "\\Homework5\\bin\\Debug";

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                os.Import(openFileDialog1.FileName);
                this.orderBindingSource.ResetBindings(false);
            }
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
                os.Export(saveFileDialog1.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            os.orderList = new List<Order>();
            orderBindingSource.DataSource = os.orderList.ToList();
            this.orderBindingSource.ResetBindings(false);
        }
    }
}
