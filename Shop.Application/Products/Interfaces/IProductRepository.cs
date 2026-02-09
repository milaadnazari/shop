using Shop.Application.Common.Interfaces;
using Shop.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {

    }
}
