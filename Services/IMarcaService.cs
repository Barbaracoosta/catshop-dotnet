using CatShop.Models;

namespace CatShop.Services
{
    public interface IMarcaService
    {
        IList<Marca> BuscarTodos();
        Marca BuscarPorId(int id);
        void Incluir(Marca marca);
        void Alterar(Marca marca);
        void Excluir(int id);
    }
}
