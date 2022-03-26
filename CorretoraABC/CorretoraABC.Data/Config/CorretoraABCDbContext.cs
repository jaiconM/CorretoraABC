using CorretoraABC.Domain.Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CorretoraABC.Data.Config
{
    public class CorretoraABCDbContext : DbContext
    {
        private readonly string _dbConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CorretoraABC;Trusted_Connection=True;MultipleActiveResultSets=True";

        public DbSet<Acao> Acoes { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }

        public CorretoraABCDbContext()
        {

        }

        public CorretoraABCDbContext(DbContextOptions<CorretoraABCDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_dbConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DbContextData.LoadInitialData(modelBuilder);
        }
    }
}
