using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Enums;
using Shop.Domain.Common.Exceptions;
using Shop.Domain.Common.Interfaces;
using Shop.Domain.Customers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Orders.Entities
{
    public class Order : BaseEntity, IAggregateRoot
    {
        private readonly List<OrderItem> _items = new();

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items;

        private Order() { }

        public Order(int customerId, DateTime orderDate)
        {
            Status = OrderStatus.Pending;
            CustomerId = customerId;
            OrderDate = orderDate;
        }
        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }
        public void AddItems(List<OrderItem> items)
        {
            _items.AddRange(items);
        }
        public void ChangePrice(int itemId, decimal price)
        {
            if (Status != OrderStatus.Pending)
                throw new DomainException("Order status is not pending to change price");

            if (price <= 0)
                throw new DomainException("invalid price value to change price");

            var item = _items.FirstOrDefault(i => i.Id == itemId) ??
                throw new DomainException("Item not found to change price");
            item.ChangePrice(price);
        }
        public void ChangeQuantity(int itemId, int quantity)
        {
            if (Status != OrderStatus.Pending)
                throw new DomainException("Order status is not pending to change quantity");

            if (quantity <= 0)
                throw new DomainException("invalid quantity value to change quantity");

            var item = _items.FirstOrDefault(i => i.Id == itemId) ??
                throw new DomainException("Item not found to change quantity");
            item.ChangeQuantity(quantity);
        }
        public void MarkAsPaid()
        {
            if (Status != OrderStatus.Pending)
                throw new InvalidOperationException("Order is paid.");

            Status = OrderStatus.Paid;
        }

        public void StartProcessing()
        {
            if (Status != OrderStatus.Paid)
                throw new InvalidOperationException("Order is not paid.");

            Status = OrderStatus.Processing;
        }

        public void Ship()
        {
            if (Status != OrderStatus.Processing)
                throw new InvalidOperationException("Order is not ready to ship.");

            Status = OrderStatus.Shipped;
        }

        public void Deliver()
        {
            if (Status != OrderStatus.Shipped)
                throw new InvalidOperationException("Order is not shipped.");

            Status = OrderStatus.Delivered;
        }

        public void Cancel()
        {
            if (Status == OrderStatus.Delivered)
                throw new InvalidOperationException("Delivered order cannot be cancelled.");

            Status = OrderStatus.Cancelled;
        }
    }
}
