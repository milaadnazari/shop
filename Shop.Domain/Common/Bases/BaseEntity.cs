using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Common.Bases
{
    public class BaseEntity
    {
        public int Id { get; set; }
        bool IsDeleted { get; set; } = false;
    }
}
