using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Interfaces;
using Shop.Domain.Common.ValueObjects;
using System.Numerics;

namespace Shop.Domain.Products.Entities
{
    public class Product : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }
        private Product() { }
        public Product(string name, Money price)
        {
            ChangeName(name);
            ChangePrice(price);
        }
        private void ChangeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new DomainException("Product name is required");
            Name = name;
        }
        private void ChangePrice(Money price)
        {
            if (price.Amount <= 0)
            {
                throw new DomainException("Money must be greater than zero");
            }
            Price = price;
        }
    }
}
