﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatShop.Data;
using CatShop.Models;

namespace CatShop.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly CatShop.Data.ArtefatoFelinoDbContext _context;

        public IndexModel(CatShop.Data.ArtefatoFelinoDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}
