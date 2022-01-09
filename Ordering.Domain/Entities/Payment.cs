using System;
using System.Collections.Generic;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Payment: EntityBase<Int64>
    {
        public decimal GrandTotal { get; set; }

        public List<PaymentItem> Items { get; set; } = new List<PaymentItem>();

        public Contract Contract { get; set; }

        public Order Order { get; set; } 
    }
}