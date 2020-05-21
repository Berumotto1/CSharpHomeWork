using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data.Entity;

namespace OrderServiceWinform
{
    [Serializable]
    public class OrderService
    {
        private static IQueryable<Order> AllOrders(OrderContext db)
        {
            return db.Orders.Include(o => o.orderItems.Select(i => i.GoodsItem))
                      .Include("Customer");
        }
    
        public static Order AddOrder(Order order)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
                return order;
            }
            catch (Exception e)
            {
                throw new ApplicationException($"添加错误: {e.Message}");
            }
        }

        public static void DeleteOrder(string id)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = db.Orders.Include("Items").Where(o => o.OrderID == id).FirstOrDefault();
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                //TODO 需要更加错误类型返回不同错误信息
                throw new ApplicationException($"删除订单错误!");
            }
        }

        public static void DeleteOrder(string cid,int a) 
            //通过客户ID删除 a为冗余参数  一个客户可能有多个订单
        {
            using (var db = new OrderContext())
            {
                var orders = db.Orders.Where(o => o.CustomerID == cid);
                db.Orders.RemoveRange(orders);
                db.SaveChanges();
            }

        }
        private static void RemoveItems(string orderId)
        {
            using (var db = new OrderContext())
            {
                var oldItems = db.OrderItems.Where(item => item.OrderId == orderId);
                db.OrderItems.RemoveRange(oldItems);
                db.SaveChanges();
            }
        }
        public static void ModifyOrder(Order newOrder)
        {
            RemoveItems(newOrder.OrderID);
            using (var db = new OrderContext())
            {
                db.Entry(newOrder).State = EntityState.Modified;
                db.OrderItems.AddRange(newOrder.orderItems);
                db.SaveChanges();
            }

        }
        public static Order TrackOrder(string id) 
            //重载查询方法，用来添加，修改，删除的时候查看是否含有要操作的订单
        {
            //通过订单id来查询
            using (var db = new OrderContext())
            {
                return AllOrders(db).FirstOrDefault(o => o.OrderID == id);
            }
        }
        public static List<Order> TrackOrder(string cid, int a) 
            //通过客户ID查询 a为冗余参数  一个客户可能有多个订单
        {
            //通过客户id来查询  按照订单总金额排序
            using (var db = new OrderContext())
            {
                var query = AllOrders(db).Where(order => order.CustomerID == cid).
                OrderBy(order => order.OrderAmount);
                return query.ToList();
            }
          
        }

        public static List<Order> TrackAllOrders()
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).ToList();
            }
        }

        public static List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db)
                  .Where(o => o.orderItems.Count(i => i.GoodsItem.Name == goodsName) > 0);
                return query.ToList();
            }
        }
        public static List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db)
                  .Where(o => o.Customer.Name == customerName);
                return query.ToList();
            }
        }
      
        
      
        public static void Export(String fileName) //fileName传递文件名
        {
            //将所有订单序列化为XML文件
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlserializer.Serialize(fs, TrackAllOrders());
            }
        }

        public static void Import(String fileName)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Order[]));
            //从XML文件中载入订单 
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlserializer.Deserialize(fs);
                foreach(Order o in temp) //导入订单
                {
                    AddOrder(o);
                }
                
            }
        }
    }
}
