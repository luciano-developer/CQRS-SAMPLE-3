using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class Address_OLD: EntityBase<Int64>
    {
         public string AddressTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}