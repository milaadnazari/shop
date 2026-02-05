using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Exceptions;
using Shop.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Orders.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; private set; }
        public Order Order { get; set; }
        public int ProductId { get; private set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }

        public decimal TotalPrice => Quantity * UnitPrice;

        private OrderItem() { }

        internal OrderItem(int orderId, int productId, decimal unitPrice, int quantity)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
        internal void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
        }
        internal void ChangePrice(decimal unitPrice)
        {
            UnitPrice = unitPrice;
        }
    }
}
