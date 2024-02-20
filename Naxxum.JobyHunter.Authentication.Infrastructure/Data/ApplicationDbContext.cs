using Microsoft.EntityFrameworkCore;
using Naxxum.JobyHunter.Authentication.Domain.Entities;


namespace Naxxum.JobyHunter.Authentication.Infrastructure.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Blog> Blogs { get; set; }

    }

}
