using ExoApi.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = DESKTOP-JBA9HEP\\SQLEXPRESS;" + "initial catalog = ExoApi; Integrated Security=true;");

            }
        }

        public DbSet<Projeto> Livros { get; set; }

    }
}



