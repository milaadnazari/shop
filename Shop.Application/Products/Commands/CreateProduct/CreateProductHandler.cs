using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Application.Products.DTOs;
using Shop.Domain.Products.Entities;
using Shop.Domain.Products.Interface;
using Shop.Domain.Products.ValueObjects;

namespace Shop.Application.Products.Commands.CreateProduct
{
    public class CreateProductHandler
    {
        private readonly IProductRepository _repo;

        public CreateProductHandler(IProductRepository repo)
        {
            _repo = repo;
        }
        public void Handle(CreateProductCommand productCommand)
        {
            var price = new Money(productCommand.Price);
            var product = new Product(productCommand.Name, price);
            _repo.Add(product);
        }
    }
}
