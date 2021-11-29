using Hahn.ApplicatonProcess.July2021.Data.Models.Configurations;
using Hahn.ApplicatonProcess.July2021.Domain.Model;
using Hahn.ApplicatonProcess.July2021.Domain.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.July2021.Data.Models
{
    public class HahnContext : DbContext
    {

        public HahnContext(DbContextOptions<HahnContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new AddressConfiguration());
            // modelBuilder.ApplyConfiguration(new AssetConfiguration());
        }
    }
}
