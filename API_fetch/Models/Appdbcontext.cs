using Microsoft.EntityFrameworkCore;

namespace API_fetch.Models
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext()
        { }
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
              : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DemoData1;Integrated Security=True");
            }
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserInfo> userInfos { get; set; }
    }
}
