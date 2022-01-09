using System;
using System.Collections.Generic;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Contract_OLD: EntityBase<Int64>
    {
      public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        public ContractStatus Status { get; set; }
        public decimal GrandTotal { get; set; }

        public List<ContractItem> Items { get; set; } = new List<ContractItem>();

        // n-n relationships
        public IList<ContractPaymentAssociation_OLD> Payments { get; set; } = new List<ContractPaymentAssociation_OLD>();
    }

    public enum ContractStatus_OLD
    {
        OnGoing = 1,
        Closed = 2
    }
}