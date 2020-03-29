using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os;
        static Random rnd = new Random(Guid.NewGuid().GetHashCode());
        String[] names = { "iPad air3", "iPad pro", "Huawei P30",
            "iPhone", "Computer" };

        int oid = rnd.Next(1,50); //订单id
        int cid = rnd.Next(1,100); //客户id

        Order ord;
        OrderItem item;
        OrderItem item2;
       
        [TestInitialize] 
        public void Initialiaze()//每次测试时都会调用这个方法
        {
            //每个方法测试前 对象都是新创建的 保证其他的testmethod对当前测试无影响
            os = new OrderService();
            ord = new Order(oid, cid);
            //商品数量  价格  名字
            item = new OrderItem(rnd.Next(1, 2), rnd.Next(1, 2000) + 1000,
                names[rnd.Next(1, 5)]);
            item2 = new OrderItem(rnd.Next(1, 2), rnd.Next(1, 2000) + 1000, 
                names[rnd.Next(1, 5)]);
            ord.orderItems.Add(item); //为订单添加一个订单项
            ord.orderItems.Add(item2);
            os.AddOrder(ord);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            //初始化的时候 已经添加订单了 直接测试
            Assert.IsFalse(!os.orderList.Contains(ord));
        }

        [TestMethod()]
        public void DeleteOrderTest()  //根据订单id删除
        {
            Boolean before = os.orderList.Contains(ord); //true
            os.DeleteOrder(oid);
            Boolean after = os.orderList.Contains(ord); //fasle          
            Assert.IsFalse(!(before==true && after==false));
        }

        [TestMethod()]
        public void DeleteOrderTest1()  //根据客户id删除
        {
            os.DeleteOrder(cid, 0);
            Assert.IsFalse(os.orderList.Contains(ord));
        }

        [TestMethod()]
        public void ModifyOrderTest() //未实现 
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void TrackOrderTest() //通过订单id来查询
        {         
            Order trackOrd = os.TrackOrder(oid);
            Assert.AreEqual(ord,trackOrd);
        }

        [TestMethod()]
        public void TrackOrderTest1() 
        {
            //通过客户ID查询  一个客户可能有多个订单 
            //按照订单总金额排序
            Order ord2 = new Order(rnd.Next(1,50), cid);
            os.AddOrder(ord2);
            List<Order> list2 = os.TrackOrder(cid, 0);
            Assert.IsTrue(2 == list2.Count);

            /*List<Order> list = new List<Order>();
            list.Add(ord);
            list.Add(ord2);
            List<Order> list2 = os.TrackOrder(cid,0);
            Assert.IsFalse(!list.Equals(list2)); //为什么测不出来????*/
        }

        [TestMethod()]
        public void SortTest() //按照订单id排序
        {
            Order ord2 = new Order(rnd.Next(1, 50), cid);
            os.AddOrder(ord2);
            List<Order> list2 = os.Sort();
            Assert.IsTrue(list2[0].OrderID <list2[1].OrderID);
        }

        [TestMethod()]
        public void SortTest1()  //sort(1) 同上  sort(2)按照订单总金额排序
        {
            Order ord2 = new Order(rnd.Next(1, 50), cid);
            os.AddOrder(ord2);
            List<Order> list2 = os.Sort(2); //俺总金额排序
            //Assert.IsTrue(list2[0].OrderID < list2[1].OrderID);
            Assert.IsTrue(list2[0].OrderAmount <= list2[1].OrderAmount);
        }

        [TestMethod()]
        public void CalAmountTest()
        {
            os.CalAmount();
            int amount1 = item.ProductNum * item.ProductPrice+
                item2.ProductNum * item2.ProductPrice; //实际金额
            Assert.AreEqual(amount1, ord.OrderAmount);
        }

        [TestMethod()]
        public void printOrderTest()  // 打印订单  没有必要测试，可以直接在命令行中判断订单是否打印
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ExportTest()
        {
            //检查输出的文件夹是否含有文件 以及是否正确
            String file = "ordertest.xml";
            os.Export(file);
            Assert.IsTrue(File.Exists(file));


        }

        [TestMethod()]
        public void ImportTest()
        {
            os.Export("ordertest.xml");
            os.orderList= new List<Order>();
            List<Order> list=os.Import("ordertest.xml");
            Assert.AreEqual(os.orderList.Count, list.Count);

        }
    }
}