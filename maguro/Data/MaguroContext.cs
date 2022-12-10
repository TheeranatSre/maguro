using maguro.Models;
using Microsoft.EntityFrameworkCore;

namespace maguro.Data
{
    public class MaguroContext : DbContext
    {
        public string _connectionString;

        public MaguroContext(DbContextOptions<MaguroContext> options) : base(options) { }

        public MaguroContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseNpgsql(_connectionString);
        }

        public DbSet<HealthCheckModel> HealthCheckModels { get; set; }
    }
}
