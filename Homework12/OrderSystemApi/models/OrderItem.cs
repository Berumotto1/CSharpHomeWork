using System.ComponentModel.DataAnnotations.Schema;
namespace OrderSystemApi.Models
{
    public class OrderItem
    {
        public string OrderItemID { get; set; } //订单明细号  主键

        public int GoodsNum { get; set; } //商品数量
        public double GoodsPrice { get; set; } //商品价格
        public string GoodsName { get; set; } //商品名称

        public string OrderId { get; set; }
    }

}