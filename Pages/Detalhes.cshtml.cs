using CatShop.Models;
using CatShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatShop.Pages
{
    public class DetalhesModel : PageModel
    {
        private IArtefatoFelinoService _service;
        private IMarcaService _marcaService;
        public string Marca { get; set; }

        public DetalhesModel(IArtefatoFelinoService service, IMarcaService marcaService)
        {
            _service = service;
            _marcaService = marcaService;
        }

        public ArtefatoFelino ArtefatoFelino { get; private set; }

        public IActionResult OnGet(int id)
        {
            ArtefatoFelino = _service.BuscarPorId(id);

            if (ArtefatoFelino.MarcaId is not null)
            {
                Marca = _marcaService.BuscarPorId(ArtefatoFelino.MarcaId.Value).Nome;
            }

            if (ArtefatoFelino == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

