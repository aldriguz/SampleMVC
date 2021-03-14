using SampleMVC.Core.Entities;
using System.Data.Entity;

namespace SampleMVC.Infraestructure.Data
{
    public class SampleMvcContext : DbContext
    {
        public SampleMvcContext() : base("SampleMvcDb")
        {

        }
        public DbSet<Property> property { get; set; }
    }
}
