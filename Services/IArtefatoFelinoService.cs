using CatShop.Models;

namespace CatShop.Services;

public interface IArtefatoFelinoService
{
    IList<ArtefatoFelino> BuscarTodos();
    ArtefatoFelino BuscarPorId(int id);
    void Incluir(ArtefatoFelino ArtefatoFelino);
    void Alterar(ArtefatoFelino ArtefatoFelino);
    void Excluir(int id);
    
}
