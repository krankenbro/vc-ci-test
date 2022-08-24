using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VirtoCommerce.CITest.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CITestDbContext>
    {
        public CITestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CITestDbContext>();

            builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

            return new CITestDbContext(builder.Options);
        }
    }
}
