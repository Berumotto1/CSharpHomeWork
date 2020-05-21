using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinform
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            CustomerID = Guid.NewGuid().ToString();
        }
        public Customer(string name)
        {
            Name = name;
            CustomerID = Guid.NewGuid().ToString();
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   CustomerID == customer.CustomerID &&
                   Name == customer.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = -1485506078;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
