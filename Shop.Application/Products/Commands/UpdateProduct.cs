using Shop.Domain.Products.Entities;
using Shop.Domain.Products.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products.Commands
{
    public class UpdateProduct
    {
        private readonly IProductRepository _repository;
        public UpdateProduct(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Update(Product product)
        {
            _repository.UpdateAsync(product);
        }
    }
}
