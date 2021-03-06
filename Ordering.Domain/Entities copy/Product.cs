using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Product_OLD: EntityBase<Int64>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public double Star { get; set; }

        // n-1 relationships
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}