using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alexandru_Gorgan_Proiect.Data;
using Alexandru_Gorgan_Proiect.Models;

namespace Alexandru_Gorgan_Proiect.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private readonly Alexandru_Gorgan_Proiect.Data.Alexandru_Gorgan_ProiectContext _context;

        public IndexModel(Alexandru_Gorgan_Proiect.Data.Alexandru_Gorgan_ProiectContext context)
        {
            _context = context;
        }

        public IList<Actor> Actor { get;set; }

        public async Task OnGetAsync()
        {
            Actor = await _context.Actor
                .Include(a => a.Film).ToListAsync();
        }
    }
}
