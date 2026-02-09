using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>();

            options.UseSqlServer(
                "Data Source=.\\sql19;Initial Catalog=Shop;User ID=sa;Password=123;Trust Server Certificate=True;");

            return new AppDbContext(options.Options);
        }
    }
}
