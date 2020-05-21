using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinform
{
    public class Order:IComparable
    {
        public string OrderID { get; set; }  //主键
        public DateTime OrderDate { get; set; } //订单交易时间
        public string CustomerID { get; set; } //外键

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int OrderAmount { get; set; } //交易总额
        public List<OrderItem> orderItems { get; set; }
      

        public Order()
        {
            OrderID = Guid.NewGuid().ToString();
            orderItems = new List<OrderItem>();
            OrderDate = DateTime.Now;
        }

        public Order(Customer customer, List<OrderItem> items) : this()
        {
            this.Customer = customer;
            this.OrderDate = DateTime.Now;
            if (items != null) orderItems = items;
        }

        public void Calculate()
        {
            foreach (OrderItem ot in this.orderItems)
            {
                this.OrderAmount += ot.GoodsPrice * ot.GoodsNum;
            }
            
        }
        public string PrintList()
        {
            String Otstr=null; 
            foreach(OrderItem ot in orderItems)
            {
                Otstr += ot+"\n";
            }
            return Otstr;
        }


        public void AddItem(OrderItem orderItem)
        {
            if (orderItems.Contains(orderItem))
                throw new ApplicationException($"添加错误：订单项已经存在!");
            orderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            orderItems.Remove(orderItem);
        }

        public override string ToString()
        {
            return ($"OrderID:{OrderID}\tCustomerID:{CustomerID}\tOrderItems:\n{PrintList()}OrderAmount:{OrderAmount}\tOrderDate:{OrderDate}\n");
        }
      
      
        public int CompareTo(object obj)
        {
            var order = obj as Order;
            return this.Equals(obj) ? 1:0;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderID == order.OrderID &&
                   OrderDate == order.OrderDate &&
                   CustomerID == order.CustomerID &&
                   EqualityComparer<Customer>.Default.Equals(Customer, order.Customer) &&
                   OrderAmount == order.OrderAmount &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(orderItems, order.orderItems);
        }

        public override int GetHashCode()
        {
            var hashCode = -1922707514;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderID);
            hashCode = hashCode * -1521134295 + OrderDate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderItems);
            return hashCode;
        }
    }
}
