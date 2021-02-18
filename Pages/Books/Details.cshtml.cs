using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorgan_Alexandru_lab8.Data;
using Gorgan_Alexandru_lab8.Models;

namespace Gorgan_Alexandru_lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Gorgan_Alexandru_lab8.Data.Gorgan_Alexandru_lab8Context _context;

        public DetailsModel(Gorgan_Alexandru_lab8.Data.Gorgan_Alexandru_lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
