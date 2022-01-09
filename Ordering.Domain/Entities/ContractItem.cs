using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class ContractItem: EntityBase<Int64>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}