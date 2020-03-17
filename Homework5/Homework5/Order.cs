using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Order
    {
        public int OrderID { get; set; }

        public string OrderName { get; set; }

        public DateTime OrderDate { get; set; } //订单交易时间
        //public string Customer { get; set; }


        public int CustomerID { get; set; }

        public int OrderAmount { get; set; } //交易总额

        public List<OrderItem> orderItems=new List<OrderItem>();

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

        public override bool Equals(object obj)
        {
            Order ord2 = obj as Order;
            if (ord2 == null)
                throw new System.ArgumentException(); 
            return (this.OrderID == ord2.OrderID && this.CustomerID == ord2.CustomerID
                && this.OrderDate == ord2.OrderDate && this.OrderName == ord2.OrderName&&OrderAmount==ord2.OrderAmount);
        }


        public override int GetHashCode()
        {
            var hashCode = -450723984;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderName);
            hashCode = hashCode * -1521134295 + OrderDate.GetHashCode();
            hashCode = hashCode * -1521134295 + CustomerID.GetHashCode();
            return hashCode;
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
            return ($"OrderID:{OrderID}\tCustomerID:{CustomerID}\tOrderItems:\n{PrintList()}OrderAmount:{OrderAmount}\tOrderName:{OrderName}\tOrderDate:{OrderDate}\n");
        }
    }
}
