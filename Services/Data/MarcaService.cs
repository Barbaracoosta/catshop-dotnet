using CatShop.Data;
using CatShop.Models;

namespace CatShop.Services.Data
{
    public class MarcaService : IMarcaService
    {
        private ArtefatoFelinoDbContext _db;
        public MarcaService(ArtefatoFelinoDbContext dbContext)
        {
            _db = dbContext;

        }

        public void Alterar(Marca marca)
        {
            var marcaSelecionada = BuscarPorId(marca.MarcaId);
            marcaSelecionada.Nome = marca.Nome;
                        

            _db.SaveChanges();

        }

        public Marca BuscarPorId(int id)
        {
            return _db.Marca.SingleOrDefault(marca => marca.MarcaId == id);
        }

        public IList<Marca> BuscarTodos()
        {
            return _db.Marca.ToList();
        }

        public void Excluir(int id)
        {
            var marcaSelecionada = BuscarPorId(id);
            _db.Marca.Remove(marcaSelecionada);
            _db.SaveChanges();
        }

        public void Incluir(Marca marca)
        {
            _db.Marca.Add(marca);
            _db.SaveChanges();
        }

        
    }
}
