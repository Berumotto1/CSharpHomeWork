using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order:IComparable
    {
        public int OrderID { get; set; }  //主键
        public String OrderDate { get; set; } //订单交易时间
        public int CustomerID { get; set; } //外键
        public int OrderAmount { get; set; } //交易总额
        public List<OrderItem> orderItems { get; set; }
        public Order()
        {
            orderItems = new List<OrderItem>();
        }
        public Order(int orderID, int customerID)
        {
            orderItems = new List<OrderItem>();
            OrderID = orderID;
            CustomerID = customerID;
        }
        public Order(int orderID, int customerID,OrderItem ot1,OrderItem ot2)
        {
            orderItems = new List<OrderItem>();
            OrderID = orderID;
            CustomerID = customerID;
            this.orderItems.Add(ot1);
            this.orderItems.Add(ot2); 
        }

        public void Calculate()
        {
            foreach (OrderItem ot in this.orderItems)
            {
                this.OrderAmount += ot.ProductPrice * ot.ProductNum;
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
                   OrderAmount == order.OrderAmount &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(orderItems, order.orderItems);
        }

        public override int GetHashCode()
        {
            var hashCode = 257297109;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderDate);
            hashCode = hashCode * -1521134295 + CustomerID.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderItems);
            return hashCode;
        }
    }
}
