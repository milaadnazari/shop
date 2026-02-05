using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Interfaces;
using Shop.Domain.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Customers.Entities
{
    public class Customer : BaseEntity, IAggregateRoot
    {
        private readonly List<Order> _orders= new();
        public string Name { get; private set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public IReadOnlyCollection<Order> Orders => _orders;
        public Customer(string name, string family)
        {
            Name = name;
            Family = family;
        }
        private Customer()
        {
            
        }
    }
}
