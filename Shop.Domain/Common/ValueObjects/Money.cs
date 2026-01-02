using Shop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Common.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; private set; }
        private Money() { }
        public Money(decimal amount)
        {
            if (amount <= 0) throw new DomainException("Invalid money value");
            Amount = amount;
        }
    }
}
