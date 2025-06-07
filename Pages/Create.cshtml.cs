using CatShop.Models;
using CatShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatShop.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private IArtefatoFelinoService _service;
        private IMarcaService _marcaService;
        public SelectList Marcas { get; set; }

        public CreateModel(IArtefatoFelinoService service, IMarcaService marcaService)
        {
            _service = service;
            _marcaService = marcaService;
        }

        public void OnGet()
        {
            Marcas = new SelectList(_marcaService.BuscarTodos(),
                                                nameof(Marca.MarcaId),
                                                nameof(Marca.Nome));

        }

        [BindProperty]
        public ArtefatoFelino ArtefatoFelino { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Incluir(ArtefatoFelino);

            return RedirectToPage("/Index");
        }
    }
}