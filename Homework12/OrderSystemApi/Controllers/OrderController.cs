using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderSystemApi.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderSystemApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        
        private readonly OrderContext orderDb;

        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        //查
        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string orderId)
        {
            var query = buildQuery(orderId);
            return query.ToList();
        }


        private IQueryable<Order> buildQuery(string id)
        {
            IQueryable<Order> query = orderDb.Orders;
            if (id !="")
            {
                query = query.Include("OrderItems").Where(t => t.OrderId==id);
            }

            return query;
        }

        // POST: api/order
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(t => t.OrderId == id);
                if (order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> ModifyOrder(string id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

 


     
    }

    
}
