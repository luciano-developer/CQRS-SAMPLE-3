using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Category_OLD: EntityBase<Int64>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}