using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class ValuesDBContext:DbContext
    {
        public ValuesDBContext(DbContextOptions<ValuesDBContext> options):base(options)
        {
            Database.Migrate();
        }

        public DbSet<Value> Values { get; set; }
    }

}
