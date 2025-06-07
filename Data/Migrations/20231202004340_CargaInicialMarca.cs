using CatShop.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicialMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new ArtefatoFelinoDbContext();
            context.Marca.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicial()
        {
            return new List<Marca>()
            {
                new Marca() { Nome = "Bad Cats"},
                new Marca() { Nome = "Gatuno"},
                new Marca() { Nome = "Felinex"}
            };
        }
    }
}
