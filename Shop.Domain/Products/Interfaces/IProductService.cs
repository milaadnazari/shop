using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Products.Interface
{
    public interface IProductService
    {
        bool IsNameUnique(string name);
    }
}
