
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinform
{
    public class OrderItem
    {
        public string OrderItemID { get; set; } //订单明细号  主键
       
        public string GoodsID { set; get; } //商品ID
        public int GoodsNum { get; set; } //商品数量

        [ForeignKey("GoodsID")]
        public Goods GoodsItem { get; set; }
        public int GoodsPrice { get; set; } //商品价格
        public string GoodsName { get; set; } //商品名称

        public string OrderId { get; set; }

        public OrderItem()
        {
            OrderItemID = Guid.NewGuid().ToString();
        }

        public OrderItem(Goods goods, int GoodsNum) : this()
        {
            this.GoodsItem = goods;
            this.GoodsNum = GoodsNum;
        }
        
        public override string ToString()
        {
            return $"OrderItemID:{OrderItemID}\tProductName:{GoodsName}\tProductID:{GoodsID}\t" +
                $"ProductNum:{GoodsNum}\tProductPrice:{GoodsPrice}";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   OrderItemID == item.OrderItemID &&
                   GoodsID == item.GoodsID &&
                   GoodsNum == item.GoodsNum &&
                   EqualityComparer<Goods>.Default.Equals(GoodsItem, item.GoodsItem) &&
                   GoodsPrice == item.GoodsPrice &&
                   GoodsName == item.GoodsName &&
                   OrderId == item.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = 1938901796;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderItemID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsID);
            hashCode = hashCode * -1521134295 + GoodsNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(GoodsItem);
            hashCode = hashCode * -1521134295 + GoodsPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderId);
            return hashCode;
        }
    }
}
