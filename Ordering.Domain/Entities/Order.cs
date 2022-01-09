using System;
using System.Collections.Generic;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Order: EntityBase<Int64>
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public OrderStatus Status { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // n-n relationships
        public ICollection<Payment> Payments { get; set; }
    }

    public enum OrderStatus
    {
        Draft = 1,
        Canceled = 2,
        Closed = 3
    }
}