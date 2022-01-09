using System;
using System.Collections.Generic;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Customer_OLD: EntityBase<Int64>
    {
        public string Name { get; set; }   
        public string SurName { get; set; }  
        public string Phone { get; set; }
        public int DefaultAddressId { get; set; }
        public Address DefaultAddress { get; set; }
        public string Email { get; set; }
        public string CitizenId { get; set; }
        public List<Address> ListAddresses { get; set; } = new List<Address>();
    }
}