using Shop.Domain.Products.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products.Commands
{
    public class DeleteProduct
    {
        private readonly IProductRepository _repository;
        public DeleteProduct(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
