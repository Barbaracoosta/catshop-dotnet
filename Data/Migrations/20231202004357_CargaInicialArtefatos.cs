using CatShop.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicialArtefatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new ArtefatoFelinoDbContext();
            context.ArtefatoFelino.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<ArtefatoFelino> ObterCargaInicial()
        {
            return new List<ArtefatoFelino>()
        {
            new ArtefatoFelino
            {
                Nome = "Playground",
                Descricao ="Nosso playground interativo" ,
                Imagem = "/imagens/b1.jpg",
                Preco = 99.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },

            new ArtefatoFelino
            {
                Nome = "Kit Filhote",
                Descricao ="Inclui 1 * túnel de tenda" ,
                Imagem = "/imagens/b2.jpg",
                Preco = 79.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                Nome = "Relax",
                Descricao ="O Cat Relax Furacão Pet" ,
                Imagem = "/imagens/b3.jpg",
                Preco = 49.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                Nome = "Tunel",
                Descricao ="Túnel Interativo" ,
                Imagem = "/imagens/b4.jpg",
                Preco = 59.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                Nome = "Casinha com rede",
                Descricao ="A casinha para gatos" ,
                Imagem = "/imagens/a1.jpg",
                Preco = 200.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            },
            new ArtefatoFelino
            {
                Nome = "Arranhador",
                Descricao ="O Arranhador Para Gato!" ,
                Imagem = "/imagens/a2.jpg",
                Preco = 99.00,
                Disponibilidade = true,
                DataCadastro = DateTime.Now
            }
            };
        }
    }
}
