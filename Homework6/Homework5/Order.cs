using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Order:IComparable
    {
        public int OrderID { get; set; }

        //public string OrderName { get; set; }

        public DateTime OrderDate { get; set; } //订单交易时间
        //public string Customer { get; set; }


        public int CustomerID { get; set; }

        public int OrderAmount { get; set; } //交易总额

        public List<OrderItem> orderItems=new List<OrderItem>();


        public Order()
        {
            OrderID = 10;
            CustomerID = 10;
        }
        public Order(int orderID, int customerID)
        {
            OrderID = orderID;
            CustomerID = customerID;
        }

        public Order(int orderID, int customerID,OrderItem ot1,OrderItem ot2)
        {
            OrderID = orderID;
            CustomerID = customerID;
            this.orderItems.Add(ot1);
            this.orderItems.Add(ot2); 
        }

       /* public override bool Equals(object obj)
        {
            Order ord2 = obj as Order;
            if (ord2 == null)
                throw new System.ArgumentException(); 
            return (this.OrderID == ord2.OrderID && this.CustomerID == ord2.CustomerID
                && this.OrderDate == ord2.OrderDate && OrderAmount==ord2.OrderAmount);
        }*/


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

        public override int GetHashCode()
        {
            var hashCode = 257297109;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderDate.GetHashCode();
            hashCode = hashCode * -1521134295 + CustomerID.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderItems);
            return hashCode;
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

        public int CompareTo(object obj)
        {
            var order = obj as Order;
            return this.Equals(obj) ? 1:0;
        }
    }
}
