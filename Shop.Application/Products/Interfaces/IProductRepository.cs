using Shop.Application.Common.Interfaces;
using Shop.Domain.Products.Entities;
using Shop.Domain.Products.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products.Interfaces
{
    public interface IProductRepository : Domain.Products.Interface.IProductRepository, IBaseRepository<Product>
    {

    }
}
