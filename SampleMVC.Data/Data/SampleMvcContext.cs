using Microsoft.EntityFrameworkCore;
using SampleMVC.Core.Entities;

namespace SampleMVC.Infraestructure.Data
{
    public class SampleMvcContext : DbContext
    {
        public SampleMvcContext(DbContextOptions<SampleMvcContext> options) : base(options)
        {

        }
        public DbSet<Property> property { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("dbo");
            builder.Entity<Property>(entity => entity.ToTable("Properties"));
        }
    }
}
