using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinform
{
    public class Goods
    {
        public string GoodsID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods()
        {
        }
        public Goods(string name, double price)
        {
            GoodsID = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null &&
                   GoodsID == goods.GoodsID &&
                   Name == goods.Name &&
                   Price == goods.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = 710445796;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
