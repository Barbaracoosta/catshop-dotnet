using CatShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CatShop.Data
{
    public class ArtefatoFelinoDbContext : IdentityDbContext
    {
        public DbSet<ArtefatoFelino> ArtefatoFelino {get; set; }
        public DbSet<Marca> Marca { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var stringconn = config.GetConnectionString("StringConn");
            optionsBuilder.UseSqlServer(stringconn);
        }
    }
}
