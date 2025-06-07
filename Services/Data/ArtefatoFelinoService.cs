using CatShop.Data;
using CatShop.Models;

namespace CatShop.Services.Data
{
    public class ArtefatoFelinoService : IArtefatoFelinoService
    {
        private ArtefatoFelinoDbContext _db;
        public ArtefatoFelinoService(ArtefatoFelinoDbContext dbContext)
        {
            _db = dbContext;
            
        }

        public void Alterar(ArtefatoFelino ArtefatoFelino)
        {
            var artefatoSelecionado = BuscarPorId(ArtefatoFelino.ArtefatoFelinoId);
            artefatoSelecionado.Nome = ArtefatoFelino.Nome;
            artefatoSelecionado.Descricao = ArtefatoFelino.Descricao;
            artefatoSelecionado.Preco = ArtefatoFelino.Preco;
            artefatoSelecionado.Imagem = ArtefatoFelino.Imagem;
            artefatoSelecionado.Disponibilidade = ArtefatoFelino.Disponibilidade;
            artefatoSelecionado.DataCadastro = ArtefatoFelino.DataCadastro;
            artefatoSelecionado.MarcaId = ArtefatoFelino.MarcaId;

            _db.SaveChanges();  
            
        }

        public ArtefatoFelino BuscarPorId(int id)
        {
            return _db.ArtefatoFelino.SingleOrDefault(artefato => artefato.ArtefatoFelinoId == id);
        }

        public IList<ArtefatoFelino> BuscarTodos()
        {
            return _db.ArtefatoFelino.ToList();
        }

        public void Excluir(int id)
        {
            var artefatoSelecionado = BuscarPorId(id);
            _db.ArtefatoFelino.Remove(artefatoSelecionado);
            _db.SaveChanges();
        }

        public void Incluir(ArtefatoFelino ArtefatoFelino)
        {
            _db.ArtefatoFelino.Add(ArtefatoFelino);
            _db.SaveChanges();
        }

        public IList<Marca> ConsultarMarcas()
        {
           return _db.Marca.ToList();
        }
        public Marca ObterMarca(int id)
       => _db.Marca.SingleOrDefault(item => item.MarcaId == id);
    }
}
