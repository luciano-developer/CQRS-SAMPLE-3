using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class ContractPaymentAssociation_OLD: EntityBase<Int64>
    {
        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}