using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class OrderItem
    {
        public OrderItem(int productnum, int productprice)
        {
            ProductNum = productnum;
            ProductPrice = productprice;
        }

        //一个订单可能有好几个商品 
        public int OrderItemID { get; set; } //订单明细号

        public int ProductNum { get; set; } //商品数量
     
        public int ProductID { set; get; } //商品ID

        public int ProductPrice { get; set; } //商品价格



        public override string ToString()
        {
            return $"OrderItemID:{OrderItemID}\tProductID:{ProductID}\t" +
                $"ProductNum:{ProductNum}\tProductPrice:{ProductPrice}";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   OrderItemID == item.OrderItemID &&
                   ProductNum == item.ProductNum &&
                   ProductID == item.ProductID &&
                   ProductPrice == item.ProductPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -1560787629;
            hashCode = hashCode * -1521134295 + OrderItemID.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductNum.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductID.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductPrice.GetHashCode();
            return hashCode;
        }
    }
}
