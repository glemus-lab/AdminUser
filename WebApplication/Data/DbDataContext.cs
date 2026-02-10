using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DbDataContext : DbContext
    {
        public DbDataContext(DbContextOptions<DbDataContext> options) : base(options)
        {
            
        }
    }
}
