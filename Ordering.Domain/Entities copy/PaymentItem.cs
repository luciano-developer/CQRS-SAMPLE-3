using System;
using Ordering.Domain.Entities.Base;

namespace Ordering.Domain.Entities
{
    public class PaymentItem_OLD:EntityBase<Int64>
    {
      public decimal Amount { get; set; }

        public PaymentMethod Method { get; set; }
    }

    public enum PaymentMethod_OLD
    {
        Cash = 1,
        CreditCard = 2,
        Check = 3,
        BankTransfer = 4,
        Paypal = 5,
        Payoneer = 6
    }
}