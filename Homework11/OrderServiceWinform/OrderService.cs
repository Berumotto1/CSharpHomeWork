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
                    var order = db.Orders.Include("OrderItems").Where(o => o.OrderID == id).FirstOrDefault();
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

        public static void UpdateOrder(Order newOrder)
        {
            RemoveItems(newOrder.OrderID);
            using (var db = new OrderContext())
            {
                db.Entry(newOrder).State = EntityState.Modified;
                db.OrderItems.AddRange(newOrder.orderItems);
                db.SaveChanges();
            }
        }
        public static List<Order> TrackOrderByCustomerName(string CustomerName) 
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db).Where(o => o.Customer.Name == CustomerName);
                return query.ToList();
            }
        }

        public static object TrackOrderByTotalAmount(float amount)
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db)
                  .Where(o => o.orderItems.Sum(item => item.GoodsItem.Price * item.GoodsNum) > amount)
                  .ToList();
            }
        }

        public static object TrackOrderByGoodsName(string goodsName)
        {
            using (var db = new OrderContext())
            {
                var query = AllOrders(db)
                        .Where(o => o.orderItems.Count(i => i.GoodsItem.Name == goodsName) > 0);
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

        public static Order TrackOrder(string id)
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).FirstOrDefault(o => o.OrderID == id);
            }
        }





        public static void Export(String fileName) //fileName传递文件名
        {
            //将所有订单序列化为XML文件
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xmlserializer.Serialize(fs, TrackAllOrders());
            }
        }

        public static void Import(String fileName)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            //从XML文件中载入订单 
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlserializer.Deserialize(fs);
                foreach(Order o in temp) //导入订单
                {
                    try
                    {
                        AddOrder(o);
                    }
                    catch
                    {
                    }
                    
                }
                
            }
        }
    }
}
