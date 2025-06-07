using CatShop.Models;
using CatShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatShop.Pages
{
    [Authorize]
    public class EditModel : PageModel
    {
        private IArtefatoFelinoService _service;
        
        public SelectList Marcas { get; set; }

        public EditModel(IArtefatoFelinoService service, IMarcaService marcaService)
        {
            _service = service;
            Marcas = new SelectList(marcaService.BuscarTodos(),
                                               nameof(Marca.MarcaId),
                                               nameof(Marca.Nome));
        }

        [BindProperty]
        public ArtefatoFelino ArtefatoFelino { get; set; }

        public IActionResult OnGet(int id)
        {
            ArtefatoFelino = _service.BuscarPorId(id);

            if (ArtefatoFelino == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(ArtefatoFelino);

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao()
        {
           _service.Excluir(ArtefatoFelino.ArtefatoFelinoId);

            return RedirectToPage("/Index");
        }
    }
}
