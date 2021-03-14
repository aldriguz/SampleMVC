using SampleMVC.Core.Entities;
using System.Data.Entity;

namespace SampleMVC.Infraestructure.Data
{
    public class SampleMvcContext : DbContext
    {
        public DbSet<Property> property { get; set; }
    }
}
