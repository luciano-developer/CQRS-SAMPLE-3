using System;
using System.Collections.Generic;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Payment_OLDS: EntityBase<Int64>
    {
        public decimal GrandTotal { get; set; }

        public List<PaymentItem> Items { get; set; } = new List<PaymentItem>();
    }
}