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
    public partial class ItemEdit : Form
    {
        public OrderItem OrderItem { get; set; }
        public ItemEdit()
        {
            InitializeComponent();
            this.txtQuantity.DataBindings.Add("Text", ItemBindingSource, "GoodsNum");

        }
        public ItemEdit(OrderItem orderItem) : this()
        {
            this.OrderItem = orderItem;
            this.ItemBindingSource.DataSource = orderItem;
            List<Goods> goods = GoodsService.GetAll();
            if (goods.Count == 0)
            {
                GoodsService.Add(new Goods("ipad air3", 3700.0));
                GoodsService.Add(new Goods("iphone se2", 3200.0));
                GoodsService.Add(new Goods("leonvo y7000", 6500.0));
                goods = GoodsService.GetAll();
            }
            goodsBindingSource.DataSource = goods;
        }

        private void ItemEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ItemBindingSource.ResetBindings(false);
        }
    }
}
