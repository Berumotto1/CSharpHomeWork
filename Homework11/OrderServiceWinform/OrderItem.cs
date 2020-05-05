using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderItem
    {
        public OrderItem(int productnum, int productprice)
        {
            ProductNum = productnum;
            ProductPrice = productprice;
        }
        public OrderItem()
        {
            ProductNum = 5;
            ProductPrice = 10;
        }
        public OrderItem(int pn,int pp,string name)
        {
            ProductNum = pn;
            ProductPrice = pp;
            ProductName = name;
        }

        //一个订单可能有好几个商品 
        
        public int OrderItemID { get; set; } //订单明细号  主键
        public int ProductNum { get; set; } //商品数量
        public int ProductID { set; get; } //商品ID
        public int ProductPrice { get; set; } //商品价格
        public string ProductName { get; set; } //商品名称
        public override string ToString()
        {
            return $"OrderItemID:{OrderItemID}\tProductName:{ProductName}\tProductID:{ProductID}\t" +
                $"ProductNum:{ProductNum}\tProductPrice:{ProductPrice}";
        }
        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   OrderItemID == item.OrderItemID &&
                   ProductNum == item.ProductNum &&
                   ProductID == item.ProductID &&
                   ProductPrice == item.ProductPrice &&
                   ProductName == item.ProductName;
        }
        public override int GetHashCode()
        {
            var hashCode = -1387937934;
            hashCode = hashCode * -1521134295 + OrderItemID.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductNum.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductID.GetHashCode();
            hashCode = hashCode * -1521134295 + ProductPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            return hashCode;
        }
    }
}
