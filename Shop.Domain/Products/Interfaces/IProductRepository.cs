using Shop.Domain.Common.Interfaces;
using Shop.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Products.Interface
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
