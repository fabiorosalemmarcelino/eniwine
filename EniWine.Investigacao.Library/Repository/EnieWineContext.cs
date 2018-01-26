using EniWine.Investigacao.Library.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EniWine.Investigacao.Library.Repository
{
    public class EnieWineContext : DbContext
    {
        public EnieWineContext() : base("EniWine")
        {
        }

        public DbSet<Arma> Arma { get; set; }

        public DbSet<Local> Local { get; set; }

        public DbSet<Suspeito> Suspeito { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
