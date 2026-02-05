using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Exceptions;
using Shop.Domain.Common.Interfaces;
using Shop.Domain.Common.ValueObjects;
using Shop.Domain.Orders.Entities;
using System.Numerics;

namespace Shop.Domain.Products.Entities
{
    public class Product : BaseEntity, IAggregateRoot
    {
        private readonly List<OrderItem> _orders = new();
        public string Name { get; private set; }
        public Money Price { get; private set; }
        public bool IsActive { get; private set; } = true;
        public int CategoryId { get; private set; }
        public Category Category { get; set; }
        public IReadOnlyCollection<OrderItem> Orders => _orders;
        private Product() { }
        public Product(string name, Money price, int categoryId)
        {
            ChangeName(name);
            ChangePrice(price);
            CategoryId = categoryId;
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
        public void Deactive()
        {
            if (IsActive) IsActive = false;
        }
        public void Active()
        {
            if (!IsActive) IsActive = true;
        }
    }
}
