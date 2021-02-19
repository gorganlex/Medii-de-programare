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
    public class DeleteModel : PageModel
    {
        private readonly Alexandru_Gorgan_Proiect.Data.Alexandru_Gorgan_ProiectContext _context;

        public DeleteModel(Alexandru_Gorgan_Proiect.Data.Alexandru_Gorgan_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Actor Actor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actor = await _context.Actor
                .Include(a => a.Film).FirstOrDefaultAsync(m => m.ID == id);

            if (Actor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actor = await _context.Actor.FindAsync(id);

            if (Actor != null)
            {
                _context.Actor.Remove(Actor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
