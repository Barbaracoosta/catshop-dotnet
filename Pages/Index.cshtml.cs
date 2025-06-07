using CatShop.Models;
using CatShop.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatShop.Pages;

public class IndexModel : PageModel
{
    private IArtefatoFelinoService _service;

    public IndexModel(IArtefatoFelinoService service)
    {
        _service = service;
    }

    public IList<ArtefatoFelino> ArtefatoFelinos { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ArtefatoFelinos = _service.BuscarTodos();
    }
}
