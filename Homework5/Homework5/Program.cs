using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            //先添加一些订单
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for(int i=1;i<5;i++)
            {
                int id = rnd.Next(1, 30);
                int cid = rnd.Next(1, 100);
                Order ord = new Order(id, cid);

                for (int j = 0; j < 2; j++)
                {
                    int pn = rnd.Next(1, 5);
                    int pp = rnd.Next(1, 200);

                    
                    OrderItem ot = new OrderItem(pn, pp);

                    if(!ord.orderItems.Contains(ot)) //避免订单明细重复
                    {
                        ord.orderItems.Add(ot);
                    }
                    
                }

                if (os.TrackOrder(ord.CustomerID)==null)
                {
                    os.AddOrder(ord);
                }
                
                

            }
            os.CalAmount();
            

            while (true)
            {
                Console.WriteLine("请输入你要进行的操作:");
                Console.WriteLine("1.添加订单 2.删除订单 3.修改订单 4.查询订单 5.查看所有订单 6.订单排序");
                int ope = Convert.ToInt32(Console.ReadLine());

                switch (ope)
                {
                    case 1:
                        //添加订单

                        Console.WriteLine("请输入订单号:");
                        int orderid = Convert.ToInt32(Console.ReadLine());
                        //if(os.orderList.)

                        Console.WriteLine("请输入客户ID:");
                        int customerid = Convert.ToInt32(Console.ReadLine());

                        /*Console.WriteLine("请输入交易时间:");
                        string time = Console.ReadLine();
                        DateTime date = new DateTime(time);*/

                        Order ord = new Order(orderid, customerid);
                        
                        if (os.AddOrder(ord))
                        {
                            Console.WriteLine("订单添加成功！");
                        }
                        else
                        {
                            Console.WriteLine("该订单已存在，不能重复添加订单！");
                        }
                        break;

                    case 2://删除订单


                        Console.WriteLine("请输入删除订单的方式: 1.订单号 2.商品名称 3.客户");
                        int way = Convert.ToInt32(Console.ReadLine());
                        switch (way)
                        {
                            case 1:
                                Console.WriteLine("请输入订单号:");
                                int ID = Convert.ToInt32(Console.ReadLine());
                                os.DeleteOrder(ID);
                                break;

                            case 3:
                                Console.WriteLine("请输入客户ID:");
                                int CID = Convert.ToInt32(Console.ReadLine());
                                os.DeleteOrder(CID,1);
                                break;

                        }
                        
                        break;



                    case 3://修改订单

                        Console.WriteLine("请输入要修改的订单号:");
                        int id = Convert.ToInt32(Console.ReadLine());


                        os.ModifyOrder();
                        break;



                    case 4://查询订单
                        
                        Console.WriteLine("请输入查询订单的方式: 1.订单号 2.商品名称 3.客户ID");
                        int way2 = Convert.ToInt32(Console.ReadLine());
                        switch (way2)
                        {
                            case 1:
                                Console.WriteLine("请输入订单号:");
                                int ID = Convert.ToInt32(Console.ReadLine());
                                Order order = os.TrackOrder(ID);
                                if (order==null)
                                {
                                    Console.WriteLine("找不到此订单！");
                                }
                                else
                                {
                                    Console.WriteLine(order);
                                }
                                break;
                            case 2:

                                break;

                            case 3:
                                Console.WriteLine("请输入客户ID:");
                                int CID = Convert.ToInt32(Console.ReadLine());

                                List<Order> list= os.TrackOrder(CID,1);
                                if (list == null)
                                {
                                    Console.WriteLine("找不到此客户！");
                                }
                                else
                                {
                                    foreach(Order orde in list)
                                    {
                                        Console.WriteLine(orde);
                                    }
                                }

                                break;

                            default:
                                break;

                        }
                        
                        break;


                    case 5://查看所有订单
                        foreach(Order or in os.Sort())
                        {
                            Console.WriteLine(or);
                        }
                        break;

                    case 6:
                        //订单排序
                        Console.WriteLine("1.订单ID 2.订单总金额");
                        int sortway = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(os.printOrder(os.Sort(sortway)));
                        break;

                }


            }

        }
    }
}
