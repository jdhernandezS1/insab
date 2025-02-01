using Microsoft.EntityFrameworkCore;

namespace momi.Models
{
  public class MyDbContext : DbContext
  {
        public MyDbContext(DbContextOptions<MyDbContext> op)
      :base(op)
        {
            
        }


        public DbSet<Cliente> Cliente { get; set; }

    }
}
