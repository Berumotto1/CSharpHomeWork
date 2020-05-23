using System;
using System.Collections.Generic;

namespace OrderSystemApi.Models
{
    public  class Order{
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public double OrderAmount { get; set; }
        public string orderDate{get;set;}

        public List<OrderItem> OrderItems{get;set;}
    }

}