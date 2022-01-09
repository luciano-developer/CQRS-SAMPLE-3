using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class OrderPaymentAssociation_OLD: EntityBase<Int64>
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}