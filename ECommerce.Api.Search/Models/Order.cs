﻿namespace ECommerce.Api.Search.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}